using System;
namespace PetlaWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int minimum = int.MaxValue;

            Console.WriteLine("Podaj liczby od 0 do 10, aby zatrzymać pętlę podaj liczbę 5.");

            while (true)
            {

                int number = Convert.ToInt32(Console.ReadLine());

                if (number == 5)
                {
                    break;
                }

                if (number < minimum)
                {
                    minimum = number;
                }

                sum += number;
            }

            sum = sum * sum;

            Console.WriteLine("Suma wszystkich elementów podniesiona do kwadratu: " + sum);
            Console.WriteLine("Najmniejszy element: " + minimum);
        }
    }
}