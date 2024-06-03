using System.ComponentModel.DataAnnotations;

namespace _5praktika.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Введите юзернейм")]
        public string? Username { get; set; }
		[Required(AllowEmptyStrings = false, ErrorMessage = "Введите пароль")]
		public string? Password { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Введите имя")]
        public string? FirstName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Введите фамилию")]
        public string? LastName { get; set; }
    }
}
