using dwCheckApi.ViewModels;
using dwCheckApi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace dwCheckApi.Controllers
{
    [Route("/[controller]")]
    public class BooksController : BaseController
    {
        private IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public string Get()
        {
            return IncorrectUseOfApi();
        }

        [HttpGet("All")]
        public JsonResult GetAll()
        {
            // This method will be computationally expensive and
            // the payload will be massive.
            // Included here for testing purposes
            var books = _bookService.GetAll();
            return Json(books.ToList());
        }

        // GET/5
        [HttpGet("Get/{id}")]
        public JsonResult GetByOrdinal(int id)
        {
            var book = _bookService.FindByOrdinal(id);
            if (book != null)
            {
                return Json(book);
            }
            return Json("Not found");
        }

        [HttpGet("Search")]
        public JsonResult Search(string searchString)
        {
            if (!string.IsNullOrWhiteSpace(searchString))
            {
                var books = _bookService.Search(searchString).ToList();
                return Json(books);
            }
            return Json("No results found");
        }
    }
}
