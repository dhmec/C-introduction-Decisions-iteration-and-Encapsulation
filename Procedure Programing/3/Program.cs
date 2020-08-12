using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Age : ");
            int age = int.Parse(Console.ReadLine());
            int year = (2020 - age);
            Console.WriteLine("Your Birth Year was : {0}",year);

           
        }
    }
}
