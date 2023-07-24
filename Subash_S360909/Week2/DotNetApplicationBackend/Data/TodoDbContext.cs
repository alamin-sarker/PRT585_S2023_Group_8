using Microsoft.EntityFrameworkCore;

namespace DotNetApplicationBackend.API.Data{
    public class TodoDbContext: DbContext
    {
        public TodoDbContext(DbContextOptions options) : base(options)
        {
            
        }

    }

}