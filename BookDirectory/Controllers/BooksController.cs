namespace BookDirectory.Controllers
{
    public class BooksController : Controller
    {
    private readonly BookRepository _repository; // Wert kann nur im Konstruktor gesetzt werden
    
    //Konstruktor initialisiert BookRepository
    public Bookscontroller()
    {
        _repository = new BookRepository();
    }

   
    public IActionResult Index()
    {
        var books = _repository.GetAllBooks();
        return View(books);
    }
    [HttpPost]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                _repository.AddBook(book);
                return RedirectToAction("Index");
            }
            return View(book);
        }

        public IActionResult Delete(int id)
        {
            _repository.DeleteBook(id);
            return RedirectToAction("Index");
        }
    }
}
    

