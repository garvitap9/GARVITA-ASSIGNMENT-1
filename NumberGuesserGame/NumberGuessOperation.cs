using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesserGame
{
    public class NumberGuessOperation
    {
        public int countChancesOver = 5;
        public static int countingTrialsByUser = 0;

        public static void NumberGuessGameStart()
        {
            Console.WriteLine("Enter your username: ");
            string nameUser = Console.ReadLine();
            int lowerRange = 1;
            int upperRange = 100;
            Random randomNumberGenerated = new Random();
            int numberToBeGuessed = randomNumberGenerated.Next(lowerRange, upperRange);
            //Console.WriteLine(numberToBeGuessed);
            NumberGuessOperation numberGuessObject = new NumberGuessOperation();

            string userChoice;
            do
            {
                int numberGeneratedRandomly = numberGuessObject.NumberGuessGameLogic(numberToBeGuessed, lowerRange, upperRange, nameUser);
                NumberGuessOperation.countingTrialsByUser = 0;
                numberToBeGuessed = randomNumberGenerated.Next(lowerRange, upperRange);
                //Console.WriteLine(numberToBeGuessed);
                Console.WriteLine(" ");
                Console.WriteLine("Want to play the Number Guessing Game again?");
                Console.WriteLine("Press y/Y for playing: ");
                userChoice = Console.ReadLine();

            } while (userChoice == "y" || userChoice == "Y");

            Console.WriteLine("THANK YOU!! EXITING THE GAME...");
        }

        public int NumberGuessGameLogic(int numberToBeGuessed, int lowerRange, int upperRange, string userName)
        {
            for (int i = 1; i <= countChancesOver; i++)
            {
                Console.WriteLine(" ");
                Console.WriteLine("ATTEMPT- " + i + " Guess the number: ");
                int userInputGuess = int.Parse(Console.ReadLine());
                if (userInputGuess < numberToBeGuessed)
                {
                    Console.WriteLine($"{userName} guessed a lower number!Try Again!");
                    lowerRange = userInputGuess + 1;
                    countingTrialsByUser++;
                    if (i == countChancesOver)
                    {
                        Console.WriteLine("Your attempts are over! \n Better Luck Next Time! The number was " + numberToBeGuessed);
                        break;
                    }
                }
                else if (userInputGuess > numberToBeGuessed)
                {
                    countingTrialsByUser++;
                    Console.WriteLine($"{userName} guessed a higher number!Try Again!");
                    upperRange = userInputGuess - 1;
                    if (i == countChancesOver)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Your attempts are over! \nBetter Luck Next Time! The number was " + numberToBeGuessed);
                        break;
                    }
                }
                else
                {
                    countingTrialsByUser++;
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine($"Congratulations! {userName} Won!! Number was: {numberToBeGuessed}");
                    Console.WriteLine(" ");
                    Console.WriteLine($"{userName} guessed it Right at attempt no. " + i + " !");
                    Console.WriteLine(" ");
                    Console.WriteLine($"{userName} took {countingTrialsByUser} attempts to WIN the GAME!");
                    Console.WriteLine("-----------------------------------------");
                    break;
                }
            }
            return countingTrialsByUser;
        }
    }
}
        












   