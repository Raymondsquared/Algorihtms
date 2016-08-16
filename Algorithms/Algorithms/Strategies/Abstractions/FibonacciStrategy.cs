using Algorithms.Abstrations;

namespace Algorithms.Strategies.Abstractions
{
    public abstract class FibonacciStrategy : IAlgorithmResolver
    {
        public CONSTANTS.ALGORITHM_TYPE GetAlgorithmType()
        {
            return CONSTANTS.ALGORITHM_TYPE.FIBONACCI;
        }

        public string GetName()
        {
            return GetType().Name;
        }

        public abstract object Resolve(object input);

        public abstract CONSTANTS.DIFFICULTIES GetDifficulty();
    }
}
