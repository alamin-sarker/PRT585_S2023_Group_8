using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3BusinessLogicLayer.Interfaces
{
    public interface ITeacherService
    {
        Task<TeacherModel?> GetById(int TeacherId);
        Task<List<TeacherModel>> GetAll();

        Task<int> CreateTeacher(TeacherModel Teacher);
        Task UpdateTeacher(TeacherModel Teacher);
        Task DeleteTeacher(int TeacherId);
    }
}
