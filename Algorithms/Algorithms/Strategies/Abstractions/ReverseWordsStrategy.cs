using Algorithms.Abstrations;

namespace Algorithms.Strategies.Abstractions
{
    public abstract class ReverseWordsStrategy : IAlgorithmResolver
    {
        public CONSTANTS.ALGORITHM_TYPE GetAlgorithmType()
        {
            return CONSTANTS.ALGORITHM_TYPE.REVERSE_WORDS;
        }

        public virtual string GetName()
        {
            throw new System.NotImplementedException();
        }

        public virtual object Resolve(object input)
        {
            throw new System.NotImplementedException();
        }

        public virtual CONSTANTS.DIFFICULTIES GetDifficulty()
        {
            throw new System.NotImplementedException();
        }
    }
}
