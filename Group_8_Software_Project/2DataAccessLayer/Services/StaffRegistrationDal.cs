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
    public class StaffRegistrationDal : IStaffRegistrationDal
    {
        //private readonly TestDBEntities context;
        private DBEntitiesContext _db;
        public StaffRegistrationDal(DBEntitiesContext dbctx)
        {
            this._db = dbctx; // new TestDBEntities();
        }


        public List<StaffRegistrationModel> GetAll()
        {
            var result = _db.StaffRegistrations.ToList();

            var returnObject = new List<StaffRegistrationModel>();
            foreach (var item in result)
            {
                returnObject.Add(item.ToStaffRegistrationModel());
            }

            return returnObject;
        }

        public StaffRegistrationModel? GetById(int StaffRegistrationId)
        {
            var result = _db.StaffRegistrations.SingleOrDefault(x => x.StaffRegistrationId == StaffRegistrationId);
            return result?.ToStaffRegistrationModel();
        }


        public int CreateStaffRegistration(StaffRegistrationModel StaffRegistration)
        {
            var newStaffRegistration = StaffRegistration.ToStaffRegistration();
            _db.StaffRegistrations.Add(newStaffRegistration);
            _db.SaveChanges();
            return newStaffRegistration.StaffRegistrationId;
        }


        public void UpdateStaffRegistration(StaffRegistrationModel StaffRegistration)
        {
            var existingStaffRegistration = _db.StaffRegistrations
                .SingleOrDefault(x => x.StaffRegistrationId == StaffRegistration.StaffRegistrationId);

            if (existingStaffRegistration == null)
            {
                throw new ApplicationException($"StaffRegistration {StaffRegistration.StaffRegistrationId} does not exist.");
            }
            StaffRegistration.ToStaffRegistration(existingStaffRegistration);

            _db.Update(existingStaffRegistration);
            _db.SaveChanges();
        }

        public void DeleteStaffRegistration(int StaffRegistrationId)
        {
            var efModel = _db.StaffRegistrations.Find(StaffRegistrationId);
            _db.StaffRegistrations.Remove(efModel);
            _db.SaveChanges();


        }

    }

}
