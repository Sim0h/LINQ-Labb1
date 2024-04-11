using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_testDB.models
{
    internal class Teacher
    {
        [Key]
        public int teacherID { get; set; }
        public string teacherName { get; set; }
        ICollection<TeacherStudentSubject> teacherSubjectStudent { get; set; }

    }
}
