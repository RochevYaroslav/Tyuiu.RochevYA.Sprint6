using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.RochevYA.Sprint6.Task5.V25.Lib
{
    public class DataService : ISprint6Task5V25
    {
        public double[] LoadFromDataFile(string path)
        {
            double[] values = path.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries)
                     .Select(s => double.Parse(s.Trim()))
                     .Where(x => x != 0) 
                     .Select(x => Math.Round(x, 3)) 
                     .ToArray();

            return values;
        }
    }
}
