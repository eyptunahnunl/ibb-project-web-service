using Business.Abstract;
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
            //Swagger -- API Dokumantasyonu sağlar.

            var result = _isParkService.GetAllIsPark();
            if (result.Success)
            {
                return Ok(result); //200 Http Ok result.Data
            }
            return BadRequest(result); //400 Bad Request result.Message

        }
    }
}
