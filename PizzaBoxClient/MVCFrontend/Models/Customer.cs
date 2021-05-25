using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCFrontend.Models
{
    public class Customer
    {
        [Key]
        [Display(AutoGenerateField = false)]
        public int Id { get; set; }
        [Required]
        [StringLength(25, ErrorMessage = "Name should be between 2 and 25 characters in length", MinimumLength =2)]
        [RegularExpression(@"^[a-zA-Z]+", ErrorMessage = "Name must only contain letters")]
        [Remote("DoesNameExist", "CustomerController", HttpMethod = "POST", ErrorMessage = "User name already exists. Please enter a different user name.")]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(12, ErrorMessage = "Password must be 6-12 characters in length", MinimumLength = 6)]
        [RegularExpression(@"^[a-zA-Z0-9]+", ErrorMessage = "Name must only contain letters and/or numbers")]
        public string Password { get; set; }
    }
}
