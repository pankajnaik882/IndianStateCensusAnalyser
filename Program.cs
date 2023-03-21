using IndianStateCensusAnalyserProblem;
using static System.Net.Mime.MediaTypeNames;

namespace IndianStateCensusAnalyserDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {

           // Test case file with correct data but incorrect types
            var file = "C:\\Users\\USER\\source\\repos\\IndianStateCensusAnalyserProblem\\IndianStateCensusAnalyserProblem\\Invalidstate_census.csv";
            try
            {
                var analyser = new StateCensusAnalyser(file);
                var recordCount = analyser.GetRecordCount();
                Console.WriteLine($"{file}: Number of records: {recordCount}");
            }
            catch (InvalidDataTypeException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }


        }
    }
}