using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Interfaces
{
    public interface ISkBookDal
    {
        // Getters
        SkBookModel? GetById(int SkBookId);
        List<SkBookModel> GetAll();

        // Actions
        int CreateBook(SkBookModel SkBook);
        void UpdateBook(SkBookModel SkBook);
        void DeleteBook(int SkBookId);
    }
}
