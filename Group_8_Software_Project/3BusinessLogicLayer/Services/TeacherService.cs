

using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Interfaces;
using _3BusinessLogicLayer.Interfaces;

namespace _3BusinessLogicLayer.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly ITeacherDal _TeacherDal;
        //private readonly ITeacherBalService _TeacherBalService;
        public TeacherService(ITeacherDal TeacherDal
        //ILoggingService loggingService,
        //ITeacherDal TeacherDal,
        //IAuditDal auditDal
        // ITeacherBalanceService balsvc
        )
        {
            _TeacherDal = TeacherDal;
            // _TeacherBalService = balsvc;
        }

        public async Task<TeacherModel?> GetById(int TeacherId)
        {
            return _TeacherDal.GetById(TeacherId);
        }

        public async Task<List<TeacherModel>> GetAll()
        {
            return _TeacherDal.GetAll();
        }

        public async Task<int> CreateTeacher(TeacherModel Teacher)
        {
            //write validations here
            var newTeacherId = _TeacherDal.CreateTeacher(Teacher);
            return newTeacherId;
        }

        public async Task UpdateTeacher(TeacherModel Teacher)
        {
            //write validations here 
            _TeacherDal.UpdateTeacher(Teacher);
        }

        public async Task DeleteTeacher(int TeacherId)
        {
            try
            {
                //if(balservice.getBal(TeacherId) = 0)
                _TeacherDal.DeleteTeacher(TeacherId);
            }
            catch (Exception e)
            {
                //_loggingService.WriteLog(LoggingLevel.Error, "Layer", $"Error delete Teacher Id:{TeacherId}. {e.Message}", e.StackTrace);
            }
        }
    }
}
