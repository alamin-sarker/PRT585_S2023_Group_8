using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Context.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Maps
{
    public static class StaffRegistrationMapExtensions
    {
        public static StaffRegistrationModel ToStaffRegistrationModel(this StaffRegistration src)
        {
            var dst = new StaffRegistrationModel();

            dst.StaffRegistrationId = src.StaffRegistrationId;
            dst.StaffName = src.StaffName;
            dst.StafRole = src.StafRole;
            dst.StaffID = src.StaffID;
            dst.StaffEmail = src.StaffEmail; 

            return dst;
        }

        public static StaffRegistration ToStaffRegistration(this StaffRegistrationModel src, StaffRegistration dst = null)
        {
            if (dst == null)
            {
                dst = new StaffRegistration();
            }

            dst.StaffRegistrationId = src.StaffRegistrationId;
            dst.StaffName = src.StaffName;
            dst.StafRole = src.StafRole;
            dst.StaffID = src.StaffID;
            dst.StaffEmail = src.StaffEmail;

            return dst;
        }
    }
}
