using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libTest
{
    internal interface ILib
    {
        void AddBook(IBook book);
        void RemoveBook(IBook book);
        IBook? SearchBook(string title);
        void ShowAllBooks();
    }
}
