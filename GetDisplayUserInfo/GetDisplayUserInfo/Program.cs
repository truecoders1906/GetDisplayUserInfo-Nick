using System;

namespace GetDisplayUserInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("Hello, " + firstName + ". " + "It's very nice to meet you!");

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            Console.WriteLine(lastName + "... " + "that is a very unique last name!");

            Console.WriteLine("What is your favorite number?");
            string favoriteNumberResponse = Console.ReadLine();
            int favoriteNumber = int.Parse(favoriteNumberResponse);

            Console.WriteLine(favoriteNumberResponse + ", that is my 17th favorite number. HAHA.");


            Console.WriteLine("How many pets do you have?");
            string numberOfPets = Console.ReadLine();
            int petNumber = int.Parse(numberOfPets);

            string[] petNames = new string[petNumber];

            for (int i = 0; i < petNumber; i++)
            {
                Console.WriteLine("What is the name of your pet?");
                string petName = Console.ReadLine();
                petNames[i] = petName;

            }


        }
    }
}
