using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Context.Models
{
    public class Student
    {
        public int StudentId { get; set; } // int
        public string StudentName { get; set; } // nvarchar(400)
        public string StudentCourse { get; set; }
        public string StudentSemester { get; set; }
        public string StudentEmail { get; set; }
        public string StudentPhoneNumber { get; set; }
    }
}
