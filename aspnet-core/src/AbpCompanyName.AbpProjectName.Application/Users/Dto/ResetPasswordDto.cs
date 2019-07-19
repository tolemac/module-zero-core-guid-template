﻿using System;
using System.ComponentModel.DataAnnotations;

namespace AbpCompanyName.AbpProjectName.Users.Dto
{
    public class ResetPasswordDto
    {
        [Required]
        public string AdminPassword { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [Required]
        public string NewPassword { get; set; }
    }
}
