using System;
using System.Collections.Generic;
using System.Linq;
using BookListRazor.Model;
using BookListRazor.Data;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookListRazor.Pages.BookList
{
    public class CreateModel : PageModel
    {
        private readonly BookListRazorContext _db;

        public CreateModel(BookListRazorContext db)
        {
            _db = db;
        }

        public Book Book { get; set; }

        public void OnGet()
        {
        }
    }
}
