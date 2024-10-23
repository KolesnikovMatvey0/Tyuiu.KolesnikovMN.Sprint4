using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KolesnikovMN.Sprint4.Task6.V15.Lib
{
    public class DataService : ISprint4Task6V15
    {
        public int Calculate(string[] array)
        {
            int res = array.Count(x => x.Length < 7);
            return res;
        }
    }
}
