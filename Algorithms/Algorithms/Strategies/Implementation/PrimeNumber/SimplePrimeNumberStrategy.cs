using System;
using System.Collections.Generic;
using Algorithms.Strategies.Abstractions;

namespace Algorithms.Strategies.Implementation.PrimeNumber
{
    public class SimplePrimeNumberStrategy : PrimeNumberStrategy
    {
        public override CONSTANTS.DIFFICULTIES GetDifficulty()
        {
            return CONSTANTS.DIFFICULTIES.LEVEL_1;
        }

        public override object Resolve(object input)
        {
            var result = true;

            try
            {
                if (input is int)
                {
                    var inputNumber = (int) input;                

                    if (inputNumber == 1) return false;
                    if ((inputNumber == 2) || (inputNumber == 3)) return true;

                    for (var x = 2; x < inputNumber; x++)
                    {
                        if (inputNumber % x == 0)
                        {
                            result = false;
                            break;
                        }
                    }
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
