﻿using System.ComponentModel.DataAnnotations;

namespace recordBook.Models
{
    public class UserViewModel
	{
        [Required(ErrorMessage ="Введите логин")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Введите пароль")]
        public string Password { get; set; }
    }
}
