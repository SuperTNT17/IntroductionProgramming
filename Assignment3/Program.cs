using System;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            // read first name of user
            Console.Write("Enter your first name: ");
            string firstname = Console.ReadLine();

            // read last name of user
            Console.Write("Enter your last name: ");
            string lastname = Console.ReadLine();

            // display full name (option 1)
            //Console.WriteLine("Your full name is " + firstname + " " + lastname);

            // display full name (option 2)
            //Console.WriteLine("Your full name is {0} {1}", firstname, lastname);

            // display full name (option 3 - string interpolation)
            Console.WriteLine($"Your full name is {firstname} {lastname}");

            //wait for the user to enter a key
            Console.ReadKey();
        }
    }
}
