﻿
using Microsoft.EntityFrameworkCore;
using Model;

namespace Data
{
    public class AppDBContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=C:/DataBases/Dimithrius004.db3");
        }


    }
}
