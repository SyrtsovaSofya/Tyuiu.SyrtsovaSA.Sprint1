using Tyuiu.SyrtsovaSA.Sprint1.Task3.V13.Lib;

namespace Tyuiu.SyrtsovaSA.Sprint1.Task3.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService dataService = new DataService();
            double a = 123;
            var res = dataService.MultiplyOfDigits(a);
            Assert.AreEqual(8.487, res);
        }
    }
}