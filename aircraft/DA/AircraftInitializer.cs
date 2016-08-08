using Aircraft.Models;
using System.Collections.Generic;
using System.Data.Entity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Aircraft.DA
{
    public class AircraftInitializer : DropCreateDatabaseIfModelChanges<AircraftContext>
    {
        protected override void Seed(AircraftContext context)
        {

            var paises = new List<Pais>
            {
                 new Pais { PaisId = 001, Nombre = "Costa Rica" },
                 new Pais { PaisId = 002, Nombre = "Nicaragua" },
                 new Pais { PaisId = 003, Nombre = "Panama" },
                 new Pais { PaisId = 004, Nombre = "Colombia" },
                 new Pais { PaisId = 005, Nombre = "Mexico" },
                 new Pais { PaisId = 006, Nombre = "Venezuela"},
                 new Pais { PaisId = 007, Nombre = "Peru"},
                 new Pais { PaisId = 008, Nombre = "Bolivia"}

            };
            paises.ForEach(pais => context.Pais.Add(pais));

            context.Roles.Add(new Microsoft.AspNet.Identity.EntityFramework.IdentityRole()
            {
                Name = "Administrator"
            });
            context.Roles.Add(new Microsoft.AspNet.Identity.EntityFramework.IdentityRole()
            {
                Name = "Manager"
            });
            context.Roles.Add(new Microsoft.AspNet.Identity.EntityFramework.IdentityRole()
            {
                Name = "SaleAgent"
            });

            context.Roles.Add(new Microsoft.AspNet.Identity.EntityFramework.IdentityRole()
            {
                Name = "EndUser"
            });
            var PasswordHas = new PasswordHasher();
            var UserManager = new UserManager<User>(new UserStore<User>(context));
            var admin = new User { UserName = "admin@admin.com", Email = "admin@admin.com"};
            var manager = new User { UserName = "manager@manager.com", Email = "manager@manager.com" };
            UserManager.Create(admin, "P@ssword123");
            UserManager.Create(manager, "P@ssword123");
            UserManager.AddToRole(admin.Id, "Administrator");
            UserManager.AddToRole(manager.Id, "Manager");


            
            context.SaveChanges();

        }
    }
    /*
    public class UserInit : DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {
        protected async override void Seed(ApplicationDbContext context)
        {
            context.Roles.Add(new Microsoft.AspNet.Identity.EntityFramework.IdentityRole()
            {
                Name = "Administrator"
            });
            var PasswordHas = new PasswordHasher();
            var UserManager = new UserManager<User>(new UserStore<User>(context));
            var user = new User { UserName = "admin@admin.com", Email = "admin@admin.com"};
            var result = await UserManager.CreateAsync(user, PasswordHas.HashPassword("P@ssword123"));
            UserManager.Create(user);
            UserManager.AddToRole(user.Id, "Administrator");
        }
    }
    */

}
