using System.Collections.Generic;
using System.Linq;
using Algorithms.Abstrations;

namespace Algorithms.Models.ProblemSolutions
{
    public class ProblemResolvers
    {
        public string Algorithm { get; set; }
        public object Problem { get; set; }

        private IList<IAlgorithmResolver> _algorithmResolvers;

        public IList<IAlgorithmResolver> AlgorithmResolvers
        {
            get { return _algorithmResolvers; }
            set
            {
                _algorithmResolvers = value;

                var firstOrDefault = value.FirstOrDefault();
                if (firstOrDefault != null)
                {
                    Algorithm = firstOrDefault.GetAlgorithmType().ToString();
                }
            }
        }
    }
}

