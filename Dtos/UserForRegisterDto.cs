﻿using System.ComponentModel.DataAnnotations;

namespace WTOPMDb.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public required string Username { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "You must specify a password between 4 and 8 characters")]
        public required string Password { get; set; }
    }
}
