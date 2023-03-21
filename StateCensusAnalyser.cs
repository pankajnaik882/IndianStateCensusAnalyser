using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnalyserProblem
{
    public class StateCensusAnalyser
    {
        private readonly string csv_file = "C:\\Users\\USER\\source\\repos\\IndianStateCensusAnalyserProblem\\IndianStateCensusAnalyserProblem\\state_census.csv";

        public StateCensusAnalyser(string csv_file)
        {
            this.csv_file = csv_file;
        }

        public int GetRecordCount()
        {
            var csv_data = new CSVStateCensus(csv_file).GetCensusData();
            return csv_data.Count;
        }
    }
}
