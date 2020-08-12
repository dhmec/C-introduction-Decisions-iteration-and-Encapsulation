using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int password = rng.Next(1,9);
            char c = Convert.ToChar(password);
            Console.WriteLine($"Your Password is :{c}");
            
         
        }
    }
}
