namespace Algorithms.Abstrations
{
    public interface IAlgorithmResolver : IResolver
    {
        string GetName();
        CONSTANTS.ALGORITHM_TYPE GetAlgorithmType();
        CONSTANTS.DIFFICULTIES GetDifficulty();
        bool IsPreferred();
        string Extra();
    }
}
