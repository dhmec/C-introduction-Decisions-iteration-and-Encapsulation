using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Please Enter First Number :");
            int a = int.Parse(Console.ReadLine()); 
            
            Console.Write("Please Enter Second Number :");
            int b = int.Parse(Console.ReadLine()); 
            
            Console.Write("Please Enter Third Number :");
            int c = int.Parse(Console.ReadLine()); 
            
            // Citation Start: 
            int num = Math.Max(a,Math.Max(b,c));
            //https://www.w3resource.com/csharp-exercises/basic/csharp-basic-exercise-39.php
            //Citation End:
            Console.WriteLine("Your biggest num : {0}",num);
           
        }
    }
}
