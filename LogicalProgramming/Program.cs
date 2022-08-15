namespace LogicalProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical programming");
            Console.WriteLine("Enter 1 for Fibonacci series program");
            int Check = Convert.ToInt32(Console.ReadLine());
            switch (Check)
            {
                case 1:
                    FibonacciSeries fibonacciSeries = new FibonacciSeries();
                    fibonacciSeries.FibonacciFn();
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;

            }
        }
    }
}