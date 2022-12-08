﻿using Microsoft.EntityFrameworkCore;
using PeopleTest.Models;

namespace PeopleTest.Data
{
    public class PeopleDbContext:DbContext
    {
        public PeopleDbContext(DbContextOptions<PeopleDbContext> options) : base(options)
        { }

        public DbSet<Person> People { get; set; } = default!;
        public DbSet<City> Cities { get; set; } = default!;
        public DbSet<Country> Countries { get; set; } = default!;
        public DbSet<Language> Languages { get; set; } = default!;
       
    }
}
