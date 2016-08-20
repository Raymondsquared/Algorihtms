using System.Collections.Generic;
using Algorithms.Abstrations;

namespace Algorithms.Strategies.Abstractions
{
    public abstract class PrimeNumberStrategy : IAlgorithmResolver
    {
        public string GetName()
        {
            return GetType().Name;
        }

        public CONSTANTS.ALGORITHM_TYPE GetAlgorithmType()
        {
            return CONSTANTS.ALGORITHM_TYPE.PRIME_NUMBER;
        }        

        public abstract object Resolve(object input);

        public abstract CONSTANTS.DIFFICULTIES GetDifficulty();

        public virtual bool IsPreferred()
        {
            return false;
        }

        public string Extra()
        {
            var result = $"the {CONSTANTS.NUMBERS.PRIME_NUMBER_PROBLEM}th prime number is = ";
            var resultNumber = 0;
            var counter = 0;

            var numbers = new List<int>();

            for (var x = 0; counter < CONSTANTS.NUMBERS.PRIME_NUMBER_PROBLEM; x++)
            {
                var isPrime = Resolve(x);
                if (isPrime is bool)
                {
                    if ((bool) isPrime)
                    {
                        numbers.Add(x);
                        counter ++;
                        resultNumber = x;
                    }
                }                
            }

            result += resultNumber;

            return result;
        }
    }
}
