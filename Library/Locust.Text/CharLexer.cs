using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Locust.Text
{
    public class CharLexer : IEnumerable<char>
    {
        class ExpectItem
        {
            public int Index { get; set; }
            public string Value { get; set; }
            public string ReadValue { get; set; }
        }
        public CharLexer(string source)
        {
            this.source = source;

            WordPattern = @"^([a-zA-Z]|\d|_)+$";

            Reset();
        }
        #region Fields
        private string source;
        private char? lastChar;
        private int position;
        private int col;
        private int row;
        private char currentChar;

        private char? tempLastChar;
        private int tempPosition;
        private int tempCol;
        private int tempRow;
        private char tempCurrentChar;
        #endregion
        #region Props
        public string Source
        {
            get { return source; }
            set
            {
                source = value;
                Reset();
            }
        }
        public int Position
        {
            get { return position + 1; }
        }
        public int Col
        {
            get { return col; }
        }
        public int Row
        {
            get { return row; }
        }
        public char Current
        {
            get
            {
                return currentChar;
            }
        }
        public string WordPattern { get; set; }
        #endregion
        #region Methods
        public void StoreState()
        {
            tempLastChar = lastChar;
            tempPosition = position;
            tempCol = col;
            tempRow = row;
            tempCurrentChar = currentChar;
        }
        public void RestoreState()
        {
            lastChar = tempLastChar;
            position = tempPosition;
            col = tempCol;
            row = tempRow;
            currentChar = tempCurrentChar;
        }
        bool IsNewTokenStarting(char ch)
        {
            return char.IsLetterOrDigit(ch) || ch == '_';
        }
        public bool Read(string value, bool ignoreCase)
        {
            var result = true;

            if (Regex.IsMatch(value, WordPattern))
            {
                var started = false;
                var e = value.GetEnumerator();
                var index = 0;

                while (Next())
                {
                    if (!started && char.IsWhiteSpace(Current))
                    {
                        continue;
                    }

                    started = true;

                    if (e.MoveNext())
                    {
                        var ch = e.Current;

                        if (Current.Equals(ch, ignoreCase: ignoreCase))
                        {
                            index++;
                        }
                        else
                        {
                            Store();
                            result = false;
                            break;
                        }
                    }
                    else
                    {
                        Store();

                        if (IsNewTokenStarting(Current))
                        {
                            result = false;
                        }

                        break;
                    }
                }

                if (result)
                {
                    result = index == value.Length;
                }
            }
            else
            {
                throw new System.Exception($"'{value}' is not a word");
            }

            return result;
        }
        public string ReadUntil(char ch)
        {
            var result = new CharBuffer();

            while (Next())
            {
                if (Current == ch)
                {
                    break;
                }

                result.Append(ch);
            }

            return result.ToString();
        }
        public string ReadAny(string[] values, bool ignoreCase, out bool succeeded)
        {
            var result = "";
            var ok = true;
            var items = new List<ExpectItem>();

            succeeded = false;

            if (values != null && values.Length > 0)
            {
                var started = false;

                for (var i = 0; i < values.Length; i++)
                {
                    if (!string.IsNullOrEmpty(values[i]) && Regex.IsMatch(values[i], WordPattern))
                    {
                        items.Add(new ExpectItem { Value = values[i] });
                    }
                }

                if (items.Count > 0)
                {
                    while (Next())
                    {
                        if (!started && char.IsWhiteSpace(Current))
                        {
                            continue;
                        }

                        started = true;

                        var atLeastOne = false;

                        for (var i = 0; i < items.Count; i++)
                        {
                            var item = items[i];

                            if (item.Index >= 0)
                            {
                                if (item.Index < item.Value.Length && Current.Equals(item.Value[item.Index], ignoreCase))
                                {
                                    atLeastOne = true;
                                    item.ReadValue += Current;
                                    item.Index++;
                                }
                                else
                                {
                                    item.Index = -1;
                                }
                            }
                        }

                        if (!atLeastOne)
                        {
                            Store();

                            if (IsNewTokenStarting(Current))
                            {
                                ok = false;
                            }

                            break;
                        }
                    }
                }
                else
                {
                    throw new System.Exception($"none of the given values is a word");
                }
            }
            else
            {
                throw new System.Exception($"no values given");
            }

            if (ok)
            {
                foreach (var item in items)
                {
                    if (string.Compare(item.Value, item.ReadValue, ignoreCase) == 0)
                    {
                        ok = true;
                        result = item.ReadValue;
                        break;
                    }
                }
            }

            succeeded = ok;

            return result;
        }
        public string ReadPattern(string pattern, out bool succeeded)
        {
            var result = "";

            succeeded = true;

            if (!string.IsNullOrEmpty(pattern))
            {
                var started = false;

                while (Next())
                {
                    if (!started && char.IsWhiteSpace(Current))
                    {
                        continue;
                    }

                    result += Current;

                    if (Regex.IsMatch(result, pattern))
                    {
                        started = true;
                    }
                    else
                    {
                        Store();

                        if (IsNewTokenStarting(Current))  // this is an error
                        {
                            started = false;
                        }

                        break;
                    }
                }

                succeeded = started;
            }

            return result;
        }
        public bool Next()
        {
            var result = false;

            currentChar = default;

            if (lastChar.HasValue)
            {
                currentChar = lastChar.Value;
                lastChar = null;

                result = true;
            }
            else
            {
                if (source.Length > 0 && position < source.Length)
                {
                    position++;

                    if (position < source.Length)
                    {
                        currentChar = source[position];

                        if (currentChar == '\n')
                        {
                            row++;
                            col = 0;
                        }
                        else
                        {
                            col++;
                        }

                        result = true;
                    }
                    else
                    {
                        col++;
                    }
                }
            }

            return result;
        }
        public void Reset()
        {
            position = -1;
            col = 0;
            row = 1;
            currentChar = default;

            if (source == null)
            {
                source = "";
            }
        }
        public void Store()
        {
            if (position >= 0 && position < source.Length)
            {
                lastChar = currentChar;
            }
        }
        public bool CanRead(string value, bool ignoreCase, bool exact = true)
        {
            var result = true;

            if (!string.IsNullOrEmpty(value))
            {
                StoreState();

                var e = value.GetEnumerator();
                var i = 0;

                while (Next())
                {
                    if (e.MoveNext())
                    {
                        var ch = e.Current;

                        if (!Current.Equals(ch, ignoreCase))
                        {
                            result = false;
                            break;
                        }

                        i++;
                    }
                    else
                    {
                        Store();
                        break;
                    }
                }

                result = i == value.Length;

                if (result && exact)
                {
                    if (Next())
                    {
                        if (IsNewTokenStarting(Current))
                        {
                            result = false;
                        }
                    }
                }

                RestoreState();
            }

            return result;
        }
        public bool HasEndedWith(string value, bool ignoreCase)
        {
            var result = true;

            if (!string.IsNullOrEmpty(value))
            {
                if (position - value.Length + 1 < 0)
                {
                    result = false;
                }
                else
                {
                    for (var i = 0; i < value.Length; i++)
                    {
                        if (!value[i].Equals(source[position - value.Length + i + 1], ignoreCase))
                        {
                            result = false;
                            break;
                        }
                    }
                }
            }

            return result;
        }
        public bool HasEndedWithPattern(string pattern)
        {
            var result = true;

            if (!string.IsNullOrEmpty(pattern))
            {
                var i = position;

                while (i >= 0)
                {
                    if (!Regex.IsMatch(source.Substring(i, position - i + 1), pattern))
                    {
                        result = !IsNewTokenStarting(source[i]);

                        break;
                    }

                    i--;
                }
            }

            return result;
        }
        public string SkipWhitespace()
        {
            var result = "";

            while (true)
            {
                if (Next())
                {
                    if (char.IsWhiteSpace(Current))
                    {
                        result += Current;
                    }
                    else
                    {
                        Store();
                        break;
                    }
                }
                else
                {
                    break;
                }
            }

            return result;
        }
        public IEnumerator<char> GetEnumerator()
        {
            while (Next())
            {
                yield return Current;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        #endregion
    }
}
