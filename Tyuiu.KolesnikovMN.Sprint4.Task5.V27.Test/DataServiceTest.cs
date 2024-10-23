using Tyuiu.KolesnikovMN.Sprint4.Task5.V27.Lib;

namespace Tyuiu.KolesnikovMN.Sprint4.Task5.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5] { { 4, -5, 5, 6, 4 }, { 7, -8, 4, -7, 5 },
                { 5, 6, -5, 8, -5 }, { 7, 5, 8, -7, 8 }, { -4, -7, 7, -8, 8 } };

            int res = ds.Calculate(matrix);
            int waitCount = 9;

            Assert.AreEqual(res, waitCount);
        }
    }
}