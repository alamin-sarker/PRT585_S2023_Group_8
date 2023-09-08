using _1CommonInfrastructure.Models;

namespace WebApplication3tierApp.Models
{
    public class TeacherDto
    {
        public int TeacherId { get; set; }
        public string TeacherCode { get; set; }
        public string TeacherName { get; set; }
                        
    }

    public static class TeacherDtoMapExtensions
    {
        public static TeacherDto ToTeacherDto(this TeacherModel src)
        {
            var dst = new TeacherDto();
            dst.TeacherId = src.TeacherId;
            dst.TeacherCode = src.TeacherCode;
            dst.TeacherName = src.TeacherName;            
            return dst;
        }

        public static TeacherModel ToTeacherModel(this TeacherDto src)
        {
            var dst = new TeacherModel();
            dst.TeacherId = src.TeacherId;
            dst.TeacherCode = src.TeacherCode;
            dst.TeacherName = src.TeacherName;            
            return dst;
        }
    }
}
