using Apimarket.Functions;
using Apimarket.models;
using Apimarket.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Apimarket.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class ProductionController : ControllerBase
    {

        public IConfiguration _Configuration { get; set; }
        public GeneralFunctions FunctionsGeneral;
        public ProductionController(IConfiguration configuration)
        {
            FunctionsGeneral = new GeneralFunctions(configuration);
            _Configuration = configuration;

        }

        [HttpPost("CreateProduction")]
        public IActionResult CreateProduction(ProductionModel production)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                FunctionsGeneral.Addlog(ex.ToString());
                return StatusCode(500, ex.ToString());

            }
        }
        [HttpGet("GetProduction")]

        public IActionResult GetProduccion(int id)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                {

                    FunctionsGeneral.Addlog(ex.ToString());
                    return StatusCode(500, ex.ToString());
                }
            }
        }
        [HttpGet("GetsAllProduction")]

        public IActionResult GetsAllProduccion(int id)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                {

                    FunctionsGeneral.Addlog(ex.ToString());
                    return StatusCode(500, ex.ToString());
                }
            }
        }
        [HttpPost("UpdateProduction")]
        public IActionResult UpdateProduction(int Id, ProductionModel production)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                FunctionsGeneral.Addlog(ex.ToString());
               return StatusCode(500, ex.ToString() );
            }
        }
        [HttpDelete("DeleteProduction")]
        public IActionResult DeleteProduction(int id)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                FunctionsGeneral.Addlog(ex.ToString());
                return StatusCode(500, ex.ToString());
            }
        }

    }
}