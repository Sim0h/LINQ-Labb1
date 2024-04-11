using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_testDB.models
{
    internal class Student
    {
        [Key]
        public int studentID { get; set; }
        public string studentName { get; set; }
        ICollection<TeacherStudentSubject> teacherSubjectStudent { get; set; }
    }
}
