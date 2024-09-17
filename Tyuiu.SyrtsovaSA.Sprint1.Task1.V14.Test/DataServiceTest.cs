using Tyuiu.SyrtsovaSA.Sprint1.Task1.V14.Lib;

namespace Tyuiu.SyrtsovaSA.Sprint1.Task1.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService dataService = new DataService();
            double x = 3.0;
            double y = 2.0;
            double z = 1.0;
            var res = dataService.Calculate(x, y, z);
            Assert.AreEqual(7, res);
        }
    }
}