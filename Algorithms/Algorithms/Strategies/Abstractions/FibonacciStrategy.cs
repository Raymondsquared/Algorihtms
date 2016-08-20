using Algorithms.Abstrations;

namespace Algorithms.Strategies.Abstractions
{
    public abstract class FibonacciStrategy : IAlgorithmResolver
    {
        public string GetName()
        {
            return GetType().Name;
        }        

        public CONSTANTS.ALGORITHM_TYPE GetAlgorithmType()
        {
            return CONSTANTS.ALGORITHM_TYPE.FIBONACCI;
        }        

        public abstract object Resolve(object input);

        public abstract CONSTANTS.DIFFICULTIES GetDifficulty();
        public virtual bool IsPreferred()
        {
            return false;
        }

        public string Extra()
        {
            return string.Empty;
        }
    }
}
