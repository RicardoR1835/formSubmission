using System;
using System.ComponentModel.DataAnnotations;

namespace formSubmission.Models
{
    public class User
    {
        [Display(Name = "Your First Name:")]
        [Required]
        [MinLength(3)]
        public string FName {get;set;} 


        [Display(Name = "Your Last Name:")]
        [Required]
        [MinLength(3)]
        public string LName {get;set;}


        [Display(Name = "Your Age:")]
        [Required]
        public int Age {get;set;}


        [Display(Name = "Your Email:")]
        [Required]
        [EmailAddress]
        public string Email {get;set;}


        [Display(Name = "Your Password:")]
        [Required]
        [MinLength(7)]
        [DataType(DataType.Password)]
        public string Password {get;set;}
    }
}