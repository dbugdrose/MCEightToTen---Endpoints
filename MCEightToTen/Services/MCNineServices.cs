using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace MCEightToTen.Services
{
    public class MCNineServices
    {
        public int numToGuess = 0;
        public int maxNum = 0;
        public string RandomizeNumber(int number)
        { 
            Random random = new Random();
            numToGuess = random.Next(1, maxNum+1);

            if (number > maxNum)
            {return "Please enter a number within the specified range.";}
            else if (number > numToGuess)
            {   
                return $"Too high! The number was actually {numToGuess}.";
                
            }
            else if (number < numToGuess)
            { return $"Too low! The number was actually {numToGuess}."; }
            else
            { 
            return $"You guessed correctly! The number was {numToGuess}.";

            }
        }
    }
}