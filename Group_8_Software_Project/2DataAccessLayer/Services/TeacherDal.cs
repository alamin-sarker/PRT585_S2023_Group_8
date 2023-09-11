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
    public class TeacherDal : ITeacherDal
    {
        //private readonly TestDBEntities context;
        private DBEntitiesContext _db;
        public TeacherDal(DBEntitiesContext dbctx)
        {
            this._db = dbctx; // new TestDBEntities();
        }


        public List<TeacherModel> GetAll()
        {
            var result = _db.Teachers.ToList();

            var returnObject = new List<TeacherModel>();
            foreach (var item in result)
            {
                returnObject.Add(item.ToTeacherModel());
            }

            return returnObject;
        }

        public TeacherModel? GetById(int TeacherId)
        {
            var result = _db.Teachers.SingleOrDefault(x => x.TeacherId == TeacherId);
            return result?.ToTeacherModel();
        }


        public int CreateTeacher(TeacherModel Teacher)
        {
            var newTeacher = Teacher.ToTeacher();
            _db.Teachers.Add(newTeacher);
            _db.SaveChanges();
            return newTeacher.TeacherId;
        }


        public void UpdateTeacher(TeacherModel Teacher)
        {
            var existingTeacher = _db.Teachers
                .SingleOrDefault(x => x.TeacherId == Teacher.TeacherId);

            if (existingTeacher == null)
            {
                throw new ApplicationException($"Teacher {Teacher.TeacherId} does not exist.");
            }
            Teacher.ToTeacher(existingTeacher);

            _db.Update(existingTeacher);
            _db.SaveChanges();
        }

        public void DeleteTeacher(int TeacherId)
        {
            var efModel = _db.Teachers.Find(TeacherId);
            _db.Teachers.Remove(efModel);
            _db.SaveChanges();


        }

    }

}
