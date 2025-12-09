using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.RochevYA.Sprint6.Task6.V10.Lib
{
    public class DataService : ISprint6Task6V10
    {
        public string CollectTextFromFile(string path)
        {
            
            string[] lines = File.ReadAllText(path).Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            List<string> foundWords = new List<string>();

            foreach (string line in lines)
            {
                string[] words = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string word in words)
                {
                    if (word.IndexOf('w', StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        foundWords.Add(word);
                    }
                }
            }

            return string.Join(" ", foundWords);
        }
    }
}
