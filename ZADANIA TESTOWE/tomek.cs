using System;
namespace siszarp
{

    class tomek
    {
        static void Main()
        {
           
            Console.WriteLine("Podaj pierwszą liczbę całkowitą:");
            if (int.TryParse(Console.ReadLine(), out int liczba1))
            {
                Console.WriteLine("Podaj drugą liczbę całkowitą:");
                if (int.TryParse(Console.ReadLine(), out int liczba2))
                {
                    Console.WriteLine("Podaj trzecią liczbę całkowitą:");
                    if (int.TryParse(Console.ReadLine(), out int liczba3))
                    {
                        
                        int suma = liczba1 + liczba2 + liczba3;

                        
                        Console.WriteLine($"Suma liczb: {liczba1} + {liczba2} + {liczba3} = {suma}");

                       
                        if (suma % 3 == 0)
                        {
                            Console.WriteLine("Suma liczb jest podzielna przez 3 (reszta z dzielenia wynosi 0).");
                        }
                        else
                        {
                            Console.WriteLine("Suma liczb nie jest podzielna przez 3 (reszta z dzielenia jest różna od 0).");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nieprawidłowy format trzeciej liczby.");
                    }
                }
                else
                {
                    Console.WriteLine("Nieprawidłowy format drugiej liczby.");
                }
            }
            else
            {
                Console.WriteLine("Nieprawidłowy format pierwszej liczby.");
            }
        }
    }
}
