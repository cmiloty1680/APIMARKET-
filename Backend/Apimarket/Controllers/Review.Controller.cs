using APIMARKET.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIMARKET.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class ReviewController : Controller
    {
        [HttpPost("CreateReview")]
        public IActionResult CreateReview(ReviewModel Review)
        {
            try
            {
                // Lógica para crear una nueva revisión
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message.ToString());
            }
            return Ok();
        }

        [HttpGet("GetReviews")]
        public IActionResult GetReviews()
        {
            try
            {
                // Lógica para obtener todas las revisiones
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message.ToString());
            }
            return Ok();
        }

        [HttpGet("GetReview")]
        public IActionResult GetReview()
        {
            try
            {
                // Lógica para obtener una revisión específica
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message.ToString());
            }
            return Ok();
        }

        [HttpPut("UpdateReview")]
        public IActionResult UpdateReview(ReviewModel review)
        {
            try
            {
                // Lógica para actualizar una revisión existente
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message.ToString());
            }
            return Ok();
        }

        [HttpDelete("DeleteReview")]
        public IActionResult DeleteReview()
        {
            try
            {
                // Lógica para eliminar una revisión
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message.ToString());
            }
            return Ok();
        }
    }
}

