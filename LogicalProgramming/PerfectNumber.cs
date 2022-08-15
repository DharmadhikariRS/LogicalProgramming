using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class PerfectNumber
    {
        public bool Factor(int Number, int Factor)
        {
            if (Number % Factor == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void PerfectNumbers()
        {
            int check = 0;
            Console.WriteLine("Enter number");
            int Num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= Num / 2; i++)
            {
                if (Factor(Num, i))
                {
                    check += i;
                }
            }

            if (check == Num)
            {
                Console.WriteLine("{0} is Perfect Number", Num);
            }
            else
            {
                Console.WriteLine("{0} is Not Perfect Number", Num);
            }

        }
    }
}
