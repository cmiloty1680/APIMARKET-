using Apimarket.Functions;
using Apimarket.models;
using Apimarket.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Apimarket.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class ResponsibleController : ControllerBase
    {
        public GeneralFunctions FunctionsGeneral;
        public IConfiguration _Configuration { get; set; }
        private readonly ResponsibleServices _ResponsibleServices;
        public JWTModels JWT;


        public ResponsibleController(IConfiguration configuration, ResponsibleServices responsibleServices)
        {
            _ResponsibleServices = responsibleServices;
            _Configuration = configuration;
            JWT = _Configuration.GetSection("JWT").Get<JWTModels>();


        }
        [HttpPost("Login")]
        public IActionResult Login(LoginUser login)
        {
            try
            {

                var key = Encoding.UTF8.GetBytes(JWT.KeySecret);



                ClaimsIdentity subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim("User", login.Email)
                });

                var tokenDescriptor = new SecurityTokenDescriptor

                {
                    Subject = subject,
                    Expires = DateTime.Now.AddMinutes(Convert.ToDouble(JWT.JWTExpireTime)),
                    SigningCredentials = new SigningCredentials(
                        new SymmetricSecurityKey(key),
                        SecurityAlgorithms.HmacSha256Signature

                        )
                };

                var token = new JwtSecurityTokenHandler().CreateToken(tokenDescriptor);

                return Ok(new JwtSecurityTokenHandler().WriteToken(token));
            }
            catch (Exception ex)
            {
                FunctionsGeneral.Addlog(ex.Message);
                return StatusCode(500, ex.ToString);
            }
        }
        [HttpPost("ResetPassUser")]

        public async Task<IActionResult> ResetPassword(ResetPassUser Responsible)
        {
            try
            {
                var response = await FunctionsGeneral.SendEmail(Responsible.Email);
                if (response.Status)
                {
                    return Ok(response);
                }
                return BadRequest(response);

            }

            catch (Exception ex)
            {
                FunctionsGeneral.Addlog(ex.Message);
                return StatusCode(500, ex.ToString());
            }
        }
        [HttpPost("CreateResponsible")]
        public IActionResult CreateResponsible(Responsible responsible)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                FunctionsGeneral.Addlog(ex.ToString());
                return StatusCode(500, ex.ToString);
            }
        }
        [HttpGet("GetResponsible")]
        public IActionResult GetResponsible(int id)
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
        [HttpGet("GetsAllResponsible")]
        public IActionResult GetsAllResponsible(int id)
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
        [HttpPost("UpdateResponsible")]
        public IActionResult UpdateResponsible(Responsible responsible)
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
        [HttpDelete("DeleteResponsible")]
        public IActionResult DeleteResponsible(int id)
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
        [HttpGet("AllResponsible")]
        public ActionResult<IEnumerable<Responsible>> GetResponsible()
        {
            return Ok(_ResponsibleServices.GetResponsible());
        }
    }
}
