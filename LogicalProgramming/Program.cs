namespace LogicalProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical programming");
            Console.WriteLine("Enter 1 for Fibonacci series program");
            Console.WriteLine("Enter 2 for Perfect Number program");
            Console.WriteLine("Enter 3 for Prime Number program");
            int Check = Convert.ToInt32(Console.ReadLine());
            switch (Check)
            {
                case 1:
                    FibonacciSeries fibonacciSeries = new FibonacciSeries();
                    fibonacciSeries.FibonacciFn();
                    break;
                case 2:
                    PerfectNumber perfectNumber = new PerfectNumber();
                    perfectNumber.PerfectNumbers();

                    break;
                case 3:
                    PrimeNumbers primeNumbers = new PrimeNumbers();
                    primeNumbers.PrimeNumber();
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;

            }
        }
    }
}