using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class FibonacciSeries
    {
        public void FibonacciFn()
        {
            int firstNum = 0;
            int secondNum = 1;
            int i = 1;
            int NextNum;
            Console.WriteLine(" Enter number for  how many terms of series to be printed  ");

            int Num = int.Parse(Console.ReadLine());

            Console.WriteLine("First {0} Numbers of Fibonacci series Are ", Num);
            Console.WriteLine();
            Console.WriteLine(firstNum);
            Console.WriteLine(secondNum);

            while (i <= (Num - 2))
            {
                NextNum = secondNum + firstNum;
                Console.WriteLine(NextNum);
                firstNum = secondNum;
                secondNum = NextNum;
                i++;
            }
        }
    }
}
