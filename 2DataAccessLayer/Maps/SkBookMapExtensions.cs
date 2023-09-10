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
    public static class SkBookMapExtensions
    {
        public static SkBookModel ToSkBookModel(this SkBook src)
        {
            var dst = new SkBookModel();

            dst.SkBookId = src.SkBookId;
            dst.SkBookName = src.SkBookName;
            dst.AuthorName = src.AuthorName;

            return dst;
        }

        public static SkBook ToSkBook(this SkBookModel src, SkBook dst = null)
        {
            if (dst == null)
            {
                dst = new SkBook();
            }

            dst.SkBookId = src.SkBookId;
            dst.SkBookName = src.SkBookName;
            dst.AuthorName = src.AuthorName;

            return dst;
        }
    }
}
