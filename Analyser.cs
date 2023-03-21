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
        private readonly string csv_file = "C:\\Users\\USER\\source\\repos\\IndianStateCensusAnalyserProblem\\IndianStateCensusAnalyserProblem\\Invalidstate_census.csv";

        public CSVStateCensus(string csv_file)
        {
            this.csv_file = csv_file;
        }
        public List<StateCensusData> GetCensusData()
        {
            try
            {
                var csv_data = File.ReadAllLines(csv_file).Skip(1);
                var census_data = new List<StateCensusData>();

                foreach (var line in csv_data)
                {
                    var fields = line.Split(',');
                    if (fields.Length != 4)
                    {
                        throw new InvalidCSVFormatException("Invalid CSV file format.");
                    }

                    int.TryParse(fields[0], out int population);
                    int.TryParse(fields[1], out int area);
                    int.TryParse(fields[2], out int density);

                    var data = new StateCensusData
                    {
                        StateName = fields[3],
                        Population = population,
                        AreaInSquareKm = area,
                        DensityPerSquareKm = density
                    };

                    if (population == 0 || area == 0 || density == 0)
                    {
                        throw new InvalidDataTypeException("Invalid data type.");
                    }

                    census_data.Add(data);
                }

                return census_data;
            }
            catch (FileNotFoundException)
            {
                throw new ArgumentException("File not found.");
            }
            catch (InvalidCSVFormatException)
            {
                throw;
            }
            catch (Exception)
            {
                throw new InvalidDataTypeException("Invalid data type.");
            }
        }
    }


}


