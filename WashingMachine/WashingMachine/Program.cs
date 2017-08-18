using System;

namespace WashingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            for(int i =0; i < 50; i++)
            {
                Console.WriteLine(rand.Next(0, 2));
            }
        }
    }
}
