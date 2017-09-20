using Blog.DbContext.Migrations;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System.Web.Services.Description;
using Blog.Entities;

namespace Blog.DbContext
{
    public class ApplicationDbContext : IdentityDbContext<Entities.User>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public virtual IDbSet<Post> Posts { get; set; }
    }
}
