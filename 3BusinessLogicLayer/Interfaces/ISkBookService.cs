using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3BusinessLogicLayer.Interfaces
{
    public interface ISkBookService
    {
        Task<SkBookModel?> GetById(int SkBookId);
        Task<List<SkBookModel>> GetAll();

        Task<int> CreateBook(SkBookModel SkBook);
        Task UpdateBook(SkBookModel SkBook);
        Task DeleteBook(int SkBookId);
    }
}
