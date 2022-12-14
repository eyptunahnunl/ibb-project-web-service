using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParksController : ControllerBase
    {
        IParkService _parkService;
        public ParksController(IParkService parkService)
        {
            _parkService = parkService;
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {
            
            var result = _parkService.GetAll();
            if (result.Success)
            {
                return Ok(result); 
            }
            return BadRequest(result); 

        }


        [HttpPost("add")]
        public IActionResult Post(Park park)
        {
            var result = _parkService.Add(park);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpGet("getalldetail")]
        public IActionResult GetAllDetail()
        {
            
            var result = _parkService.GetParkDetails();
            if (result.Success)
            {
                return Ok(result); 
            }
            return BadRequest(result); 
        }

    }
}
