using Tyuiu.SyrtsovaSA.Sprint1.Task4.V30.Lib;

namespace Tyuiu.SyrtsovaSA.Sprint1.Task4.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService dataService = new DataService();
            double x = 1;
            double y = 1;
            double wait = 0.736;
            var res = dataService.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}