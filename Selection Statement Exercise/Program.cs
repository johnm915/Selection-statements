using System;

namespace Selection_Statement_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int favoriteNumber = 15;
            Console.WriteLine("guess my favorite number, Hint, under 20");
            int userGuess = int.Parse(Console.ReadLine());
      
            if (userGuess < favoriteNumber)
            {
                Console.WriteLine("too low, Guess Again");

            }           

           else if (userGuess > favoriteNumber)
            {
                Console.WriteLine("Nope Too High");

            }

            else if (userGuess == favoriteNumber) 
            {
                Console.WriteLine("Good Job!");
            }

            else 
            { 
                Console.WriteLine("Nevermind forget it!");

            }


            string subject = ("Math");
            Console.WriteLine("Choose a subject");
            string usersubJect = Console.ReadLine();

            switch (usersubJect)
            {
                case "Math":
                    Console.WriteLine("You are in the right class");
                    break;
                case ("not math"):
                    Console.WriteLine("please be sure you are inthe correct class");
                    break;
                    

                default:
                    break;
            }
                    
        }
    }
}
