using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many fence post you want to paint : ");
            double post = int.Parse(Console.ReadLine()); 
            
            double bucket = post/4;

            Console.WriteLine($"You need {bucket} Bucket of paints.");
        }
    }
}
