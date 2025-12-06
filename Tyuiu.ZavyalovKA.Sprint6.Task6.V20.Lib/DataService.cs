using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ZavyalovKA.Sprint6.Task6.V20.Lib
{
    public class DataService : ISprint6Task6V20
    {
        public string CollectTextFromFile(string path)
        {
            StringBuilder resultBuilder = new StringBuilder();
            using (StreamReader reader = new StreamReader(path, Encoding.UTF8))
            {
                string line;
                bool firstWord = true;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    if (words.Length >= 2)
                    {
                        if (!firstWord)
                        {
                            resultBuilder.Append("\\n");
                        }
                        resultBuilder.Append(words[1]);
                        firstWord = false;
                    }
                }
            }
            return resultBuilder.ToString();
        }
    }
}
