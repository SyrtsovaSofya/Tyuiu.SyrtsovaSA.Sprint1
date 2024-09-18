using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SyrtsovaSA.Sprint1.Task3.V13.Lib
{
    public class DataService : ISprint1Task3V13
    {
        public double MultiplyOfDigits(double number)
        {
            double firstDigit = (number / 100) % 10;
            double secondDigit = (number / 10) % 10;
            double lastDigit = number % 10;
            return Math.Round(firstDigit * secondDigit * lastDigit, 3);
        }
    }
}
