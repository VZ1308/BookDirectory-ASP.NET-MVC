namespace BookDirectory.Repositories
{
    public class BookRepository
    {
        private static List<Book> books = new List<Book>();
        private static int nextId = 1;

        public List <Book> GetAllBooks() => books;

        public void AddBook(Book book) 
        {
            book.Id = nextId++;
            books.Add(book);
        }

        public void DeleteBook(int id) 
        {
            var bookToRemove = books.FirstOrDefault(b => b.Id == id);
            if (bookToRemove != null)
            {
                books.Remove(bookToRemove);
            }
        }    
    }
}
