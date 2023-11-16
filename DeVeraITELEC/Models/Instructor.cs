using System.ComponentModel.DataAnnotations;

namespace DeVeraITELEC.Models
{
    public enum Rank
    {
        Instructor, AssistantProfessor, AssociateProfessor, Professor
    }

    public class Instructor
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }

        [Display(Name = "Status")]
        [Required(ErrorMessage = "Status is required")]
        public bool IsTenured { get; set; }

        public Rank Rank { get; set; }

        [Display(Name = "Hiring Date")]
        [Required(ErrorMessage = "Hiring date is required")]
        [DataType(DataType.Date)]
        public DateTime HiringDate { get; set; }

        [RegularExpression("[0-9]{11}", ErrorMessage = ("Must be 11 digits"))]
        [Required(ErrorMessage = "Phone is required")]
        public string Phone { get; set; }
    }
}
