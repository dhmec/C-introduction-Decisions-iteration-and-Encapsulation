using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How much the total of a Bill : ");
            int total = int.Parse(Console.ReadLine());
            Console.Write("How many People : ");
            int people =  int.Parse(Console.ReadLine());
            int each = (total/people);
            Console.WriteLine("Each need to pay : {0}",each);

            
        }
    }
}
