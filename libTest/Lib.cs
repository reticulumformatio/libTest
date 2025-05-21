namespace libTest
{
    internal class Lib : ILib
    {
        private readonly List<IBook> _books = [];

        public void AddBook(IBook book)
        {
            if (string.IsNullOrWhiteSpace(book.Title) || string.IsNullOrWhiteSpace(book.Author))
                return;

            if (_books.Any(b => b.Title.Equals(book.Title, StringComparison.OrdinalIgnoreCase)))
                return;

            _books.Add(book);
        }

        public void RemoveBook(IBook book)
        {
            if (string.IsNullOrWhiteSpace(book.Title) || string.IsNullOrWhiteSpace(book.Author))
                return;

            _books.RemoveAll(b =>
                b.Title.Equals(book.Title, StringComparison.OrdinalIgnoreCase) &&
                b.Author.Equals(book.Author, StringComparison.OrdinalIgnoreCase));
        }

        public IBook? SearchBook(string title)
        {
            var book = _books.FirstOrDefault(b =>
                b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

            if (book != null)
            {
                Console.WriteLine($"Found book: {book.Title} by {book.Author}");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }

            return book;
        }

        public void ShowAllBooks()
        {
            foreach (var book in _books)
            {
                Console.WriteLine($"Book title: {book.Title}, Author: {book.Author}");
            }
        }
    }

}
