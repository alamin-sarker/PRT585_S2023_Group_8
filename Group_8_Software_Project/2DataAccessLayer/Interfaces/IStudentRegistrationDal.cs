using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Interfaces
{
    public interface IStudentRegistrationDal
    {
        // Getters
        StudentRegistrationModel? GetById(int StudentRegistrationId);
        List<StudentRegistrationModel> GetAll();

        // Actions
        int CreateStudentRegistration(StudentRegistrationModel StudentRegistration);
        void UpdateStudentRegistration(StudentRegistrationModel StudentRegistration);
        void DeleteStudentRegistration(int StudentRegistrationId);
    }
}
