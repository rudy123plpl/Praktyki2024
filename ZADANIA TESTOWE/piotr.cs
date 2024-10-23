
   using System;
namespace siszarp
{

    class Piotr
    {
        static void Main()
        {
            Console.WriteLine("Podaj liczbę całkowitą:");
            int liczba;

            
            if (int.TryParse(Console.ReadLine(), out liczba))
            {
                if (liczba > 0)
                {
                    Console.WriteLine("Liczba jest dodatnia.");
                }
                else if (liczba < 0)
                {
                    Console.WriteLine("Liczba jest ujemna.");
                }
                else
                {
                    Console.WriteLine("Liczba jest zerem.");
                }
            }
            else
            {
                Console.WriteLine("Nieprawidłowy format liczby. Proszę podać liczbę całkowitą.");
            }
        }
    }
}

