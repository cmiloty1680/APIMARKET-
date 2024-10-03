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
<<<<<<< HEAD
    public class RaceController : ControllerBase
    {
        public IConfiguration _Configuration { get; set; }
        public GeneralFunctions FunctionsGeneral;
        public RaceController(IConfiguration configuration)
        {
            FunctionsGeneral = new GeneralFunctions(configuration);
            _Configuration = configuration;

        }
=======
    public class RaceController : Controller
    {
>>>>>>> c96aa416e04d7ef31742a99d00d6162b2a199347
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
<<<<<<< HEAD
            return Ok();
=======
                // Lógica para obtener todas las razas
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

        [HttpGet("GetRace")]
        public IActionResult GetRace()
        {
            try
            {
<<<<<<< HEAD
            return Ok();
=======
                // Lógica para obtener una raza específica
>>>>>>> c96aa416e04d7ef31742a99d00d6162b2a199347
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message.ToString());
            }
<<<<<<< HEAD
        }

        [HttpPost("UpdateRace")]
=======
            return Ok();
        }

        [HttpPut("UpdateRace")]
>>>>>>> c96aa416e04d7ef31742a99d00d6162b2a199347
        public IActionResult UpdateRace(RaceModel race)
        {
            try
            {
<<<<<<< HEAD
            return Ok();
=======
                // Lógica para actualizar una raza existente
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

        [HttpDelete("DeleteRace")]
        public IActionResult DeleteRace()
        {
            try
            {
<<<<<<< HEAD
            return Ok();
=======
                // Lógica para eliminar una raza
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

