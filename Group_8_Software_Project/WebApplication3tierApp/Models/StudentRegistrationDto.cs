using _1CommonInfrastructure.Models;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3tierApp.Models
{
    public class StudentRegistrationDto
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

    public static class StudentRegistrationDtoMapExtensions
    {
        public static StudentRegistrationDto ToStudentRegistrationDto(this StudentRegistrationModel src)
        {
            var dst = new StudentRegistrationDto();
            dst.StudentRegistrationId = src.StudentRegistrationId;
            dst.StudentName = src.StudentName;
            dst.PreferredName = src.PreferredName;
            dst.StudentID = src.StudentID;
            dst.Email = src.Email;
            dst.PhoneNumber = src.PhoneNumber;
            dst.Course = src.Course;
            dst.CurrentSemester = src.CurrentSemester;
            dst.ReasonsToJoin = src.ReasonsToJoin;
            dst.ExpectedOutcome = src.ExpectedOutcome;
            dst.TimeAvailability = src.TimeAvailability;
            dst.PhotographyConsent = src.PhotographyConsent;
            return dst;
        }

        public static StudentRegistrationModel ToStudentRegistrationModel(this StudentRegistrationDto src)
        {
            var dst = new StudentRegistrationModel();
            dst.StudentRegistrationId = src.StudentRegistrationId;
            dst.StudentName = src.StudentName;
            dst.PreferredName = src.PreferredName;
            dst.StudentID = src.StudentID;
            dst.Email = src.Email;
            dst.PhoneNumber = src.PhoneNumber;
            dst.Course = src.Course;
            dst.CurrentSemester = src.CurrentSemester;
            dst.ReasonsToJoin = src.ReasonsToJoin;
            dst.ExpectedOutcome = src.ExpectedOutcome;
            dst.TimeAvailability = src.TimeAvailability;
            dst.PhotographyConsent = src.PhotographyConsent;
            return dst;
        }
    }
}
