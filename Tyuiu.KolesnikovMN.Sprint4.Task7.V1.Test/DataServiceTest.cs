using Tyuiu.KolesnikovMN.Sprint4.Task7.V1.Lib;

namespace Tyuiu.KolesnikovMN.Sprint4.Task7.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            string str = "135792468";

            int resCount = ds.Calculate(3, 3, str);
            int waitCount = 4;

            Assert.AreEqual(resCount, waitCount);
        }
    }
}