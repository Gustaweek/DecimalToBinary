using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe calkowita nie ujemna:");
            int decimalNumber = int.Parse(Console.ReadLine());
            if (decimalNumber > 0)
            {
                int remainder;
                string result = string.Empty;
                while (decimalNumber > 0)
                {
                    remainder = decimalNumber % 2;
                    decimalNumber /= 2;
                    result = remainder.ToString() + result;
                }
                Console.WriteLine("Liczba Binarna:  {0}", result);
            }
            else
                Console.WriteLine("PODAJ LICZBE NIE UJEMNA");
        }
    }
}
