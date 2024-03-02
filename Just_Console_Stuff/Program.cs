using System;
using System.Diagnostics;

namespace Just_Console_Stuff
{
    internal class Program
    {
        static int fakt(int n)
        {
            int a = 1;

            for (int i = 1; i < n + 1; i++)
            {
                a *= i;
            }
            return a;
        }

        static int fakt_rec(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return n * fakt_rec(n-1);
            }
        }

        static int fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return fibonacci(n - 1) + fibonacci(n - 2);

        }

        static void Main(string[] args)
        {
            var timer = new Stopwatch();

            Console.WriteLine("Kerek egy szamot");
            int be = Convert.ToInt32(Console.ReadLine());
            timer.Start();
            Console.WriteLine(fibonacci(be));
            timer.Stop();
            Console.WriteLine("lefutási idő: "+timer.Elapsed.ToString(@"m\:ss\.fff"));
            Console.ReadKey();
        }
    }
}
