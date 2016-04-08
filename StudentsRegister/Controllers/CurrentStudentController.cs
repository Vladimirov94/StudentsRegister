using StudentsRegister.Abstract;
using StudentsRegister.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentsRegister.Controllers
{
    public class CurrentStudentController : Controller
    {
        private IStudentsRepository repository;
        public CurrentStudentController(IStudentsRepository repo)
        {
            repository = repo;
        }
        // GET: CurrentStudent
        public ActionResult ListCurrent(int studentID)
        {
            StudentListViewModel model = new StudentListViewModel
            {
                Students = repository.Students.Where(p => studentID == 0 || p.StudentID == studentID)
            };

            return View(model);
        }
    }
}