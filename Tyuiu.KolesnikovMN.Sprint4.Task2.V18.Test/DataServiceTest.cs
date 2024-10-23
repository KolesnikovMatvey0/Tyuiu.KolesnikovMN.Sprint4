using Tyuiu.KolesnikovMN.Sprint4.Task2.V18.Lib;

namespace Tyuiu.KolesnikovMN.Sprint4.Task2.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] numsArray = { 1, 2, 3, 4, 5, 6 };

            int res = ds.Calculate(numsArray);
            int wait = 48;

            Assert.AreEqual(wait, res);
        }
    }
}