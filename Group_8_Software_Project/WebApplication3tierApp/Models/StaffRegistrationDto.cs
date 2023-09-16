using _1CommonInfrastructure.Models;

namespace WebApplication3tierApp.Models
{
    public class StaffRegistrationDto
    {
        public int StaffRegistrationId { get; set; } // int
        public string StaffName { get; set; } // nvarchar(400)
        public string StafRole { get; set; } // nvarchar(400)
        public string StaffID { get; set; } // nvarchar(400)
        public string StaffEmail { get; set; } // nvarchar(400)

    }

    public static class StaffRegistrationDtoMapExtensions
    {
        public static StaffRegistrationDto ToStaffRegistrationDto(this StaffRegistrationModel src)
        {
            var dst = new StaffRegistrationDto();
            dst.StaffRegistrationId = src.StaffRegistrationId;
            dst.StaffName = src.StaffName;
            dst.StafRole = src.StafRole;
            dst.StaffID = src.StaffID;
            dst.StaffEmail = src.StaffEmail;
            return dst;
        }

        public static StaffRegistrationModel ToStaffRegistrationModel(this StaffRegistrationDto src)
        {
            var dst = new StaffRegistrationModel();
            dst.StaffRegistrationId = src.StaffRegistrationId;
            dst.StaffName = src.StaffName;
            dst.StafRole = src.StafRole;
            dst.StaffID = src.StaffID;
            dst.StaffEmail = src.StaffEmail;
            return dst;
        }
    }
}
