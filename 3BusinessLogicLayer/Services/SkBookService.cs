

using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Interfaces;
using _3BusinessLogicLayer.Interfaces;

namespace _3BusinessLogicLayer.Services
{
    public class SkBookService :  ISkBookService
    {
        private readonly ISkBookDal _SkBookDal;
        //private readonly ISkBookBalService _SkBookBalService;
        public SkBookService(ISkBookDal SkBookDal
        //ILoggingService loggingService,
        //ISkBookDal SkBookDal,
        //IAuditDal auditDal
       // ISkBookBalanceService balsvc
        ) 
        {
            _SkBookDal = SkBookDal;
            // _SkBookBalService = balsvc;
        }

        public async Task<SkBookModel?> GetById(int SkBookId)
        {           
            return _SkBookDal.GetById(SkBookId);
        }

        public async Task<List<SkBookModel>> GetAll()
        {            
            return _SkBookDal.GetAll();
        }

        public async Task<int> CreateBook(SkBookModel SkBook)
        {
            //write validations here
            var newSkBookId = _SkBookDal.CreateBook(SkBook);
            return newSkBookId;
        }

        public async Task UpdateBook(SkBookModel SkBook)
        {
            //write validations here 
            _SkBookDal.UpdateBook(SkBook);
        }

        public async Task DeleteBook(int SkBookId)
        {            
            try
            {
                //if(balservice.getBal(SkBookId) = 0)
                _SkBookDal.DeleteBook(SkBookId);
            }
            catch (Exception e)
            {
                //_loggingService.WriteLog(LoggingLevel.Error, "Layer", $"Error delete SkBook Id:{SkBookId}. {e.Message}", e.StackTrace);
            }
        }
    }
}
