using Microsoft.AspNetCore.Mvc;
using DeVeraITELEC.Models;
using DeVeraITELEC.Data;
using Microsoft.EntityFrameworkCore;

namespace DeVeraITELEC.Controllers
{
    public class InstructorController : Controller
    {
        private readonly AppDbContext _dbContext;
        private DbSet<Instructor> Instructors;

        public InstructorController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            Instructors = _dbContext.Instructors;
        }

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
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
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
                instructor.FirstName = instructorChange.FirstName;
                instructor.LastName = instructorChange.LastName;
                instructor.Rank = instructorChange.Rank;
                instructor.IsTenured = instructorChange.IsTenured;
                instructor.HiringDate = instructorChange.HiringDate;
            }
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            //Search for the student whose id matches the given id
            Instructor? instructor = Instructors.FirstOrDefault(st => st.Id == id);

            if (instructor != null)//was an student found?
                return View(instructor);

            return NotFound();
        }
        [HttpPost]
        public IActionResult Delete(Instructor removeInstructor)
        {
            Instructor? instructor = Instructors.FirstOrDefault(st => st.Id == removeInstructor.Id);

            if (instructor != null)
            {
                Instructors.Remove(instructor);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return NotFound();
        }

    }
}
