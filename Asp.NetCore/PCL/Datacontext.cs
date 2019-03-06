﻿using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace PCL
{
    public class Datacontext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder
            optionsBuilder)
        {
            var builder = new ConfigurationBuilder().
                SetBasePath
                (Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            var configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration
                ["ConnectionStrings:DefaultConnection"]);
        }
        public DbSet<Case> Case { get; set; }
    }
}
