﻿using EmployeeCRUD.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace EmployeeCRUD.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
