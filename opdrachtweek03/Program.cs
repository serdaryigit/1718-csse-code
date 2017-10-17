using System;

namespace opdrachtweek03
{
    class Program
    {
        static void Main(string[] args)
        {

    //vermenigvuldingstafel
        
       for (int i = 1; i <= 7; i++)
     {
          for (int j = 0; j <= 10; j++)
          {
            Console.WriteLine("{0} x {1}={2}", j, i, i*j);
         }
       }
        Console.ReadLine();

        }
    }
}
