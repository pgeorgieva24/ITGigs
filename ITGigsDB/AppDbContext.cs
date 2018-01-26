using Microsoft.EntityFrameworkCore;
using System;
using ITGigsDB.Helpers;
using ITGigs.UserService.Domain;

namespace ITGigsDB
{
    public class AppDbContext : DbContext
    {
        private string connection = string.Empty;

        public AppDbContext()
        {
            this.connection = Constants.GetAzureConnection();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this.connection);
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<User> Users {get;set;}


    }
}
