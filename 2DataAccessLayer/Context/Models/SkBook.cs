using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Context.Models
{
    public class SkBook
    {
        public int SkBookId { get; set; } // int
        public string SkBookName { get; set; } // nvarchar(400)
        public string AuthorName { get; set; } 
        
    }
}
