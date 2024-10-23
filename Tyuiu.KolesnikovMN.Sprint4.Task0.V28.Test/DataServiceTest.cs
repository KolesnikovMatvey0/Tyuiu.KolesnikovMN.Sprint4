using Tyuiu.KolesnikovMN.Sprint4.Task0.V28.Lib;

namespace Tyuiu.KolesnikovMN.Sprint4.Task0.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultEvenArrEl()
        {
            DataService ds = new DataService();
            int[] array = new int[] { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2 };

            var res = ds.GetMultEvenArrEl(array);
            int wait = 9216;

            Assert.AreEqual(wait, res);
        }
    }
}