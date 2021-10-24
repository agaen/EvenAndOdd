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
            Console.WriteLine(number2);

            if (number2 == 0)
            {
                Console.WriteLine("Liczba jest parzysta");
            }
            else
            {
                Console.WriteLine("Liczba jest nieparzysta");
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





