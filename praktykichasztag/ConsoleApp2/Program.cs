using System;
namespace drugiprojekt
{

    class krzysztof
    {
        static void Main()
        {
            Console.WriteLine("Podaj pierwszą liczbę:");
            if (float.TryParse(Console.ReadLine(), out float liczba1))
            {

                Console.WriteLine("Podaj drugą liczbę:");
                if (float.TryParse(Console.ReadLine(), out float liczba2))
                {

                    float suma = liczba1 + liczba2;
                    float roznica = liczba1 - liczba2;
                    float iloczyn = liczba1 * liczba2;
                    float iloraz = liczba2 != 0 ? liczba1 / liczba2 : float.NaN;


                    Console.WriteLine($"Suma: {liczba1} + {liczba2} = {suma}");
                    Console.WriteLine($"Różnica: {liczba1} - {liczba2} = {roznica}");
                    Console.WriteLine($"Iloczyn: {liczba1} * {liczba2} = {iloczyn}");
                    if (float.IsNaN(iloraz))
                    {
                        Console.WriteLine("Dzielenie przez zero jest niemożliwe.");
                    }
                    else
                    {
                        Console.WriteLine($"Iloraz: {liczba1} / {liczba2} = {iloraz}");
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
