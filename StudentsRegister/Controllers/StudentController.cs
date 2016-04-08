using StudentsRegister.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentsRegister.Controllers
{
    public class StudentController : Controller
    {

        private IStudentsRepository repository;
        public StudentController(IStudentsRepository repo)
        {
            this.repository = repo;
        }

        // GET: Student
        public ActionResult ListStudents()
        {
            return View(repository.Students);
        }

    }
}