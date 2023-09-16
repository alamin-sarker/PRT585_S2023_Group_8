using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Interfaces
{
    public interface IStaffRegistrationDal
    {
        // Getters
        StaffRegistrationModel? GetById(int StaffRegistrationId);
        List<StaffRegistrationModel> GetAll();

        // Actions
        int CreateStaffRegistration(StaffRegistrationModel StaffRegistration);
        void UpdateStaffRegistration(StaffRegistrationModel StaffRegistration);
        void DeleteStaffRegistration(int StaffRegistrationId);
    }
}
