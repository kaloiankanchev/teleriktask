using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TelerikThomas.Models.Contracts;

namespace TelerikThomas.Models
{
    public class Person : IPerson
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please insert first name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please insert last name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Phone number is required")]

        public int Phone { get; set; }
    }
}
