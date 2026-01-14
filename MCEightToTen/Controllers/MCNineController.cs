using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MCEightToTen.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MCEightToTen.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MCNineController : ControllerBase
    {
        private readonly MCNineServices _mcNineServices;
        public MCNineController(MCNineServices mcNineServices)
        {
            _mcNineServices = mcNineServices;
        }

        [HttpPost("GuessANumber1to10/{number}")] 
        public string GuessEasyNumber(int number)
        {   _mcNineServices.maxNum = 10;
            return _mcNineServices.RandomizeNumber(number);
        }


        [HttpPost("GuessANumber1to50/{number}")] 
        public string GuessMediumNumber(int number)
        {   _mcNineServices.maxNum = 50;
            return _mcNineServices.RandomizeNumber(number);
        }

        [HttpPost("GuessANumber1to100/{number}")] 

        public string GuessHardNumber(int number)
        {    _mcNineServices.maxNum = 100;
            return _mcNineServices.RandomizeNumber(number);
        }
    }
}