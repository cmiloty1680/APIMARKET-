using APIMARKET.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIMARKET.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class RaceController : Controller
    {
        [HttpPost("CreateRace")]
        public IActionResult CreateRaza(RaceModel race)
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
        public IActionResult GetRazas()
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
        public IActionResult GetRaza()
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
        public IActionResult UpdateRaza(RaceModel raza)
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
        public IActionResult DeleteRaza()
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

