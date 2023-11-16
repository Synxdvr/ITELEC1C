using System.ComponentModel.DataAnnotations;

namespace DeVeraITELEC.Models
{
    public class RegisterViewModel
    {
        [Display(Name = "Username")]
        [Required(ErrorMessage = "Username is required")]
        public string? UserName { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }

        [Display(Name = "Comfirm Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "You must confirm your password")]
        public string? ConfirmPassword { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Firstname is required")]
        public string? FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Lastname is required")]
        public string? LastName { get; set; }

        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email Address is required")]
        public string? Email { get; set; }

        [RegularExpression("[0-9]{11}", ErrorMessage = "Must be 11 digits")]
        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Phone number is required")]
        public string? Phone { get; set; }
    }
}