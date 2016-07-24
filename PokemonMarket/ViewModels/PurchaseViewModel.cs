﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PokemonMarket.ViewModels
{
    public class PurchaseViewModel
    {
        [Required]
        [Display(Name="Имя")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Телефон")]
        public string Phone { get; set; }
    }
}