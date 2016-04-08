using StudentsRegister.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentsRegister.Controllers
{
    public class NavController : Controller
    {

        private IStudentsRepository repository;
        public NavController(IStudentsRepository repo)
        {
            repository = repo;
        }
        // GET: Nav
        public PartialViewResult Search()
        {
            return PartialView();
        }


    }
}