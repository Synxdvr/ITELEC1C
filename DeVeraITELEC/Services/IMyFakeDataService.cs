using DeVeraITELEC.Models;

namespace DeVeraITELEC.Services
{
    public interface IMyFakeDataService
    {
        List<Student> StudentList { get; }
        List<Instructor> Instructors { get; }
    }
}
