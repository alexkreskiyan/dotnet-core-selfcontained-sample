using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main()
        {
            var run = true;
            Console.CancelKeyPress += (sender, args) => run = false;

            while (run)
            {
                Console.WriteLine("Hello World!");
                Console.ReadLine();
            }
        }
    }
}
