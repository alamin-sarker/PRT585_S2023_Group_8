using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Interfaces
{
    public interface ITeacherDal
    {
        // Getters
        TeacherModel? GetById(int TeacherId);
        List<TeacherModel> GetAll();

        // Actions
        int CreateTeacher(TeacherModel Teacher);
        void UpdateTeacher(TeacherModel Teacher);
        void DeleteTeacher(int TeacherId);
    }
}
