using System;

namespace _1
{
     class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Enter Integer: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int cube = num*num*num;
            Console.WriteLine("Your number: {0} and it's Cube : {1} ",num,cube);
            
            Console.ReadLine();
        }  
    }
}
