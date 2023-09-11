using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Context.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; } // int
        public string TeacherCode { get; set; } // nvarchar(400) 
        public string TeacherName { get; set; } // nvarchar(400)
    }
}
