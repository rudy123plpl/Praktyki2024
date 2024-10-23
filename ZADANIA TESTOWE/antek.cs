using System;
namespace siszarp
{

    class antek
    {
        static void Main()
        {
            
            Console.WriteLine("Podaj tekst:");
            string tekst = Console.ReadLine();

           
            Console.WriteLine("Podaj znak, którego wystąpienia chcesz zliczyć:");
            char znak;

            
            if (char.TryParse(Console.ReadLine(), out znak))
            {
                int liczbaWystapien = 0;

                foreach (char c in tekst)
                {
                    if (c == znak)
                    {
                        liczbaWystapien++;
                    }
                }

                Console.WriteLine($"Znak '{znak}' występuje w tekście {liczbaWystapien} razy.");
            }
            else
            {
                Console.WriteLine("Nieprawidłowy znak. Proszę podać dokładnie jeden znak.");
            }
        }
    }
}
