using tyuiu.cources.programming.interfaces.Sprint6;
using static System.Net.Mime.MediaTypeNames;
namespace Tyuiu.RochevYA.Sprint6.Task7.V28.Lib
{
    public class DataService : ISprint6Task7V28
    {
        public int[,] GetMatrix(string path)
        {
            string text = File.ReadAllText(path);

            text = text.Trim('\r', '\n', ' ', '\t');

            string[] lines = text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int cols = lines[0].Split(';').Length;

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] numbers = lines[i].Split(';');

                for (int j = 0; j < cols; j++)
                {
                    if ((i==6) && (int.Parse(numbers[j].Trim()) != 13))
                    {
                        matrix[i, j] = 0;
                    }
                    else
                    {
                        matrix[i, j] = int.Parse(numbers[j].Trim());
                    }
                }
            }

            return matrix;

        }
    }
}
