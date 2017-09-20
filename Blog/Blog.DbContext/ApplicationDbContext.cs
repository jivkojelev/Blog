using Microsoft.AspNet.Identity.EntityFramework;

namespace Blog.DbContext
{
    public class ApplicationDbContext : IdentityDbContext<Entities.ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}
