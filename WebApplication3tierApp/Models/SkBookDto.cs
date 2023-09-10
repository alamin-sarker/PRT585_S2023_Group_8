using _1CommonInfrastructure.Models;

namespace WebApplication3tierApp.Models
{
    public class SkBookDto
    {
        public int SkBookId { get; set; }
        public string SkBookName { get; set; }
        public string AurthorName { get; set; }
                        
    }

    public static class SkBookDtoMapExtensions
    {
        public static SkBookDto ToSkBookDto(this SkBookModel src)
        {
            var dst = new SkBookDto();
            dst.SkBookId = src.SkBookId;
            dst.SkBookName = src.SkBookName;
            dst.AurthorName = src.AuthorName;            
            return dst;
        }

        public static SkBookModel ToSkBookModel(this SkBookDto src)
        {
            var dst = new SkBookModel();
            dst.SkBookId = src.SkBookId;
            dst.SkBookName = src.SkBookName;   
            dst.AuthorName = src.AurthorName;            
            return dst;
        }
    }
}
