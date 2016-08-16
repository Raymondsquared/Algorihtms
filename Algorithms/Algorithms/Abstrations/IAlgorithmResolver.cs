namespace Algorithms.Abstrations
{
    public interface IAlgorithmResolver : IResolver
    {
        CONSTANTS.ALGORITHM_TYPE GetAlgorithmType();
        string GetName();

        CONSTANTS.DIFFICULTIES GetDifficulty();
    }
}
