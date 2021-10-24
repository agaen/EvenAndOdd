using System;

namespace EvenAndOdd
{
    class Program
    {
        public static void Main()
        {


            Console.WriteLine("Podaj liczbę całkowitą");
            var number1 = GetNumber();
            var number2 = number1 % 2;

            if (number2 != 0)
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





