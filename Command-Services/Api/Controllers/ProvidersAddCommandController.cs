using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Api.Controllers {

    [ApiController]
    [Route("/providers/api/v1/")]
    public class ProvidersAddCommandController : ControllerBase {
        
        [HttpPost("vendors")]
        public IActionResult hello([FromBody] String name){
            if (name.Length == 0){
                return BadRequest();
            }

            return Ok(String.Concat("Saludos ", name));
        }
    }


}