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
    public class ProvidersAddCommandController : ControllerBase {
        
        private ProvidersContext _Context;

        public ProvidersAddCommandController(ProvidersContext context) {
            _Context = context;
        }

        [HttpPost("vendors")]
        public IActionResult create([FromBody] CreateRequest data){
            if (data == null){
                return BadRequest();
            }

            Status status = new Status();
            status.code = Enum.GetName(typeof(StatusCodes), 0);
            status.description = "Providers has been created succesfully";

            CreateResponse response = new CreateResponse();
            response.status = status;
            return Ok(response);
            //return Ok(_Context.Types.ToList());
        }
    }


}