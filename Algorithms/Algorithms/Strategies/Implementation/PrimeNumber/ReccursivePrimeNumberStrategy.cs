using System;
using Algorithms.Strategies.Abstractions;

namespace Algorithms.Strategies.Implementation.PrimeNumber
{
    public class ReccursivePrimeNumberStrategy : PrimeNumberStrategy
    {
        public override CONSTANTS.DIFFICULTIES GetDifficulty()
        {
            return CONSTANTS.DIFFICULTIES.RECCURSIVE;
        }

        public override object Resolve(object input)
        {
            var result = true;

            try
            {
                if (input is int)
                {
                    var inputNumber = (int) input;
                    result = ReccursiveIsPrime(inputNumber, 3);
                }
            }
            catch (Exception)
            {
                // ignored
            }

            return result;
        }

        private bool ReccursiveIsPrime(int input, int counter)
        {
            if ((input == 2) || (input == 3)) return true;

            if ((input == 1) ||
                (input % 2 == 0) ||
                (input % 3 == 0) ||
                (input % counter == 0))
            {
                return false;
            }

            if (counter * counter <= input)
            {                
                return ReccursiveIsPrime(input, counter + 2);
            }

            return true;
        }
    }
}
