<<<<<<< HEAD
﻿using Apimarket.Functions;
using APIMARKET.Models;
=======
﻿using APIMARKET.Models;
>>>>>>> c96aa416e04d7ef31742a99d00d6162b2a199347
using Microsoft.AspNetCore.Mvc;

namespace APIMARKET.Controllers
{
    [ApiController]
    [Route("Api/controller")]
<<<<<<< HEAD
    public class ExtractionController : ControllerBase
    {
        public IConfiguration _Configuration { get; set; }
        public GeneralFunctions FunctionsGeneral;
        public ExtractionController(IConfiguration configuration)
        {
            FunctionsGeneral = new GeneralFunctions(configuration);
            _Configuration = configuration;

        }
=======
    public class ExtractionController : Controller
    {
>>>>>>> c96aa416e04d7ef31742a99d00d6162b2a199347
        [HttpPost("CreateExtraction")]
        public IActionResult CreateExtraction(ExtractionModel extraction)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message.ToString());
            }
            
        }
        [HttpGet("GetExtractions")]
        public IActionResult GetExtractions()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message.ToString());
            }
            
        }
        [HttpGet("GetExtraction")]
        public IActionResult GetExtraction()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message.ToString());
            }
            
        }
        [HttpPost("updateExtraction")]
        public IActionResult updateExtraction(ExtractionModel extraction)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message.ToString());
            }
            
        }
        [HttpDelete("DeleteExtraction")]
        public IActionResult DeleteExtraction()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message.ToString());
            }
            
        }
    }
}
