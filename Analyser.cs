using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IndianStateCensusAnalyserProblem
{
    public class CSVStateCensus : IEnumerable<string[]>
    {
        private readonly string _filePath;

        public CSVStateCensus(string filePath)
        {
            _filePath = filePath;
        }

        public IEnumerator<string[]> GetEnumerator()
        {
            using (var reader = new StreamReader("C:\\Users\\USER\\source\\repos\\IndianStateCensusAnalyserProblem\\IndianStateCensusAnalyserProblem\\state_census.csv"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    yield return line.Split(',');
                }
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class StateCensusAnalyser
    {
        private readonly string _filePath;

        public StateCensusAnalyser(string filePath)
        {
            _filePath = filePath;
        }

        public int GetNumberOfRows()
        {
            var rows = new CSVStateCensus(_filePath);
            int count = 0;

            foreach (var row in rows)
            {
                count++;
            }

            return count;
        }
    }
}
