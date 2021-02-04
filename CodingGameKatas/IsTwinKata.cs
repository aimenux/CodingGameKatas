using System.Linq;

namespace CodingGameKatas
{
    public static class IsTwinKata
    {
        public static bool IsTwin(string str1, string str2)
        {
            if (str1.Length != str2.Length)
            {
                return false;
            }

            var newStr1 = string.Concat(str1.ToLower().OrderBy(c => c));
            var newStr2 = string.Concat(str2.ToLower().OrderBy(c => c));

            return string.Equals(newStr1, newStr2);
        }
    }
}