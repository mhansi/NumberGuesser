using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            //set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "M HanSi Senanayake";

            //change text color
            Console.ForegroundColor = ConsoleColor.Green;

            //write out app info
            Console.WriteLine("{0}: version {1} by {2}", appName, appVersion, appAuthor);

            //reset text color 
            Console.ResetColor();

            //Ask user name
            Console.WriteLine("What is your name");

            //Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game",inputName);

            while (true) { 
            //init correct number
            //int correctNumber = 7;

            //Create a new Random object
            Random random = new Random();

            int correctNumber = random.Next(1, 10);

            //init guess number
            int guess = 0;

            //ask user for number
            Console.WriteLine("Guess a number between 1 and 10");

            //while guess is not correct 
            while(guess != correctNumber)
            {
                //get user input
                string input = Console.ReadLine();

                //Make sure it's a number
                if(!int.TryParse(input, out guess))
                {
                    //change text color
                    Console.ForegroundColor = ConsoleColor.Red;

                    //Tell user it's not a number
                    Console.WriteLine("This is not a number. Please try again.");

                    //Reset text color
                    Console.ResetColor();

                    continue;  

                }

                //cast to int and put in guess

                guess = Int32.Parse(input);

                //Match guess to correct number
                if(guess != correctNumber)
                {
                    //change text color
                    Console.ForegroundColor = ConsoleColor.Red;

                    //write out app info
                    Console.WriteLine("wrong number, please try again");

                    //Reset text color
                    Console.ResetColor();

                }

            }
            //change text color
            Console.ForegroundColor = ConsoleColor.Yellow;

            //Tell user its the right number
            Console.WriteLine("You are correct!");

            //Reset text color
            Console.ResetColor();

                //ask to play again
                Console.WriteLine("Play again? [Y or N");

                //Get answer
                String answer = Console.ReadLine().ToUpper();

                if(answer == "Y")
                {
                    continue;
                }
                else if(answer=="N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }
    }
}
