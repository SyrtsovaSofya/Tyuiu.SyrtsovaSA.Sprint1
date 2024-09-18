using Tyuiu.SyrtsovaSA.Sprint1.Task2.V15.Lib;

namespace Tyuiu.SyrtsovaSA.Sprint1.Task2.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService dataService = new DataService();
            int a = 3;
            var res = dataService.CalculateCubeVolume(a);
            Assert.AreEqual(27, res);
        }
    }
}