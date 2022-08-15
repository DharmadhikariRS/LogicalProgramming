using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class PrimeNumbers
    {
        public void PrimeNumber()
        {
            Console.WriteLine("Enter a Number to check it prime or not");
            int Num = int.Parse(Console.ReadLine());
            int Count = 0;
            for (int i = 1; i <= Num / 2; i++)
            {
                if (Num % i == 0)
                {
                    Count++;
                }

            }
            if (Count == 1)
            {
                Console.WriteLine("{0} is prime Number", Num);
            }
            else
            {
                Console.WriteLine("{0} is Not prime Number", Num);

            }
        }
    }
}
