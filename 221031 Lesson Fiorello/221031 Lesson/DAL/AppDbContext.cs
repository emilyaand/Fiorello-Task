﻿using _221031_Lesson.Models;
using Microsoft.EntityFrameworkCore;

namespace _221031_Lesson.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Category>Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductPhoto> ProductPhotos { get; set; }


    }
}
