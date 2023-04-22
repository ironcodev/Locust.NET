using System;
using System.Linq;
using System.Dynamic;
using System.Collections.Generic;

namespace Locust.Base
{
    public class DynamicDTO : DynamicObject, IDictionary<string, object>
    {
        Dictionary<string, object> props;
        public DynamicDTO(IEqualityComparer<string> comparer = null)
        {
            if (comparer == null)
            {
                comparer = StringComparer.Ordinal;
            }

            props = new Dictionary<string, object>(comparer);
        }
        public int Count
        {
            get
            {
                return props.Count;
            }
        }
        public ICollection<string> Keys
        {
            get { return props.Keys; }
        }
        public ICollection<object> Values
        {
            get { return props.Values; }
        }
        public bool IsReadOnly => false;
        public virtual void SetProperty(string name, object value)
        {
            if (props.ContainsKey(name))
            {
                props[name] = value;
            }
            else
            {
                props.Add(name, value);
            }
        }
        public virtual object GetProperty(string name)
        {
            if (props.ContainsKey(name))
            {
                return props[name];
            }
            else
            {
                return null;
            }
        }
        public virtual bool RemoveProperty(string name)
        {
            return props.Remove(name);
        }
        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            string name = binder.Name;

            return props.TryGetValue(name, out result);
        }
        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            SetProperty(binder.Name, value);

            return true;
        }
        public bool ContainsKey(string key)
        {
            return props.ContainsKey(key);
        }
        public void Add(string key, object value)
        {
            SetProperty(key, value);
        }
        public bool Remove(string key)
        {
            return props.Remove(key);
        }
        public bool TryGetValue(string key, out object value)
        {
            return props.TryGetValue(key, out value);
        }
        public void Add(KeyValuePair<string, object> item)
        {
            SetProperty(item.Key, item.Value);
        }
        public void Clear()
        {
            props.Clear();
        }
        public bool Contains(KeyValuePair<string, object> item)
        {
            var _item = props.FirstOrDefault(x =>
            {
                var result = string.Compare(x.Key, item.Key, StringComparison.OrdinalIgnoreCase) == 0;

                if (result)
                {
                    IComparable x1 = x.Value as IComparable;

                    if (x1 != null)
                    {
                        result &= x1.CompareTo(item.Value) == 0;
                    }
                    else
                    {
                        IComparable<object> x2 = x.Value as IComparable<object>;

                        if (x2 != null)
                        {
                            result &= x2.CompareTo(item.Value) == 0;
                        }
                        else
                        {
                            result = false;
                        }
                    }
                }

                return result;
            });

            return !string.IsNullOrEmpty(_item.Key);
        }
        public void CopyTo(KeyValuePair<string, object>[] array, int arrayIndex)
        {
            if (array != null && array.Length > 0)
            {
                if (arrayIndex < 0 || arrayIndex >= array.Length)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    var i = arrayIndex;

                    foreach (var prop in props)
                    {
                        if (i++ < array.Length)
                        {
                            array[i++] = prop;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
        }
        public bool Remove(KeyValuePair<string, object> item)
        {
            if (!props.ContainsKey(item.Key))
                return false;

            var x = props[item.Key];

            if ((object)x == null && (object)item.Value == null)
                return props.Remove(item.Key);

            if (x.Equals(item.Value))
                return props.Remove(item.Key);
            else
                return false;
        }
        public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
        {
            return props.GetEnumerator();
        }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return props.GetEnumerator();
        }
        public object this[string name]
        {
            get
            {
                return GetProperty(name);
            }
            set
            {
                SetProperty(name, value);
            }
        }
        public object this[int index]
        {
            get
            {
                var keys = Keys;
                var result = (object)null;

                if (index >= 0 && index < keys.Count)
                {
                    var i = 0;

                    foreach (var key in keys)
                    {
                        if (i++ == index)
                        {
                            result = props[key];
                            break;
                        }
                    }
                }
                else
                {
                    throw new DynamicDTOPropertyIndexOutOfRangeException(index);
                }

                return result;
            }
            set
            {
                var keys = Keys;

                if (index >= 0 && index < keys.Count)
                {
                    var i = 0;

                    foreach (var key in keys)
                    {
                        if (i++ == index)
                        {
                            SetProperty(key, value);

                            break;
                        }
                    }
                }
                else
                {
                    throw new DynamicDTOPropertyIndexOutOfRangeException(index);
                }
            }
        }
    }
}