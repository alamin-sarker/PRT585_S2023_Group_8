using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1CommonInfrastructure.Models
{
    public class StudentRegistrationModel
    {
        public int StudentRegistrationId { get; set; } // long
        public string StudentName { get; set; } // nvarchar(400)
        public string PreferredName { get; set; } // nvarchar(400)
        public string StudentID { get; set; } // nvarchar(400)
        public string Course { get; set; } // nvarchar(400)
        public int CurrentSemester { get; set; } // Semester number 1,2,3,4....
        public string Email { get; set; } // nvarchar(400)
        public long PhoneNumber { get; set; }
        public string ReasonsToJoin { get; set; } // nvarchar(400)
        public string ExpectedOutcome { get; set; } // nvarchar(400)
        public int TimeAvailability { get; set; } //1:yes, 0:no
        public int PhotographyConsent { get; set; } //1:yes, 0:no
        
    }

}
