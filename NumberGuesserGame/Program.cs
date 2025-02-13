using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesserGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO TRIMAC GUESS NUMBER GAME!");
            Console.WriteLine("------------------");
            Console.WriteLine("| KNOW THE RULES: | \n1. Only 5 guessing attempts allowed! \n2. Guessing Range: 1-100!");
            Console.WriteLine("-----------------------------------------");
            NumberGuessOperation.NumberGuessGameStart();
        } 
    }
}
