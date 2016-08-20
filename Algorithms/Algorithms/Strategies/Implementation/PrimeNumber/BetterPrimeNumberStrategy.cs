using System;
using System.Collections.Generic;
using Algorithms.Strategies.Abstractions;

namespace Algorithms.Strategies.Implementation.PrimeNumber
{
    public class BetterPrimeNumberStrategy : PrimeNumberStrategy
    {
        public override CONSTANTS.DIFFICULTIES GetDifficulty()
        {
            return CONSTANTS.DIFFICULTIES.LEVEL_2;
        }

        public override object Resolve(object input)
        {
            var result = true;

            try
            {
                if (input is int)
                {
                    var inputNumber = (int) input;

                    if ((inputNumber == 2) || (inputNumber == 3)) return true;
                

                    if ((inputNumber == 1) ||
                        (inputNumber % 2 == 0) ||
                        (inputNumber % 3 == 0))
                    {
                        return false;
                    }

                    for (var x = 3; x < inputNumber; x += 2)
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
