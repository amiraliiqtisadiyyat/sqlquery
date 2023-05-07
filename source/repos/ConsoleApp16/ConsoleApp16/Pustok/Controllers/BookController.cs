using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16.Pustok.Controllers
{
 public  class BookController:Controller
    {
        private readonly PustokContext _context;

        public BookController(PustokContext context)
        {
            _context = context;
        }
        public IActionResult GetBookDetail(int id)
        {
            Book book = _context.Books
                .Include(x => x.Author)
                .Include(x => x.BookImages)
                .FirstOrDefault(x => x.Id == id);

            if (book == null) return StatusCode(404);

            //return Json(new { book = book });
            return PartialView("_BookModalPartial", book);
        }

    }
}
