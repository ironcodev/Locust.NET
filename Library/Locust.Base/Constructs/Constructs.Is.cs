using System.Linq;

namespace Locust
{
    public static partial class Constructs
    {
        public static bool IsSomeString(string s, bool rejectFullWhitespaceStrings = false)
        {
            if (!string.IsNullOrEmpty(s))
            {
                return !rejectFullWhitespaceStrings || s.ToCharArray().Any(ch => !char.IsWhiteSpace(ch));
            }

            return false;
        }
    }
}
