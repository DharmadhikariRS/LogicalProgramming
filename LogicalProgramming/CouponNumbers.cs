using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class CouponNumbers
    {
        public void coupans()
        {
            Console.WriteLine("Enter for how many coupans You want to check");
            int NumOfCoupans = int.Parse(Console.ReadLine());
            int i = 0;
            int[] arr = new int[NumOfCoupans];
            Console.WriteLine("Enter {0} Coupan Values", NumOfCoupans);
            while (i < NumOfCoupans)
            {

                arr[i] = int.Parse(Console.ReadLine());
                i++;
            }
            int MaxValueCoupan = arr.Max();

            int AllMatch = 0;
            int[] arr2 = new int[NumOfCoupans];
            bool val = true;
            int RandomTrack = 0;
            while (AllMatch != NumOfCoupans)
            {

                Random r = new Random();
                int RandomNum = r.Next(MaxValueCoupan + 1);
                Console.WriteLine(RandomNum);

                int index = 0;
                foreach (int N in arr)
                {


                    if (val)
                    {
                        if (RandomNum == 0 && N == 0)
                        {
                            AllMatch++;
                            Console.WriteLine("Random number is {0}  So Coupan {1} is  Found ", RandomNum, N);
                            val = false;
                        }
                    }
                    if (RandomNum == N)
                    {
                        if (arr2[index] != N)
                        {

                            arr2[index] = N;

                            AllMatch++;
                            Console.WriteLine("Random number is {0}  So Coupan {1} is  Found ", RandomNum, N);
                        }


                    }
                    index++;

                }

                RandomTrack++;
            }


            Console.WriteLine("Total Random numbers required to Find {0} coupan numbers is {1}", NumOfCoupans, RandomTrack++);
            Console.WriteLine("All elements Matched");
        }
    }
}
