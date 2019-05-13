using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApplication.WebUI.Models
{
    public class OrderViewModel
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

        [Display(Name = "Order Time")]
        [DataType(DataType.Date)]
        public DateTime? OrderTime { get; set; }

        public List<String> Products { get; set; }

        public int Price { get; set; }
        
        //public string Name { get; set; }


    }
}
