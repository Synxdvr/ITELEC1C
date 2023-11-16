using Microsoft.AspNetCore.Mvc;
using DeVeraITELEC.Models;
using DeVeraITELEC.Services;
using DeVeraITELEC.Data;
using Microsoft.EntityFrameworkCore;

namespace DeVeraITELEC.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext _dbContext;
        private DbSet<Student> Students;
        public StudentController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            Students = _dbContext.Students;
        }
        public IActionResult Index()
        {
            return View(Students);
        }
        public IActionResult Student()
        {
            return View();
        }
        public IActionResult ShowDetail(int id)
        {
            //Search for the student whose id matches the given id
            Student? student = Students.FirstOrDefault(st => st.Id == id);
            
            if (student != null)//was an student found?
                return View(student);

            return NotFound();
        }

        [HttpGet]
            public IActionResult AddStudent()
            {
                return View();
            }
        [HttpPost]
            public IActionResult AddStudent(Student newStudent)
            {
                Students.Add(newStudent);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }

        [HttpGet]
            public IActionResult Edit(int id) 
            {
                //Search for the student whose id matches the given id
                Student? student = Students.FirstOrDefault(st => st.Id == id);

                if (student != null)//was an student found?
                    return View(student);

                return NotFound();
            }

        [HttpPost]
            public IActionResult Edit(Student studentChange)
            {
                Student? student = Students.FirstOrDefault(st => st.Id == studentChange.Id);

                if (student != null)
                {
                    student.FirstName = studentChange.FirstName;
                    student.LastName = studentChange.LastName;
                    student.Email = studentChange.Email;
                    student.Course = studentChange.Course;
                    student.GPA = studentChange.GPA;
                    student.AdmissionDate = studentChange.AdmissionDate;
                }
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            //Search for the student whose id matches the given id
            Student? student = Students.FirstOrDefault(st => st.Id == id);

            if (student != null)//was an student found?
                return View(student);

            return NotFound();
        }
        [HttpPost]
        public IActionResult Delete(Student removeStudent)
        {
            Student? student = Students.FirstOrDefault(st => st.Id == removeStudent.Id);

            if (student != null)
            {
                Students.Remove(student);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return NotFound();
        }

    }

}
