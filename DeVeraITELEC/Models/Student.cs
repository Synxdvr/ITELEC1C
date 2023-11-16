using System.ComponentModel.DataAnnotations;

namespace DeVeraITELEC.Models
{
    public enum Course
    {
        BSIT, BSCS, BSIS, OTHER
    }

    public class Student
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "GPA is required")]
        public double GPA { get; set; }

        public Course Course { get; set; }

        [Display(Name = "Admission Date")]
        [Required(ErrorMessage = "Admission date is required")]
        [DataType(DataType.Date)]
        public DateTime AdmissionDate { get; set; }

        [Display(Name = "Email Address")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        [Required(ErrorMessage = "Email address is required")]
        public string Email { get; set; }

    }
}
