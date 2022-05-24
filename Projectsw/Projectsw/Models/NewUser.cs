//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projectsw.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class NewUser
    {
        public int Id { get; set; }
      
        [Required(ErrorMessage = "Full Name*")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email*")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
       
        [Required(ErrorMessage = "City*")]
        public string City { get; set; }
       
        [Required(ErrorMessage = "password*")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "password*")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Not Match")]
        public string ConfirmPassword { get; set; }
    }
}
