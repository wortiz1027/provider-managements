using System;
using Microsoft.AspNetCore.Mvc;
using Infraestructure.Context;
using Api.Requests;
using Api.Response;
using Api.Utils;
using Core.Utils;

namespace Api.Controllers {

    [ApiController]
    [Route("/providers/api/v1/")]
    public class ProvidersUpdateCommandController : ControllerBase {
        
        private ProvidersContext _Context;

        public ProvidersUpdateCommandController(ProvidersContext context) {
            _Context = context;
        }

        [HttpPut("vendors")]
        public IActionResult update([FromBody] UpdateRequest data){
            if (data == null){
                return BadRequest();
            }

            Status status = new Status();
            status.code = Enum.GetName(typeof(StatusCodes), 1);
            status.description = "Providers has been updated succesfully";

            CreateResponse response = new CreateResponse();
            response.status = status;
            return Ok(response);
        }
    }


}