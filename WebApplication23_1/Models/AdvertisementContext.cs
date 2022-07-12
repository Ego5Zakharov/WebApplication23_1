using Microsoft.EntityFrameworkCore;

namespace WebApplication23_1.Models
{
    public class AdvertisementContext:DbContext
    {
       public DbSet<Advertisement> Advertisements { get; set; }
        public AdvertisementContext(DbContextOptions<AdvertisementContext> options):base(options)
        {

        }
    }
}
