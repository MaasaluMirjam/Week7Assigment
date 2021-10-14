using System;

namespace RandomLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your firstname:");
            string firstname = Console.ReadLine();
            Random rnd = new Random();

            int i = rnd.Next(0, firstname.Length - 1);
            Console.WriteLine(firstname[i]);
        }
    }
}
