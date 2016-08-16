using System;
using Algorithms.Strategies.Abstractions;

namespace Algorithms.Strategies.Implementation.ReverseWords
{
    public class SimpleReverseWordsStrategy : ReverseWordsStrategy
    {
        public override string GetName()
        {
            return "Simple";
        }

        public override CONSTANTS.DIFFICULTIES GetDifficulty()
        {
            return CONSTANTS.DIFFICULTIES.LEVEL_1;
        }

        public override object Resolve(object input)
        {
            var result = input;

            try
            {
                if (input is string)
                {
                    var inputString = input.ToString();

                    var resultString = string.Empty;

                    for (var x = inputString.Length-1; x >= 0; x--)
                    {
                        resultString += inputString[x];
                    }
                    result = resultString;
                }
            }
            catch (Exception)
            {
                // ignored
            }

            return result;
        }
    }
}
