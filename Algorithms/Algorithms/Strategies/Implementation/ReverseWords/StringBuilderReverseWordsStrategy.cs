using System;
using System.Text;
using Algorithms.Strategies.Abstractions;

namespace Algorithms.Strategies.Implementation.ReverseWords
{
    public class StringBuilderReverseWordsStrategy : ReverseWordsStrategy
    {
        public override CONSTANTS.DIFFICULTIES GetDifficulty()
        {
            return CONSTANTS.DIFFICULTIES.LEVEL_2;
        }

        public override object Resolve(object input)
        {
            var result = input;

            try
            {
                if (input is string)
                {
                    var inputString = input.ToString();

                    StringBuilder sb = new StringBuilder();                    

                    for (var x = inputString.Length-1; x >= 0; x--)
                    {
                        sb.Append(inputString[x]);
                    }
                    result = sb;
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
