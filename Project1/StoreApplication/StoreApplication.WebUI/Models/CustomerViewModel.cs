﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApplication.WebUI.Models
{
    public class CustomerViewModel
    {
        // the HTML/tag helpers like "DisplayNameFor"
        // will use this instead of the property's name
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        //public IEnumerable<ReviewViewModel> Reviews { get; set; }
        [Display(Name = "Location")]
        public string LocationName { get; set; }

        
    }
}
