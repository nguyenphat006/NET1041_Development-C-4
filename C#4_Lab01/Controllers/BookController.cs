using C_4_Lab01.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;


public class BookController : Controller
{
    private readonly List<Book> _books;

    public BookController(IOptions<AppSettings> appSettings)
    {
        _books = appSettings.Value.Book;
    }

    public IActionResult Index()
    {
        return View(_books); // Truyền dữ liệu vào view
    }
}
