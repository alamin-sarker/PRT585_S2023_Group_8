using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3BusinessLogicLayer.Interfaces
{
    public interface IStudentRegistrationService
    {
        Task<StudentRegistrationModel?> GetById(int StudentRegistrationId);
        Task<List<StudentRegistrationModel>> GetAll();

        Task<int> CreateStudentRegistration(StudentRegistrationModel StudentRegistration);
        Task UpdateStudentRegistration(StudentRegistrationModel StudentRegistration);
        Task DeleteStudentRegistration(int StudentRegistrationId);
    }
}
