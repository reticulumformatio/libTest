using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libTest
{
    internal class Book : IBook
    {
        public string Title { get; private set; }
        public string Author { get; private set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
         
        public void Get()
        {
            Console.WriteLine($"Pending to lib book with name {Title} by {Author}");
        }

        public void Remove()
        {
            Console.WriteLine($"{Title} has been taken by lib");
        }
    }
}
