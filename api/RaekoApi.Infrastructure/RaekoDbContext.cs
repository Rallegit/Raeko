using Microsoft.EntityFrameworkCore;

namespace RaekoApi.Infrastructure
{
    public class RaekoDbContext : DbContext
    {
        public RaekoDbContext(DbContextOptions<RaekoDbContext> options) : base(options)
        {

        }
    }
}
