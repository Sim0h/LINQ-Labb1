using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_testDB.models
{
    internal class Subject
    {
        [Key]
        public int subjectID { get; set; }
        public string subjectName { get; set; }
        ICollection<TeacherStudentSubject> teacherSubjectStudent { get; set; }
    }
}
