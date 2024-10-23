using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KolesnikovMN.Sprint4.Task7.V1.Lib
{
    public class DataService : ISprint4Task7V1
    {
        public int Calculate(int n, int m, string value)
        {
            int count = 0;
            int[,] matrix = new int[n, m];
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i,j] = int.Parse(value.Substring(i * m + j, 1));
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i,j] % 2 == 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
