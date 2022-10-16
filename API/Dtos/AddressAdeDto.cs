using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class AddressAdeDto
    {
        [Required]
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string DisplayName { get; set; }
         [Required]
         public string LastName { get; set; }
          [Required]
         public string Street { get; set; }
          [Required]
         public string City { get; set; }
          [Required]
         public string State { get; set; }
          [Required]
         public string ZipCode { get; set; }
    }
}