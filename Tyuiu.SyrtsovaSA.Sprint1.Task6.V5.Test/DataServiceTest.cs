using Tyuiu.SyrtsovaSA.Sprint1.Task6.V5.Lib;

namespace Tyuiu.SyrtsovaSA.Sprint1.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService dataService = new DataService();
            string str = "����� ����� �����";
            string wait = "����������";
            var res = dataService.CheckSymmetricalWords(str);
            Assert.AreEqual(wait, res);
        }
    }
}