using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnalyserProblem
{
    public class StateCensusException : Exception
    {
        public StateCensusException(string message) : base(message){ }
    }
}
