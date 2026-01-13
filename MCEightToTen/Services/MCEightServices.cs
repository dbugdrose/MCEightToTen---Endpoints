using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.VisualBasic;
using MCEightToTen.Controllers;

namespace MCEightToTen.Services
{
    public class MCEightServices
    {
        public string RandomAnswer(string question)
        {
           if (question.Contains("?"))
           { Random random = new Random();
            int rndNumber = random.Next(1, 9);

            switch (rndNumber)
            {
                case 1: return "Try again.";
                case 2: return "Maybe.";
                case 3: return "It is certain.";
                case 4: return "Most likely.";
                case 5: return "My reply is no.";
                case 6: return "Outlook not so good.";
                case 7: return "Signs point to yes.";
                case 8: return "Very doubtful.";
                default: 
                return "Unknown";
            }
           }

           else
            {
                return "Please enter a valid question.";
            }
        }
    }
}