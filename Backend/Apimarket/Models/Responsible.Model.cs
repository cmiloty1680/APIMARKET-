namespace Apimarket.Models
{
    public class LoginUser
    {
        [Required(ErrorMessage = "el campo es requerido")]
        public string Email { get; set; }
        public string Password { get; set; }

        public int id { get; set; }
    }

    internal class RequiredAttribute : Attribute
    {
        public string ErrorMessage { get; set; }
    }
    public class ResetPassUser
    {
        public string Email { get; set; }
    }
    public class Responsible
    {
        public int Id { get; set; }
        public string Nam_Responsible { get; set; }
        public string LasNam_Responsible { get; set; }

        public int NumDoc_Responsible { get; set; }
        public int Pho_Responsible { get; set; }

        public string Ema_Responsible { get; set; }

        public string Pass_Responsible { get; set; }

        public string Tok_Responsible { get; set; }

        public bool Blockad { get; set; }
    }
}
