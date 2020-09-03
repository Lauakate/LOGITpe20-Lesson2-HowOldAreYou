using System;

namespace HowOldAareYou
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1. App greets the user
             * 2. App asks the users name
             * 3. App greets the user by their name
             * 4. App asks the users age
             * 5. App calculates the age of the user
             * 6. The App displays the result (the users name)
            */

            Console.WriteLine("Greetings!");
            Console.WriteLine("What is your name?");
            string Name;
            Name = Console.ReadLine();
                Console.WriteLine("Hello, " + Name);
            Console.WriteLine("When were you born, " + Name + "?");
            string UserInput;
            UserInput = Console.ReadLine();
            int YearOfBirth;
            //parsing string to integer (number)
            YearOfBirth = Int32.Parse(UserInput);
            int Age = 2020 - YearOfBirth;
            Console.WriteLine("You are " + Age + " old.");



            

        }
    }
}
