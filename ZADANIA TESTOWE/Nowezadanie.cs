using System;
namespace siszarp
{
    class Xyz
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Podaj pierwszą liczbę:");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj drugą liczbę:");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj trzecią liczbę:");
            int number3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj czwartą liczbę:");
            int number4 = int.Parse(Console.ReadLine());

              bool allEven = (number1 % 2 == 0) && (number2 % 2 == 0) && (number3 % 2 == 0) && (number4 % 2 == 0);

            
            if (allEven)
            {
                Console.WriteLine("Czy wszystkie liczby są parzyste? Tak");
            }
            else
            {
                Console.WriteLine("Czy wszystkie liczby są parzyste? Nie");
            }
        }
    }
}



