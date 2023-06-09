﻿using Microsoft.EntityFrameworkCore;
using ViewBagViewDataViewTemp.Models;

namespace ViewBagViewDataViewTemp.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        { 
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
