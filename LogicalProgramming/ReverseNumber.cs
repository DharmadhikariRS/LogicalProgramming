using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class ReverseNumber
    {
        public void ReverseNum()
        {
            Console.WriteLine("Enter the number");
            int Num = Convert.ToInt32(Console.ReadLine());
            int ReverseNum = 0;
            int Remainder = 0;
            while (Num > 0)
            {
                Remainder = Num % 10;
                ReverseNum = ReverseNum * 10 + Remainder;
                Num /= 10;
            }
            Console.WriteLine("Reverse number = " + ReverseNum);
        }

    }
}
