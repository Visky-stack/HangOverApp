using System.ComponentModel.DataAnnotations;

namespace HangOver.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 6, ErrorMessage = "You must specify password between 6 to 10 characters")]
        public string Password { get; set; }
    }
}