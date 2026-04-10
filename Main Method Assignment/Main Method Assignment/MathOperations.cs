using System;

namespace MainMethodAssignment
{
    public class MathOperations
    {
        public int DoMath(int number)
        {
            return number + 10;
        }

        public int DoMath(decimal number)
        {
            return (int)(number * 2);
        }

        public int DoMath(string number)
        {
            int convertedNumber = Convert.ToInt32(number);
            return convertedNumber - 5;
        }
    }
}