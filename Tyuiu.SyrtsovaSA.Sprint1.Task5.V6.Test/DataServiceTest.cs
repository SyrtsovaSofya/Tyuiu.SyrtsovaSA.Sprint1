using Tyuiu.SyrtsovaSA.Sprint1.Task5.V6.Lib;

namespace Tyuiu.SyrtsovaSA.Sprint1.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService dataService = new DataService();
            int day = 8;
            double wait = 1;
            var res = dataService.Calculate(day);
            Assert.AreEqual(wait, res);
        }
    }
}