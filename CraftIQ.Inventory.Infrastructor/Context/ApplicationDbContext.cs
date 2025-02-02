﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CraftIQ.Inventory.Infrastructor.Context
{
    public class ApplicationDbContext  : DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options) { }

        //Db Sets


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
