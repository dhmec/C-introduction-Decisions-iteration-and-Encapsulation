using System;

namespace _1
{
     class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Enter Integer: ");
            int num = int.Parse(Console.ReadLine());
            int cube = num*num*num;
            Console.WriteLine("You Entered : {0}  and it's Cube : {1} ",num,cube);
            
            
        }  
    }
}
