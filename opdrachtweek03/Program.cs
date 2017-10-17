using System;
using System.Collections;

namespace opdrachtweek03
{
    class Program
    {
        static void Main(string[] args)
        {
            
        /// Vermenigvuldingstafel zonder input
        //  for (int i = 1; i <= 7; i++)
        //  {
        //      for (int j = 0; j <= 10; j++)
        //      {
        //          Console.WriteLine("{0} x {1} = {2}", j, i, i*j);
        //      }
        //  }
        //  Console.ReadLine();


        /// Vermenigvuldigingstafel met input

        Console.WriteLine("Voer een getal in:");
        int getal = int.Parse(Console.ReadLine());

        string resultaat = "";

        for (int i = 0; i < 11; i++)
        {
        resultaat += ($"{i.ToString()} x {getal.ToString()} = {getal * i} \n");
        }
        Console.WriteLine(resultaat);

        }
    }
}
