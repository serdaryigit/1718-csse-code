using System;

namespace oefening1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Oefening 1: Priemgetal
            // Geef een getal in naar keuze klener dan 100
            // Overlopen van 1 tot gekozen getal
            // Priemgetal(deelbaar door 1 en zichzelf)

            Console.Write("Geef een getal in van 0 tot 100: ");
			int input = Convert.ToInt32(Console.ReadLine());
			for(var x = 0; x <= input; x++)
			{
				int deelbaar = 0;
                for (int i = 2; i <= x; i++)
                if (x % i == 0)                        
                deelbaar++;

                if (x != 1 && deelbaar == 1){
                Console.WriteLine(x + " is een priemgetal.");
                }
                else{ 
                    Console.WriteLine(x + " is geen priemgetal.");
                }
			}
        }
    }
}
