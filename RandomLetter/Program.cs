using System;

namespace RandomLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta eesnimi:");
            string userName = Console.ReadLine();

            Random rnd = new Random();
            string myuserName = rnd.ToString;
            Console.WriteLine($"Su juhuslik täht on{userName}:");
        }
    }
}
