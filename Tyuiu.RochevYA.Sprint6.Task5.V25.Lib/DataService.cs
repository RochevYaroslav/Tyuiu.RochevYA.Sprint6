using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint6;


namespace Tyuiu.RochevYA.Sprint6.Task5.V25.Lib
{
    public class DataService : ISprint6Task5V25
    {
        public double[] LoadFromDataFile(string path)
        {
            string[] allLines = File.ReadAllLines(path);

            List<double> resultList = new List<double>();

            foreach (string line in allLines)
            {
                string cleanLine = line.Trim();

                if (string.IsNullOrEmpty(cleanLine))
                    continue;

                string numberString = cleanLine.Replace(",", ".");

                if (double.TryParse(numberString,
                    NumberStyles.Float,
                    CultureInfo.InvariantCulture,
                    out double number))
                {
                    if (Math.Abs(number) > 0.0000001)
                    {
                        double roundedNumber = Math.Round(number, 3);

                        resultList.Add(roundedNumber);
                    }
                }
            }

            return resultList.ToArray();
        }
    }
}
