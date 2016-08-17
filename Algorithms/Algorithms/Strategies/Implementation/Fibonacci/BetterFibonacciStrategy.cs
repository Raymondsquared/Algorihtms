using System;
using System.Collections.Generic;
using Algorithms.Strategies.Abstractions;

namespace Algorithms.Strategies.Implementation.Fibonacci
{
    public class BetterFibonacciStrategy : FibonacciStrategy
    {
        public override CONSTANTS.DIFFICULTIES GetDifficulty()
        {
            return CONSTANTS.DIFFICULTIES.LEVEL_2;
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
                    for (var x = 0; x < inputNumber; x++)
                    {
                        resultCollection.Add(Fibonacci(x));
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

        private int Fibonacci(int input)
        {
            var tempOne = 0;
            var tempTwo = 1;

            for (var x = 0; x < input; x++)
            {
                var temp = tempOne;
                tempOne = tempTwo;
                tempTwo = temp + tempTwo;
            }
            return tempOne;
        }
    }
}
