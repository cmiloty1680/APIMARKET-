using Apimarket.Functions;
using Apimarket.Model;
using Microsoft.AspNetCore.Mvc;

namespace Apimarket.Controller
{
    [ApiController]
    [Route("Api/[controller]")]
    public class ProtocolController : ControllerBase
    {
<<<<<<< HEAD
        public IConfiguration _Configuration { get; set; }
        public GeneralFunctions FunctionsGeneral;
        public ProtocolController(IConfiguration configuration)
        {
            FunctionsGeneral = new GeneralFunctions(configuration);
            _Configuration = configuration;
=======
        public GeneralFunctions FunctionsGeneral;

        public ProtocolController(IConfiguration configuration) 
        {
            FunctionsGeneral = new GeneralFunctions(configuration);
>>>>>>> c96aa416e04d7ef31742a99d00d6162b2a199347

        }
        [HttpPost("CreateProtocol")]
        public IActionResult CreateProtocol(ProtocolModel number)
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
        [HttpGet("GetsProtocol")]
        public IActionResult getsProtocol(ProtocolModel number)
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

        [HttpGet("GetProtocol")]
        public IActionResult GetProtocol(ProtocolModel number)
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
        [HttpPost("UpdateProtocol")]
        public IActionResult UpdateProcol(ProtocolModel number)
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
        [HttpDelete("DeleteProtocol")]
        public IActionResult DeleteProtocol(ProtocolModel number)
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
