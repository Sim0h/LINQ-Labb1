using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_testDB.models
{
    internal class TeacherStudentSubject
    {
        [Key]
        public int id { get; set; }
        public Teacher Teacher { get; set; }
        public int teacherID { get; set; }
        public Subject Subject { get; set; }
        public int subjectID { get; set; }
        public Student Student { get; set; }
        public int studentID { get; set; }
        public Class Class { get; set; }
        public int classID { get; set; }
    }
}
