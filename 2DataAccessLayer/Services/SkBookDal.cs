using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Context;
using _2DataAccessLayer.Context.Models;
using _2DataAccessLayer.Interfaces;
using _2DataAccessLayer.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Services
{
    public class SkBookDal : ISkBookDal
    {
        //private readonly TestDBEntities context;
        private DBEntitiesContext _db;
        public SkBookDal(DBEntitiesContext dbctx)
        {
            this._db = dbctx; // new TestDBEntities();
        }


        public List<SkBookModel> GetAll()
        {
            var result = _db.SkBooks.ToList();

            var returnObject = new List<SkBookModel>();
            foreach (var item in result)
            {
                returnObject.Add(item.ToSkBookModel());
            }

            return returnObject;
        }

        public SkBookModel? GetById(int SkBookId)
        {
            var result = _db.SkBooks.SingleOrDefault(x => x.SkBookId == SkBookId);
            return result?.ToSkBookModel();
        }


        public int CreateSkBook(SkBookModel SkBook)
        {
            var newSkBook = SkBook.ToSkBook();
            _db.SkBooks.Add(newSkBook);
            _db.SaveChanges();
            return newSkBook.SkBookId;
        }


        public void UpdateSkBook(SkBookModel SkBook)
        {
            var existingSkBook = _db.SkBooks
                .SingleOrDefault(x => x.SkBookId == SkBook.SkBookId);

            if (existingSkBook == null)
            {
                throw new ApplicationException($"SkBook {SkBook.SkBookId} does not exist.");
            }
            SkBook.ToSkBook(existingSkBook);

            _db.Update(existingSkBook);
            _db.SaveChanges();
        }

        public void DeleteSkBook(int SkBookId)
        {
            var efModel = _db.SkBooks.Find(SkBookId);
            _db.SkBooks.Remove(efModel);
            _db.SaveChanges();


        }

        public int CreateBook(SkBookModel SkBook)
        {
            throw new NotImplementedException();
        }

        public void UpdateBook(SkBookModel SkBook)
        {
            throw new NotImplementedException();
        }

        public void DeleteBook(int SkBookId)
        {
            throw new NotImplementedException();
        }
    }

}
