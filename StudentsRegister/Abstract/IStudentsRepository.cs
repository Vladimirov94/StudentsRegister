using StudentsRegister.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsRegister.Abstract
{
    public interface IStudentsRepository
    {

        IEnumerable<Student> Students { get; }

        void SaveStudent(Student student);

        Student DeleteStudent(int studentID);

    }
}
