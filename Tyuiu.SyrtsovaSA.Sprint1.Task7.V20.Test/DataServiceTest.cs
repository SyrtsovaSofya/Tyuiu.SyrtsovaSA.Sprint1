using Tyuiu.SyrtsovaSA.Sprint1.Task7.V20.Lib;

namespace Tyuiu.SyrtsovaSA.Sprint1.Task7.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 0;
            double wait = 0.764;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}