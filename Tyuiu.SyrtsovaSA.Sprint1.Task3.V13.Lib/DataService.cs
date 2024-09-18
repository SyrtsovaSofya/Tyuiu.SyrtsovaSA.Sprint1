using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SyrtsovaSA.Sprint1.Task3.V13.Lib
{
    public class DataService : ISprint1Task3V13
    {
        public double MultiplyOfDigits(double number)
        {
            int intNumber = Convert.ToInt32(number);
            double firstDigit = (intNumber / 100) % 10;
            double secondDigit = (intNumber / 10) % 10;
            double lastDigit = intNumber % 10;
            return Math.Round(firstDigit * secondDigit * lastDigit, 3);
        }
    }
}
