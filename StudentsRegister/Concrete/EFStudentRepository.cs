using StudentsRegister.Abstract;
using StudentsRegister.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentsRegister.Concrete
{
    public class EFStudentRepository : IStudentsRepository
    {

        private EFDbContext context = new EFDbContext();
        public IEnumerable<Student> Students
        {
            get { return context.Students; }
        }

        public Student DeleteStudent(int studentID)
        {
            Student dbEntry = context.Students.Find(studentID);
            if (dbEntry != null)
            {
                context.Students.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }

        public void SaveStudent(Student student)
        {
            if (student.StudentID == 0)
            {
                context.Students.Add(student);
            }
            else {
                Student dbEntry = context.Students.Find(student.StudentID);
                if (dbEntry != null)
                {
                    dbEntry.FirstName = student.FirstName;
                    dbEntry.LastName = student.LastName;
                    dbEntry.Course = student.Course;
                    dbEntry.Speciality = student.Speciality;
                }
            }
            context.SaveChanges();
        }
    }
}