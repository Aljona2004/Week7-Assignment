using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma PIN-kood:");
            string userPIN = Console.ReadLine();

            Console.WriteLine("Sisesta oma kasutajatunnus ja parool:");
            string userName = Console.ReadLine();
            string passWord = Console.ReadLine();

            if(userPIN == "1532" && userName == "user1" && passWord == "password1" )
            {
                Console.WriteLine($"Tere tulemast!");
            }
            else
            {
                Console.WriteLine($"Midagi läks valesti. Proovi uuesti.");
            }


                
        }
    }
}
