using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Context.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;



namespace _2DataAccessLayer.Maps
{
    public static class StudentRegistrationMapExtensions
    {
        public static StudentRegistrationModel ToStudentRegistrationModel(this StudentRegistration src)
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

        public static StudentRegistration ToStudentRegistration(this StudentRegistrationModel src, StudentRegistration dst = null)
        {
            if (dst == null)
            {
                dst = new StudentRegistration();
            }

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
