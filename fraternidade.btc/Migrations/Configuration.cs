namespace fraternidade.btc.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using fraternidade.btc.DAL;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<fraternidadeDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(fraternidadeDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            Usuario u = new Usuario();
            u.Email = "andre@gmail.com";
            u.Senha = "andreandre";
            u.Nome = "André Bernardino Cardoso";
            u.IDUsuario = 1;
            context.Usuarios.Add(u);
        }
    }
}
