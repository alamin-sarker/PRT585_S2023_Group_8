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
    public class StudentRegistrationDal : IStudentRegistrationDal
    {
        //private readonly TestDBEntities context;
        private DBEntitiesContext _db;
        public StudentRegistrationDal(DBEntitiesContext dbctx)
        {
            this._db = dbctx; // new TestDBEntities();
        }


        public List<StudentRegistrationModel> GetAll()
        {
            var result = _db.StudentRegistrations.ToList();

            var returnObject = new List<StudentRegistrationModel>();
            foreach (var item in result)
            {
                returnObject.Add(item.ToStudentRegistrationModel());
            }

            return returnObject;
        }

        public StudentRegistrationModel? GetById(int StudentRegistrationId)
        {
            var result = _db.StudentRegistrations.SingleOrDefault(x => x.StudentRegistrationId == StudentRegistrationId);
            return result?.ToStudentRegistrationModel();
        }


        public int CreateStudentRegistration(StudentRegistrationModel StudentRegistration)
        {
            var newStudentRegistration = StudentRegistration.ToStudentRegistration();
            _db.StudentRegistrations.Add(newStudentRegistration);
            _db.SaveChanges();
            return newStudentRegistration.StudentRegistrationId;
        }


        public void UpdateStudentRegistration(StudentRegistrationModel StudentRegistration)
        {
            var existingStudentRegistration = _db.StudentRegistrations
                .SingleOrDefault(x => x.StudentRegistrationId == StudentRegistration.StudentRegistrationId);

            if (existingStudentRegistration == null)
            {
                throw new ApplicationException($"StudentRegistration {StudentRegistration.StudentRegistrationId} does not exist.");
            }
            StudentRegistration.ToStudentRegistration(existingStudentRegistration);

            _db.Update(existingStudentRegistration);
            _db.SaveChanges();
        }

        public void DeleteStudentRegistration(int StudentRegistrationId)
        {
            var efModel = _db.StudentRegistrations.Find(StudentRegistrationId);
            _db.StudentRegistrations.Remove(efModel);
            _db.SaveChanges();


        }

    }

}
