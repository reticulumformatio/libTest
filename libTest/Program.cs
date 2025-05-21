namespace libTest
{
    internal class Program
    {
        static void Main()
        {
            Lib lib = new();
            InitializeLibrary(lib);
        }
        static void InitializeLibrary(Lib library)
        {
            library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald"));
            library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee"));
            library.AddBook(new Book("1984", "George Orwell"));
            library.AddBook(new Book("The Catcher in the Rye", "J.D. Salinger"));
            library.AddBook(new Book("Pride and Prejudice", "Jane Austen"));
            library.AddBook(new Book("The Hobbit", "J.R.R. Tolkien"));
        }
    }
}
