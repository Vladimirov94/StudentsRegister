using StudentsRegister.Abstract;
using StudentsRegister.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentsRegister.Controllers
{
    public class SearchController : Controller
    {

        private IStudentsRepository repository;
        public SearchController(IStudentsRepository repo)
        {
            this.repository = repo;
        }
        // GET: Search
        public ActionResult FirstName(string firstName)
        {

            StudentListViewModel model = new StudentListViewModel
            {
                Students = repository.Students.Where(p => firstName == null || p.FirstName == firstName)
            };

            return View(model);
        }

        public ActionResult LastName(string lastName)
        {

            StudentListViewModel model = new StudentListViewModel
            {
                Students = repository.Students.Where(p => lastName == null || p.LastName == lastName)
            };

            return View(model);

        }


        public ActionResult SearchID(int studentID)
        {

            StudentListViewModel model = new StudentListViewModel
            {
                Students = repository.Students.Where(p => studentID == 0 || p.StudentID == studentID)
            };

            return View(model);

        }

        public ActionResult Course(int course)
        {

            StudentListViewModel model = new StudentListViewModel
            {
                Students = repository.Students.Where(p => course == 0 || p.Course == course)
            };

            return View(model);

        }
    }
}