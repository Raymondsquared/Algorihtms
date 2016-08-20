using Algorithms.Abstrations;

namespace Algorithms.Strategies.Abstractions
{
    public abstract class ReverseWordsStrategy : IAlgorithmResolver
    {
        public string GetName()
        {
            return GetType().Name;
        }

        public CONSTANTS.ALGORITHM_TYPE GetAlgorithmType()
        {
            return CONSTANTS.ALGORITHM_TYPE.REVERSE_WORDS;
        }

        public abstract object Resolve(object input);

        public virtual bool IsPreferred()
        {
            return false;
        }

        public abstract CONSTANTS.DIFFICULTIES GetDifficulty();        

        public string Extra()
        {
            return string.Empty;
        }
    }
}
