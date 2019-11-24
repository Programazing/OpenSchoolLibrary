using Microsoft.EntityFrameworkCore;
using OpenSchoolLibrary.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenSchoolLibrary.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options)
            : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<BookLoan> BookLoans { get; set; }
        public DbSet<Dewey> Deweys { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
