using System;
using System.Collections.Generic;
using Algorithms.Strategies.Abstractions;

namespace Algorithms.Strategies.Implementation.Fibonacci
{
    public class SimpleFibonacciStrategy : FibonacciStrategy
    {
        public override CONSTANTS.DIFFICULTIES GetDifficulty()
        {
            return CONSTANTS.DIFFICULTIES.LEVEL_1;
        }

        public override object Resolve(object input)
        {
            var result = string.Empty;
            var resultCollection = new List<int>();

            try
            {
                if (input is int)
                {
                    var inputNumber = (int) input;

                    if (inputNumber > 0)
                    {
                        for (var x = 0; x < inputNumber; x++)
                        {
                            if (x == 0)
                            {
                                resultCollection.Add(0);
                            }
                            else if (x < 2)
                            {
                                resultCollection.Add(1);
                            }
                            else
                            {
                                var pastTwo = resultCollection[x - 2];
                                var pastOne = resultCollection[x - 1];

                                resultCollection.Add(pastTwo + pastOne);
                            }                            
                        }
                    }
                }

                result = string.Join(", ", resultCollection);
            }
            catch (Exception)
            {
                // ignored
            }

            return result;
        }
    }
}
