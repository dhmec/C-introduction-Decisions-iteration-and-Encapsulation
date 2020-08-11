using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How much the total of a Bill : ");
            double total = Convert.ToDouble(Console.ReadLine());
            Console.Write("How many People : ");
            int people =  Convert.ToInt32(Console.ReadLine());
            double each = (total/people);
            Console.WriteLine("Each need to pay : {0}",each);

            Console.ReadLine();
        }
    }
}
