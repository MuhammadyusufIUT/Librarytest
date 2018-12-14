using LibraryData.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace LibraryData
{
    public class LibraryContext:DbContext
    {
        public LibraryContext(DbSet<Patron> patrons)
        {
            Patrons = patrons;
        }

        public DbSet<Patron> Patrons { get; set; }

    }
}
