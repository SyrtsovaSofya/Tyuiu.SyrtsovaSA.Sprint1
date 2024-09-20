using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SyrtsovaSA.Sprint1.Task6.V5.Lib
{
    public class DataService : ISprint1Task6V5
    {
        public string CheckSymmetricalWords(string value)
        {
            string[] words = value.Split(' ');
            string res = string.Empty;
            foreach (string word in words)
            {
                if (word.SequenceEqual(word.Reverse()))
                    res += word;
            }
            return res;
        }
    }
}
