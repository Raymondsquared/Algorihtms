using System;
using Algorithms.Strategies.Abstractions;

namespace Algorithms.Strategies.Implementation.ReverseWords
{
    public class ReccursiveReverseWordsStrategy : ReverseWordsStrategy
    {
        public override CONSTANTS.DIFFICULTIES GetDifficulty()
        {
            return CONSTANTS.DIFFICULTIES.RECCURSIVE;
        }

        public override object Resolve(object input)
        {
            var result = input;

            try
            {
                if (input is string)
                {
                    var inputString = input.ToString();
                    result = Reccursive(inputString);                    
                }
            }
            catch (Exception)
            {
                // ignored
            }

            return result;
        }

        private string Reccursive(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }
            return input[input.Length - 1] + Reccursive(input.Substring(0, input.Length-1));
        }
    }
}
