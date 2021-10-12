using System;

namespace CakeReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta lause:");
            string cakeReplace= Console.ReadLine();
            cakeReplace = cakeReplace.Replace('4', 'a');
            cakeReplace = cakeReplace.Replace('1', 'i');
            cakeReplace = cakeReplace.Replace('3', 's');

            Console.WriteLine(cakeReplace);


            

        }
    }
}
