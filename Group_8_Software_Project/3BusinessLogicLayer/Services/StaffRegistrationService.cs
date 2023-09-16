

using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Interfaces;
using _3BusinessLogicLayer.Interfaces;

namespace _3BusinessLogicLayer.Services
{
    public class StaffRegistrationService :  IStaffRegistrationService
    {
        private readonly IStaffRegistrationDal _StaffRegistrationDal;
        //private readonly IStaffRegistrationBalService _StaffRegistrationBalService;
        public StaffRegistrationService(IStaffRegistrationDal StaffRegistrationDal
        //ILoggingService loggingService,
        //IStaffRegistrationDal StaffRegistrationDal,
        //IAuditDal auditDal
       // IStaffRegistrationBalanceService balsvc
        ) 
        {
            _StaffRegistrationDal = StaffRegistrationDal;
            // _StaffRegistrationBalService = balsvc;
        }

        public async Task<StaffRegistrationModel?> GetById(int StaffRegistrationId)
        {           
            return _StaffRegistrationDal.GetById(StaffRegistrationId);
        }

        public async Task<List<StaffRegistrationModel>> GetAll()
        {            
            return _StaffRegistrationDal.GetAll();
        }

        public async Task<int> CreateStaffRegistration(StaffRegistrationModel StaffRegistration)
        {
            //write validations here
            var newStaffRegistrationId = _StaffRegistrationDal.CreateStaffRegistration(StaffRegistration);
            return newStaffRegistrationId;
        }

        public async Task UpdateStaffRegistration(StaffRegistrationModel StaffRegistration)
        {
            //write validations here 
            _StaffRegistrationDal.UpdateStaffRegistration(StaffRegistration);
        }

        public async Task DeleteStaffRegistration(int StaffRegistrationId)
        {            
            try
            {
                //if(balservice.getBal(StaffRegistrationId) = 0)
                _StaffRegistrationDal.DeleteStaffRegistration(StaffRegistrationId);
            }
            catch (Exception e)
            {
                //_loggingService.WriteLog(LoggingLevel.Error, "Layer", $"Error delete StaffRegistration Id:{StaffRegistrationId}. {e.Message}", e.StackTrace);
            }
        }
    }
}
