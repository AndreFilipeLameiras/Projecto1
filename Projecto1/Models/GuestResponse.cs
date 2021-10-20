using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projecto1.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Name should have at least 3 characters and no more than 100")]        
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your phone number")]
        [Phone(ErrorMessage = "Invalid phone number")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please enter your email address")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }
        public bool? WillAttend { get; set; }
    }
}
