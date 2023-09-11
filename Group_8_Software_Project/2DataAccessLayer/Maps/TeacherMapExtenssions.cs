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
    public static class TeacherMapExtensions
    {
        public static TeacherModel ToTeacherModel(this Teacher src)
        {
            var dst = new TeacherModel();

            dst.TeacherId = src.TeacherId;
            dst.TeacherName = src.TeacherName;

            return dst;
        }

        public static Teacher ToTeacher(this TeacherModel src, Teacher dst = null)
        {
            if (dst == null)
            {
                dst = new Teacher();
            }

            dst.TeacherId = src.TeacherId;
            dst.TeacherName = src.TeacherName;

            return dst;
        }
    }
}
