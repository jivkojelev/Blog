namespace Blog.DbContext.Migrations
{
    using Entities;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Blog.DbContext.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Blog.DbContext.ApplicationDbContext context)
        {
            string[] roles =
            {
                "admin",
                "registered",
                "guest"
            };

            foreach (var role in roles)
            {
                var roleStore = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
                if (!context.Roles.Any(r => r.Name == role))
                {
                    roleStore.Create(new IdentityRole(role));
                }
            }

            if (!(context.Users.Any(u => u.Email == "admin@mail.com")))
            {
                var userStore = new UserStore<User>(context);
                var userManager = new UserManager<User>(userStore);
                var userToInsert = new User { UserName = "admin", PhoneNumber = "000", Email = "admin@mail.com", isAdmin = true };
                userManager.Create(userToInsert, "std123");

                userManager.AddToRole(userToInsert.Id, "admin");
            }
        }
    }
}
