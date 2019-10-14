using System;

namespace skuška
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Zadajte číslo: ");
            int number = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Zadajte druhé číslo: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int result = Remainder(number, number2);
            Console.WriteLine($"Toto je zvyšok z delenia: {result}");
        }
        private static int Remainder(int number, int number2)
        {
            return number % number2;
        }



    }
}
