using System.Collections.Generic;
using System.Linq;

namespace DataSecurity1.LitteralStatistic
{
    public static class Analyzer
    {
        public static Dictionary<char, int> CountLettersIncomes(string text)
        {
            var result = new Dictionary<char, int>();
            text = text.Replace("\n", string.Empty);

            foreach (char letter in text)
            {
                if (!result.ContainsKey(letter))
                {
                    result.Add(letter, text.Count(l => l == letter));
                }
            }

            return result;
        }
    }
}