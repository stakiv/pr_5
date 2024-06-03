using System.ComponentModel.DataAnnotations;

namespace _5praktika.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Введите юзернейм")]
        public string? Username { get; set; }
		[Required(AllowEmptyStrings = false, ErrorMessage = "Введите пароль")]
		public string? Password { get; set; }
    }
}
