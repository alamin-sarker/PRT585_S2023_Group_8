using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1CommonInfrastructure.Models
{
    public class StaffRegistrationModel
    {
        public int StaffRegistrationId { get; set; } // int
        public string StaffName { get; set; } // nvarchar(400)
        public string StafRole { get; set; } // nvarchar(400)
        public string StaffID { get; set; } // nvarchar(400)
        public string StaffEmail { get; set; } // nvarchar(400)

    }

}
