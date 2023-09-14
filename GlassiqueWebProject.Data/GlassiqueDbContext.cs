using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GlassiqueWebProject.Data
{
    public class GlassiqueDbContext : IdentityDbContext
    {
        public GlassiqueDbContext(DbContextOptions<GlassiqueDbContext> options)
            : base(options)
        {
        }
    }
}