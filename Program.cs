using IndianStateCensusAnalyserProblem;

namespace IndianStateCensusAnalyserDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
                try
                {
                    var csv_data = File.ReadAllLines("C:\\Users\\USER\\source\\repos\\IndianStateCensusAnalyserProblem\\IndianStateCensusAnalyserProblem\\state_census.csv").Skip(1);
                    Console.WriteLine( csv_data.Count());
                }
                catch (Exception ex)
                {
                    Console.WriteLine( ex.Message);
                }
            

        }
    }
}