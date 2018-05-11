﻿using Microsoft.EntityFrameworkCore;

namespace ASPNetexercises.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public virtual DbSet<MenuItem> MenuItems { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
    }
}