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
    [Route("Api/[controller]")]
    public class ReviewController : Controller
    {
<<<<<<< HEAD
        public IConfiguration _Configuration { get; set; }
        public GeneralFunctions FunctionsGeneral;
        public ReviewController(IConfiguration configuration)
        {
            FunctionsGeneral = new GeneralFunctions(configuration);
            _Configuration = configuration;

        }
=======
>>>>>>> c96aa416e04d7ef31742a99d00d6162b2a199347
        [HttpPost("CreateReview")]
        public IActionResult CreateReview(ReviewModel Review)
        {
            try
            {
<<<<<<< HEAD
            return Ok();
=======
                // Lógica para crear una nueva revisión
>>>>>>> c96aa416e04d7ef31742a99d00d6162b2a199347
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message.ToString());
            }
<<<<<<< HEAD
=======
            return Ok();
>>>>>>> c96aa416e04d7ef31742a99d00d6162b2a199347
        }

        [HttpGet("GetReviews")]
        public IActionResult GetReviews()
        {
            try
            {
<<<<<<< HEAD
            return Ok();
=======
                // Lógica para obtener todas las revisiones
>>>>>>> c96aa416e04d7ef31742a99d00d6162b2a199347
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message.ToString());
            }
<<<<<<< HEAD
=======
            return Ok();
>>>>>>> c96aa416e04d7ef31742a99d00d6162b2a199347
        }

        [HttpGet("GetReview")]
        public IActionResult GetReview()
        {
            try
            {
<<<<<<< HEAD
            return Ok();
=======
                // Lógica para obtener una revisión específica
>>>>>>> c96aa416e04d7ef31742a99d00d6162b2a199347
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message.ToString());
            }
<<<<<<< HEAD
        }

        [HttpPost("UpdateReview")]
=======
            return Ok();
        }

        [HttpPut("UpdateReview")]
>>>>>>> c96aa416e04d7ef31742a99d00d6162b2a199347
        public IActionResult UpdateReview(ReviewModel review)
        {
            try
            {
<<<<<<< HEAD
            return Ok();
=======
                // Lógica para actualizar una revisión existente
>>>>>>> c96aa416e04d7ef31742a99d00d6162b2a199347
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message.ToString());
            }
<<<<<<< HEAD
=======
            return Ok();
>>>>>>> c96aa416e04d7ef31742a99d00d6162b2a199347
        }

        [HttpDelete("DeleteReview")]
        public IActionResult DeleteReview()
        {
            try
            {
<<<<<<< HEAD
            return Ok();
=======
                // Lógica para eliminar una revisión
>>>>>>> c96aa416e04d7ef31742a99d00d6162b2a199347
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message.ToString());
            }
<<<<<<< HEAD
=======
            return Ok();
>>>>>>> c96aa416e04d7ef31742a99d00d6162b2a199347
        }
    }
}

