using StudentsRegister.Abstract;
using StudentsRegister.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentsRegister.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private IStudentsRepository repository;
        public AdminController(IStudentsRepository repo)
        {
            repository = repo;
        }
        public ViewResult Index()
        {
            return View(repository.Students);
        }

        public ViewResult Edit(int studentID)
        {
            Student student = repository.Students.FirstOrDefault(p => p.StudentID == studentID);
            return View(student);
        }

        [HttpPost]
        public ActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                repository.SaveStudent(student);
                TempData["message"] = string.Format("{0} has been saved", student.FirstName);
                return RedirectToAction("Index");
            }
            else {
                // there is something wrong with the data values
                return View(student);
            }
        }

        public ViewResult Create()
        {
            return View("Edit", new Student());
        }

        [HttpPost]
        public ActionResult Delete(int studentID)
        {
            Student deletedProduct = repository.DeleteStudent(studentID);
            if (deletedProduct != null)
            {
                TempData["message"] = string.Format("{0} was deleted", deletedProduct.FirstName);
            }
            return RedirectToAction("Index");
        }
    }
}