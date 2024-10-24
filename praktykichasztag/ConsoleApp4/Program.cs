using System;
namespace drugiprojekt
{
    class filip
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[4]; 
            bool inputValid;

            for (int i = 0; i < numbers.Length; i++)
            {
                do
                {
                    Console.WriteLine($"Podaj liczbę {i + 1}:");
                    inputValid = int.TryParse(Console.ReadLine(), out numbers[i]);

                    if (!inputValid)
                    {
                        Console.WriteLine("To nie jest poprawna liczba. Spróbuj ponownie.");
                    }
                } while (!inputValid); 
            }

            bool allEven = true;
            foreach (int number in numbers)
            {
                if (number % 2 != 0)
                {
                    allEven = false;
                    break; 
                }
            }

            Console.WriteLine("Czy wszystkie liczby są parzyste? " + (allEven ? "Tak" : "Nie"));
        }
    }
}
