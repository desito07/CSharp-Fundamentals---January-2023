using System;

namespace Intro_and_Basic_Syntax
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());

            if (num >= 0 && num <= 2)
            {
                Console.WriteLine("baby");
            }
            else if (num >= 3 && num <= 13)
            {
                Console.WriteLine("child");
            }
            else if (num >= 14 && num <= 19)
            {
                Console.WriteLine("teenager");
            }
            else if (num >= 20 && num <= 65)
            {
                Console.WriteLine("adult");
            }
            else if (num >= 66)
            {
                Console.WriteLine("elder");
            }
        }
    }
}



