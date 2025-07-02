using Microsoft.AspNetCore.Mvc;
using SimpleMvcApp.Models;
using System.Collections.Generic;

namespace SimpleMvcApp.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            var books = new List<Book>
            {
                new Book { Id = 1, Title = "1984", Author = "George Orwell" },
                new Book { Id = 2, Title = "Brave New World", Author = "Aldous Huxley" },
                new Book { Id = 3, Title = "Fahrenheit 451", Author = "Ray Bradbury" }
            };

            return View(books);
        }
    }
}
