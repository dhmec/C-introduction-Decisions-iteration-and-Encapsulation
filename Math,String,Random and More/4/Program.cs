using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter First Side of Right Triangle :");
            double a = int.Parse(Console.ReadLine()); 
            
            Console.Write("Please Enter Second Side of Right Triangle :");
            double b = int.Parse(Console.ReadLine()); 
            
            double c = (a*a + b*b);
            double d = Math.Sqrt(c);
            
            Console.Write($"The Hypotenuse of the Right Triangle is  : {d} ");
            
        }
    }
}
