using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_testDB.models
{
    internal class Class
    {
        [Key]
        public int classID { get; set; }
        public string className { get; set; }
        ICollection<TeacherStudentSubject> teacherSubjectStudent { get; set; }
    }
}
