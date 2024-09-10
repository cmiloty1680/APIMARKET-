using APIMARKET.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIMARKET.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class RaceController : Controller
    {
        [HttpPost("CreateRace")]
        public IActionResult CreateRace(RaceModel race)
        {
            try
            {
                // Lógica para crear una nueva raza
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message.ToString());
            }
            return Ok();
        }

        [HttpGet("GetBreeds")]
        public IActionResult GetBreeds()
        {
            try
            {
                // Lógica para obtener todas las razas
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message.ToString());
            }
            return Ok();
        }

        [HttpGet("GetRace")]
        public IActionResult GetRace()
        {
            try
            {
                // Lógica para obtener una raza específica
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message.ToString());
            }
            return Ok();
        }

        [HttpPut("UpdateRace")]
        public IActionResult UpdateRace(RaceModel race)
        {
            try
            {
                // Lógica para actualizar una raza existente
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message.ToString());
            }
            return Ok();
        }

        [HttpDelete("DeleteRace")]
        public IActionResult DeleteRace()
        {
            try
            {
                // Lógica para eliminar una raza
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message.ToString());
            }
            return Ok();
        }
    }
}

