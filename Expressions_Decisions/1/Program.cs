using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter First Number in range 1 to 10 :");
            int a = int.Parse(Console.ReadLine()); 
            
            Console.Write("Please Enter Second Number in range 1 to 10 :");
            int b = int.Parse(Console.ReadLine()); 
            
            
            Random rng = new Random();
            int number = rng.Next(1,11);
            
            Console.WriteLine($"Number is :{number}");

            if (number == a)
            {
                Console.WriteLine("First Person is Winner");

            }
            else if(number == a-1 || number == a+1)
            {
                Console.WriteLine("First Person is Winner");
            }
            else if(number == b)
            {
                
                Console.WriteLine("First Person is Winner");

            }
            else if(number == b-1 || number == b+1)
            {
                Console.WriteLine("Second Person is Winner");
            }
            else if(number == a-2 || number == a+2)
            {
                Console.WriteLine("First Person is Winner");
            }
            else if(number == b-2 || number == b+2)
            {
                Console.WriteLine("Second Person is Winner");

            }
            else if(number == a && number ==b)
            {
                Console.WriteLine("Draw");
            }
            else
            {
                Console.WriteLine("Please try again");
            }

            
        
            
        }
    }
}
