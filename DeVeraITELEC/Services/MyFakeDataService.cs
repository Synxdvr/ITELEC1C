using System;
using DeVeraITELEC.Models;
using DeVeraITELEC.Services;

namespace DeVeraITELEC.Services
{
    public class MyFakeDataService : IMyFakeDataService
    {
        public List<Student> StudentList { get; }
        public List<Instructor> Instructors { get; }

        public MyFakeDataService() 
        {
            StudentList = new List<Student>
            {
                new Student()
                {
                    Id = 1,
                    FirstName = "Test",
                    LastName = "Test",
                    Course = Course.BSIT,
                    AdmissionDate = DateTime.Parse("2012-03-04"),
                    GPA = 1.5,
                    Email = "Test.test.cics@ust.edu.ph"
                },
                new Student()
                {
                    Id = 2,
                    FirstName = "Test",
                    LastName = "Test",
                    Course = Course.BSIS,
                    AdmissionDate = DateTime.Parse("2012-03-04"),
                    GPA = 1.5,
                    Email = "Test.test.cics@ust.edu.ph"
                },
                new Student()
                {
                    Id = 3,
                    FirstName = "Test",
                    LastName = "Test",
                    Course = Course.BSCS,
                    AdmissionDate = DateTime.Parse("2012-03-04"),
                    GPA = 1.5,
                    Email = "Test.test.cics@ust.edu.ph"
                },
            };

            Instructors = new List<Instructor>
            {
                new Instructor()
                {
                    Id = 1,
                    FirstName = "Test",
                    LastName = "Test",
                    IsTenured = true,
                    Rank = Rank.Instructor,
                    HiringDate = DateTime.Parse("05/06/2078")
                },
                new Instructor()
                {
                    Id = 2,
                    FirstName = "Test",
                    LastName = "Test",
                    IsTenured = false,
                    Rank = Rank.AssistantProfessor,
                    HiringDate = DateTime.Parse("05/06/2078")
                },
                new Instructor()
                {
                    Id = 3,
                    FirstName = "Test",
                    LastName = "Test",
                    IsTenured = true,
                    Rank = Rank.Professor,
                    HiringDate = DateTime.Parse("05/06/2078")
                },
            };
        }
    }
}
