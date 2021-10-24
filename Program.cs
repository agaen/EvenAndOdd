using System;

namespace EvenAndOdd
{
    class Program
    {
        public static void Main()
        {


            Console.WriteLine("Podaj liczbę całkowitą");
            var number = GetNumber();
            var remainder = number % 2;

            if (remainder != 0)
            {
                Console.WriteLine("Liczba jest nieparzysta");
            }
            else
            {
                Console.WriteLine("Liczba jest parzysta");
            }
        }
        private static int GetNumber()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int Number))
                {
                    Console.WriteLine("Nieprawidłowy format. Podaj inną liczbę");
                    continue;
                }
                return Number;
            }

        }

    }
}





