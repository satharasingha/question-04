using System;

namespace question03
{
    class question03
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the value of N: ");


            int n;
            if (Int32.TryParse(Console.ReadLine(), out n) && n > 0)
            {

                Console.WriteLine("The first " + n + " terms of the Fibonacci series are:");
                PrintFibonacciSeries(n);
            }
            else
            {

                Console.WriteLine("ERROR: Invalid input. Please enter a positive integer.");
            }
        }


        static void PrintFibonacciSeries(int n)
        {

            int current = 0;
            int next = 1;


            Console.Write(current + " ");


            for (int i = 1; i < n; i++)
            {

                Console.Write(next + " ");


                int temp = next;
                next = current + next;
                current = temp;
            }
        }
    }
}
