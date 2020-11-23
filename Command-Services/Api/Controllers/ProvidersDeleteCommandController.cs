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
    public class ProvidersDeleteCommandController : ControllerBase {
        
        private ProvidersContext _Context;

        public ProvidersDeleteCommandController(ProvidersContext context) {
            _Context = context;
        }

        [HttpDelete("vendors")]
        public IActionResult delete([FromBody] DeleteRequest data){
            if (data == null){
                return BadRequest();
            }

            Status status = new Status();
            status.code = Enum.GetName(typeof(StatusCodes), 2);
            status.description = "Providers has been deleted succesfully";

            CreateResponse response = new CreateResponse();
            response.status = status;
            return Ok(response);
        }
    }


}