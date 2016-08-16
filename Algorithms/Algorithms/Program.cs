using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Algorithms.Abstrations;
using Algorithms.Models.ProblemSolutions;
using Algorithms.Strategies.Implementation.ReverseWords;

namespace Algorithms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IList<IAlgorithmResolver> reverseWordsResolvers = new List<IAlgorithmResolver>()
            {
                new SimpleReverseWordsStrategy(),
                new StringBuilderReverseWordsStrategy(),
                new ReccursiveReverseWordsStrategy()
            };

            IList<ProblemResolvers> problemResolversCollection = new List<ProblemResolvers>()
            {
                new ProblemResolvers()
                {
                    Problem  = CONSTANTS.TEXT.REVERSE_WORDS_PROBLEM,
                    AlgorithmResolvers = reverseWordsResolvers
                }
            };            
            
            foreach (var problemResolvers in problemResolversCollection)
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


                Console.WriteLine($"---------------------------------------------------------------------");
            }
        }
    }
}
