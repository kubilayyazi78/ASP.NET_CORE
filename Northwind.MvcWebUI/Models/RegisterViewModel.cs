﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.MvcWebUI.Models
{
    public class RegisterViewModel
    {
        [Required]
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }
    //    [DataType(DataType.Password)]
      //  [Required]
       // public string ConfrimPassword { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
