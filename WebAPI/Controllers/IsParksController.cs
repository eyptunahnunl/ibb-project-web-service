using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IsParksController : ControllerBase
    {
        IIsParkService _isParkService;
        public IsParksController(IIsParkService isParkService)
        {
            _isParkService = isParkService;
        }


        [HttpGet("getispark")]
        public IActionResult Get()
        {
      

            var result = _isParkService.GetAllIsPark();
            if (result.Success)
            {
                return Ok(result); 
            }
            return BadRequest(result); 

        }


        [HttpPost("update")]
        public IActionResult Update(IsPark isPark)
        {
            var result = _isParkService.Update(isPark);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("updatebyid")]
        public IActionResult UpdateById(int parkid)
        {
            var result = _isParkService.GetIsParkById(parkid);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getid")]
        public IActionResult GetById(int parkid)
        {
            var result = _isParkService.GetIsParkById(parkid);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        

    }
}
