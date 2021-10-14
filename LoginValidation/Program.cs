using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 3)
            {

                Console.WriteLine("Palun sisesta oma Parool");
                string Password = Console.ReadLine();
                Console.WriteLine("Sisesta oma username");
                string userName = Console.ReadLine();
                Console.WriteLine("Sisesta oma PIN");
                string PIN = Console.ReadLine();

                if (userName == "user1" && Password == "password1" && PIN == "1532")
                {
                    Console.WriteLine("Tere Tulemast.");
                    break;
                }
                else
                {
                    i = i + 1;
                    Console.WriteLine($"Proovi uuesti. {3 - i} katset jäänud");
                }
            }
    }
}
