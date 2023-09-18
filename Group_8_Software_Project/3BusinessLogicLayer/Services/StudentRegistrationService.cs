

using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Interfaces;
using _3BusinessLogicLayer.Interfaces;

namespace _3BusinessLogicLayer.Services
{
    public class StudentRegistrationService :  IStudentRegistrationService
    {
        private readonly IStudentRegistrationDal _StudentRegistrationDal;
        //private readonly IStudentRegistrationBalService _StudentRegistrationBalService;
        public StudentRegistrationService(IStudentRegistrationDal StudentRegistrationDal
        //ILoggingService loggingService,
        //IStudentRegistrationDal StudentRegistrationDal,
        //IAuditDal auditDal
       // IStudentRegistrationBalanceService balsvc
        ) 
        {
            _StudentRegistrationDal = StudentRegistrationDal;
            // _StudentRegistrationBalService = balsvc;
        }

        public async Task<StudentRegistrationModel?> GetById(int StudentRegistrationId)
        {           
            return _StudentRegistrationDal.GetById(StudentRegistrationId);
        }

        public async Task<List<StudentRegistrationModel>> GetAll()
        {            
            return _StudentRegistrationDal.GetAll();
        }

        public async Task<int> CreateStudentRegistration(StudentRegistrationModel StudentRegistration)
        {
            //write validations here
            var newStudentRegistrationId = _StudentRegistrationDal.CreateStudentRegistration(StudentRegistration);
            return newStudentRegistrationId;
        }

        public async Task UpdateStudentRegistration(StudentRegistrationModel StudentRegistration)
        {
            //write validations here 
            _StudentRegistrationDal.UpdateStudentRegistration(StudentRegistration);
        }

        public async Task DeleteStudentRegistration(int StudentRegistrationId)
        {            
            try
            {
                //if(balservice.getBal(StudentRegistrationId) = 0)
                _StudentRegistrationDal.DeleteStudentRegistration(StudentRegistrationId);
            }
            catch (Exception e)
            {
                //_loggingService.WriteLog(LoggingLevel.Error, "Layer", $"Error delete StudentRegistration Id:{StudentRegistrationId}. {e.Message}", e.StackTrace);
            }
        }
    }
}
