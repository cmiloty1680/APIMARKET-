using Apimarket.Functions;
using Apimarket.Model;
using Microsoft.AspNetCore.Mvc;

namespace Apimarket.Controller
{
    [ApiController]
    [Route("Api/[controller]")]

    public class FeedingController : ControllerBase
    {
<<<<<<< HEAD
        public IConfiguration _Configuration { get; set; }
        public GeneralFunctions FunctionsGeneral;
        public FeedingController(IConfiguration configuration)
        {
            FunctionsGeneral = new GeneralFunctions(configuration);
            _Configuration = configuration;

        }



=======
        public GeneralFunctions FunctionsGeneral;

        public FeedingController(IConfiguration configuration)
        {
            FunctionsGeneral = new GeneralFunctions(configuration);

        }
    

    
>>>>>>> c96aa416e04d7ef31742a99d00d6162b2a199347
        [HttpPost("CreateFeeding")]
        public IActionResult CreateFeeding(FeedingModel number)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                FunctionsGeneral.Addlog(ex.ToString());
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet("GetsFeeding")]
        public IActionResult getsFeeding(FeedingModel number)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                FunctionsGeneral.Addlog(ex.ToString());
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("GetFeeding")]
        public IActionResult GetFeeding(FeedingModel number)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                FunctionsGeneral.Addlog(ex.ToString());
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost("UpdateFeeding")]
        public IActionResult UpdateFeeding(FeedingModel number)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                FunctionsGeneral.Addlog(ex.ToString());
                return StatusCode(500, ex.Message);
            }
        }
        [HttpDelete("DeleteFeeding")]
        public IActionResult DeleteFeeding(FeedingModel number)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                FunctionsGeneral.Addlog(ex.ToString());
                return StatusCode(500, ex.Message);
            }
        }

    }
}





