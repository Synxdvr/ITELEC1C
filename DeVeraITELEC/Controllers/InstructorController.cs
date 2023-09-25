using Microsoft.AspNetCore.Mvc;
using DeVeraITELEC.Models;
using DeVeraITELEC.Services;
using System.ComponentModel;


namespace DeVeraITELEC.Controllers
{
    public class InstructorController : Controller
    {
        private readonly IMyFakeDataService _fakeData;
        public InstructorController(IMyFakeDataService fakeData)
        {
            _fakeData = fakeData;
        }

        public IActionResult Index()
        {

            return View(_fakeData.Instructors);
        }

        public IActionResult ShowDetail(int id)
        {
            //Search for the student whose id matches the given id
            Instructor? instructor = _fakeData.Instructors.FirstOrDefault(st => st.Id == id);

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
            _fakeData.Instructors.Add(newInstructor);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            //Search for the student whose id matches the given id
            Instructor? instructor = _fakeData.Instructors.FirstOrDefault(st => st.Id == id);

            if (instructor != null)//was an student found?
                return View(instructor);

            return NotFound();
        }

        [HttpPost]
        public IActionResult Edit(Instructor instructorChange)
        {
            Instructor? instructor = _fakeData.Instructors.FirstOrDefault(st => st.Id == instructorChange.Id);

            if (instructor != null)
            {
                instructor.Id = instructorChange.Id;
                instructor.FirstName = instructorChange.FirstName;
                instructor.LastName = instructorChange.LastName;
                instructor.Rank = instructorChange.Rank;
                instructor.IsTenured = instructorChange.IsTenured;
                instructor.HiringDate = instructorChange.HiringDate;
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            //Search for the student whose id matches the given id
            Instructor? instructor = _fakeData.Instructors.FirstOrDefault(st => st.Id == id);

            if (instructor != null)//was an student found?
                return View(instructor);

            return NotFound();
        }
        [HttpPost]
        public IActionResult Delete(Instructor removeInstructor)
        {
            Instructor? instructor = _fakeData.Instructors.FirstOrDefault(st => st.Id == removeInstructor.Id);

            if (instructor != null)
            {
                _fakeData.Instructors.Remove(instructor);
            }
            return RedirectToAction("Index");
        }

    }
}
