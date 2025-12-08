using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ZavyalovKA.Sprint6.Task7.V1.Lib
{
    public class DataService : ISprint6Task7V1
    {
        public int[,] GetMatrix(string path)
        {
            string[] lines = File.ReadAllLines(path);
            int rows = lines.Length;
            int columns = lines[0].Split(';', StringSplitOptions.RemoveEmptyEntries).Length;
            int[,] matrix = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                string[] numbers = lines[i].Split(';', StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = int.Parse(numbers[j]);
                }
            }
            int targetColumn = 1; 

            for (int r = 0; r < rows; r++)
            {
                if (matrix[r, targetColumn] < 0)
                {
                    matrix[r, targetColumn] = 1;
                }
            }
            return matrix;
        }
    }
}

