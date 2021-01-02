using System;
namespace NumberConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number.RomanNumber());
            Console.ReadKey();
        }


       
    }
}