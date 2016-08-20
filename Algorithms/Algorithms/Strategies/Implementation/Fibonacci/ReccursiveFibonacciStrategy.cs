using System;
using System.Collections.Generic;
using Algorithms.Strategies.Abstractions;

namespace Algorithms.Strategies.Implementation.Fibonacci
{
    public class ReccursiveFibonacciStrategy : FibonacciStrategy
    {
        public override CONSTANTS.DIFFICULTIES GetDifficulty()
        {
            return CONSTANTS.DIFFICULTIES.RECCURSIVE;
        }
        public override bool IsPreferred()
        {
            return true;
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
                        resultCollection.Add(ReccursiveFibonacci(x));
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

        private int ReccursiveFibonacci(int input)
        {
            if (input == 0)
            {
                return 0;
            }
            if (input <= 2)
            {
                return 1;
            }

            return ReccursiveFibonacci(input - 2) + ReccursiveFibonacci(input - 1);
        }
    }
}
