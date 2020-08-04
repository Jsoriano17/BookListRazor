using System;
using Microsoft.EntityFrameworkCore;
using BookListRazor.Model;
namespace BookListRazor.Data
{
    public class BookListRazorContext : DbContext
    {
        public BookListRazorContext(DbContextOptions<BookListRazorContext> options) : base(options)
        {

        }

        public DbSet<Book> Book { get; set; }
    }
}
