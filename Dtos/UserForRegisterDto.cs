using System.ComponentModel.DataAnnotations;

namespace WTOPMDb.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        [StringLength(8, MinimumLength = 2, ErrorMessage = "You must specify a Username between 2 and 8 characters")]
        public required string Username { get; set; }

        [Required]
        [StringLength(16, MinimumLength = 4, ErrorMessage = "You must specify a Password between 4 and 16 characters")]
        public required string Password { get; set; }
    }
}
