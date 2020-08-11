using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter 4 digit intigers: ");
            int digits =Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            //Citation start: 
            while(digits!=0)
                {
                    int remainder = digits % 10;
                    sum = sum + remainder;
                    digits = digits / 10;
                }
            Console.WriteLine("Sum is : {0}",sum);
            //digits divided by 10 and remainder added to sum
            //https://www.c-sharpcorner.com/blogs/find-the-sum-of-entered-number-using-c-sharpnet
            //Citation ends : 
            Console.ReadLine();
        }
    }
}
