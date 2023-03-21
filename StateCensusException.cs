using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnalyserProblem
{
    public class InvalidCSVFormatException : Exception
    {
        public InvalidCSVFormatException(string message) : base(message)
        {
        }
    }

}
