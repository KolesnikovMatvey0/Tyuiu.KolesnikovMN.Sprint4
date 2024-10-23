using Tyuiu.KolesnikovMN.Sprint4.Task1.V16.Lib;

namespace Tyuiu.KolesnikovMN.Sprint4.Task1.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] valueArray = { 4, 3, 7, 3, 7, 4, 3, 3, 4, 4, 8, 3, 4 };

            var res = ds.Calculate(valueArray);
            int wait = 11907;

            Assert.AreEqual(wait, res);
        }
    }
}