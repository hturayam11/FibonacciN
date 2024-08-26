using System;
namespace fibonacciapp;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci Sequence in loop");
            for ( int i = 0; i < 10; i++)
            {
                Console.Write(FibonacciLoop(i) + " ");
                
            }

            Console.WriteLine("\nFibonacci Sequence using Recursion:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(FibonacciRecursion(i) + " ");
            }
        }

        static int FibonacciLoop(int n)
        {
            if (n <= 1) return n;
            int a = 0, b = 1, c = 0;
            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }

        static int FibonacciRecursion(int n)
        {
            if (n <= 1) return n;
            return FibonacciRecursion(n - 1) + FibonacciRecursion(n-2);
        }
    } 

     
