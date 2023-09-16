using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3BusinessLogicLayer.Interfaces
{
    public interface IStaffRegistrationService
    {
        Task<StaffRegistrationModel?> GetById(int StaffRegistrationId);
        Task<List<StaffRegistrationModel>> GetAll();

        Task<int> CreateStaffRegistration(StaffRegistrationModel StaffRegistration);
        Task UpdateStaffRegistration(StaffRegistrationModel StaffRegistration);
        Task DeleteStaffRegistration(int StaffRegistrationId);
    }
}
