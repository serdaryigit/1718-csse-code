using System;
using System.Collections;

namespace oefening2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Oefening 2: Rijen van Fibonacci
            
            Console.Write("Geef een getal in: ");
            int reeks = Convert.ToInt32(Console.ReadLine());

            int fib1 = 0;
            int fib2 = 1;

            Console.WriteLine(fib1);
            Console.WriteLine(fib2);

            for (int i = 3; i <= reeks; i++)
            {
                int fib3 = fib1 + fib2;
                fib1 = fib2;
                fib2 = fib3;
                Console.WriteLine(fib3);

            }          
        }
    }
}
