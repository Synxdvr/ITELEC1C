namespace DeVeraITELEC.Models
{
    public enum Course
    {
        BSIT, BSCS, BSIS, OTHER
    }

    public class Student
    {
       
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public double GPA { get; set; }
        public Course Course { get; set; }
        public DateTime AdmissionDate { get; set; }
        public required string Email { get; set; }

    }
}
