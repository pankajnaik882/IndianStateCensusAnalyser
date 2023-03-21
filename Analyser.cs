using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IndianStateCensusAnalyserProblem
{

    public class CSVStateCensus
    {
        private readonly string csv_file = "C:\\Users\\USER\\source\\repos\\IndianStateCensusAnalyserProblem\\IndianStateCensusAnalyserProblem\\state_census.csv";

        public CSVStateCensus(string csv_file)
        {
            this.csv_file = csv_file;
        }

        public int GetRecordCount()
        {
            try
            {
                var csv_data = File.ReadAllLines("C:\\Users\\USER\\source\\repos\\IndianStateCensusAnalyserProblem\\IndianStateCensusAnalyserProblem\\state_census.csv").Skip(1);
                return csv_data.Count();
            }
            catch (FileNotFoundException)
            {
                throw new ArgumentException("File not found.");
            }
        }
    }

    public class StateCensusAnalyser
    {
        private readonly string csv_file = "C:\\Users\\USER\\source\\repos\\IndianStateCensusAnalyserProblem\\IndianStateCensusAnalyserProblem\\state_census.csv";

        public StateCensusAnalyser(string csv_file)
        {
            this.csv_file = csv_file;
        }

        public int GetRecordCount()
        {
            var csv_data = new CSVStateCensus("C:\\Users\\USER\\source\\repos\\IndianStateCensusAnalyserProblem\\IndianStateCensusAnalyserProblem\\state_census.csv").GetRecordCount();
            return csv_data;
        }
    }

}
