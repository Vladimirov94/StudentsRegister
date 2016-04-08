using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentsRegister.Entities
{
    public class StudentListViewModel
    {

        public IEnumerable<Student> Students { get; set; }

    }
}