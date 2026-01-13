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

    public class MCTenController : ControllerBase
    {
         private readonly MCTenServices _mcTenServices;

        public MCTenController(MCTenServices mcTenServices)
        {
            _mcTenServices = mcTenServices;
        }
            [HttpPost("TypeMexicanAsianOrFast/{foodcategory}")]
            public string RandomizedRestaurant(string foodcategory){
                return _mcTenServices.RandomizedRestaurant(foodcategory);
            }

    }
}