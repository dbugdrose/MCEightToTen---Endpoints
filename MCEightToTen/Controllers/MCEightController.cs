using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MCEightToTen.Services;

namespace MCEightToTen.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MCEightController : ControllerBase
    {
        private readonly MCEightServices _mcEightServices;

        public MCEightController(MCEightServices mcEightServices)
        {
            _mcEightServices = mcEightServices;
        }

        [HttpPost("AskAQuestion/{question}")] 
        public string AskAQuestion(string question)
        {
            return _mcEightServices.RandomAnswer(question);
        }
    }
}