namespace Locust.Text
{
    public static class Extensions
    {
        public static bool Equals(this char ch, char value, bool ignoreCase)
        {
            return ch == value || (ignoreCase && char.IsLetter(ch) && char.IsLetter(value) && char.ToLower(ch) == char.ToLower(value));
        }
    }
}
