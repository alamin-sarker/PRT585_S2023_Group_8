using _1CommonInfrastructure.Models;

namespace WebApplication3tierApp.Models
{
    public class StudentDto
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentCourse { get; set; }
        public string StudentSemester { get; set; }
        public string StudentEmail { get; set; }
        public string StudentPhoneNumber { get; set; }

    }

    public static class StudentDtoMapExtensions
    {
        public static StudentDto ToStudentDto(this StudentModel src)
        {
            var dst = new StudentDto();

            dst.StudentId = src.StudentId;
            dst.StudentName = src.StudentName;
            dst.StudentCourse = src.StudentCourse;
            dst.StudentSemester = src.StudentSemester;
            dst.StudentEmail = src.StudentEmail;
            dst.StudentPhoneNumber = src.StudentPhoneNumber;

            return dst;
        }

        public static StudentModel ToStudentModel(this StudentDto src)
        {
            var dst = new StudentModel();

            dst.StudentId = src.StudentId;
            dst.StudentName = src.StudentName;
            dst.StudentCourse = src.StudentCourse;
            dst.StudentSemester = src.StudentSemester;
            dst.StudentEmail = src.StudentEmail;
            dst.StudentPhoneNumber = src.StudentPhoneNumber;

            return dst;
        }
    }
}
