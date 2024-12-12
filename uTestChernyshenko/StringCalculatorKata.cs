using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uTestChernyshenko
{
    public static class StringCalculatorKata
    {
        public static int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
            {
                return 0;
            }

            string[] numbersArray = numbers.Split(',');

            int result = 0;
            foreach (string number in numbersArray)
            {
                result += int.Parse(number);
            }

            return result;

        }
    }
}
