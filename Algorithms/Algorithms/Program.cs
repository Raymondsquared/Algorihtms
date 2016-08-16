using System;
using System.Collections.Generic;
using Algorithms.Abstrations;
using Algorithms.Models.ProblemSolutions;
using Algorithms.Strategies.Implementation.Fibonacci;
using Algorithms.Strategies.Implementation.ReverseWords;

namespace Algorithms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Run(GetProblemResolversCollection());
        }

        public static IList<ProblemResolvers> GetProblemResolversCollection()
        {
            IList<IAlgorithmResolver> reverseWordsResolvers = new List<IAlgorithmResolver>()
            {
                new SimpleReverseWordsStrategy(),
                new StringBuilderReverseWordsStrategy(),
                new ReccursiveReverseWordsStrategy()
            };

            IList<IAlgorithmResolver> fibonacciResolvers = new List<IAlgorithmResolver>()
            {
                new SimpleFibonacciStrategy()
            };

            return new List<ProblemResolvers>()
            {
                new ProblemResolvers()
                {
                    Problem  = CONSTANTS.TEXTS.REVERSE_WORDS_PROBLEM,
                    AlgorithmResolvers = reverseWordsResolvers
                },
                new ProblemResolvers()
                {
                    Problem  = CONSTANTS.NUMBERS.FIBONACCI_PROBLEM,
                    AlgorithmResolvers = fibonacciResolvers
                }
            };
        }

        public static void Run(IList<ProblemResolvers> inputCollection)
        {
            foreach (var problemResolvers in inputCollection)
            {
                Console.WriteLine($"Algorithm Type : {problemResolvers.Algorithm}");
                Console.WriteLine($"Problem : {problemResolvers.Problem}");

                foreach (var algorithmResolver in problemResolvers.AlgorithmResolvers)
                {
                    Console.WriteLine($"{Environment.NewLine}");
                    Console.WriteLine($"Algorithm Name : {algorithmResolver.GetName()}");
                    Console.WriteLine($"Difficulty : {algorithmResolver.GetDifficulty()}");
                    Console.WriteLine($"Solution : {algorithmResolver.Resolve(problemResolvers.Problem)}");
                }

                Console.WriteLine($"{Environment.NewLine}");
                Console.WriteLine($"---------------------------------------------------------------------");
                Console.WriteLine($"{Environment.NewLine}");
            }
        }
    }
}
