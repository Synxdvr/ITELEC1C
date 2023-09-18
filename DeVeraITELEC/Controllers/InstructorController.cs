using Microsoft.AspNetCore.Mvc;
using DeVeraITELEC.Models;


namespace DeVeraITELEC.Controllers
{
    public class InstructorController : Controller
    {
        List<Instructor> Instructors = new List<Instructor>
            {
                new Instructor()
                {
                    Id= 1,
                    FirstName = "Gabriel",
                    LastName = "Montano",
                    IsTenured = true, 
                    Rank = Rank.Professor, 
                    HiringDate = DateTime.Parse("2022-08-26")
                },
                new Instructor()
                {
                    Id= 2,
                    FirstName = "Zyx",
                    LastName = "Montano", 
                    IsTenured = false, 
                    Rank = Rank.Instructor, 
                    HiringDate = DateTime.Parse("2022-08-07")
                },
                new Instructor()
                {
                    Id= 3,
                    FirstName = "Aerdriel",
                    LastName = "Montano", 
                    IsTenured = true, 
                    Rank = Rank.Professor, 
                    HiringDate = DateTime.Parse("2020-01-25")
                }

                
            };
        public IActionResult Index()
        {

            return View(Instructors);
        }

        public IActionResult ShowDetail(int id)
        {
            //Search for the student whose id matches the given id
            Instructor? instructor = Instructors.FirstOrDefault(st => st.Id == id);

            if (instructor != null)//was an student found?
                return View(instructor);

            return NotFound();
        }

        [HttpGet]
        public IActionResult AddInstructor()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddInstructor(Instructor newInstructor)
        {
            Instructors.Add(newInstructor);
            return View("Index", Instructors);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            //Search for the student whose id matches the given id
            Instructor? instructor = Instructors.FirstOrDefault(st => st.Id == id);

            if (instructor != null)//was an student found?
                return View(instructor);

            return NotFound();
        }

        [HttpPost]
        public IActionResult Edit(Instructor instructorChange)
        {
            Instructor? instructor = Instructors.FirstOrDefault(st => st.Id == instructorChange.Id);

            if (instructor != null)
            {
                instructor.Id = instructorChange.Id;
                instructor.FirstName = instructorChange.FirstName;
                instructor.LastName = instructorChange.LastName;
                instructor.Rank = instructorChange.Rank;
                instructor.IsTenured = instructorChange.IsTenured;
                instructor.HiringDate = instructorChange.HiringDate;
            }
            return View("Index", Instructors);
        }

    }
}
