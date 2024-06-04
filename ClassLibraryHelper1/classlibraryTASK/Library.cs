using System.Diagnostics;
using System.Xml.Linq;

namespace classlibraryTASK
{
    public class Library
    {
        List<Book> _books = new List<Book>();
        public Book this[int index]
        {
            get { return _books[index]; }
        }

        public void AddBook(Book book)
        {
            _books.Add(book);
        }
        public Book FindAllBooksByName(string value)
        {
            List<Book> _newbooks = new List<Book>(0);
            foreach (var book in _books)
            {
                if (book.Name == value)
                {
                    return book;
                }
            }
            return null;
        }
        public Book FindBookByCode(string code)
        {
            foreach (var book in _books)
            {
                if (book.Code == code)
                    return book;                
            }
            return null;
        }
        public Book RemoveAllBooksByName(string name)
        {
            foreach (var item in _books)
            {
                if (item.Name.Trim().ToLower() == name.Trim().ToLower())
                {
                    _books.Remove(item);
                }
            }
            return null; ;
            
        }
        public Book SearchBooks(string value)
        {
            foreach (var item in _books)
            {
                if (item.Code.Trim().ToLower() == value.Trim().ToLower() || 
                    item.Name.Trim().ToLower() == value.Trim().ToLower() || 
                    item.AuthorName.Trim().ToLower() == value.Trim().ToLower() || 
                    item.PageCount == int.Parse(value))
                {
                    Console.WriteLine($"Name - {item.Name}  AuthorName - {item.AuthorName}  " +
                        $"Code - {item.Code}  Pagecount - {item.PageCount}");
                }
            }
            return null;
        }
        //public Book FindAllBooksByPageCountRange(int minpagecount, int maxpagecount)
        //{
        //    if (minpagecount < 0 || minpagecount > maxpagecount)
        //    {
        //        Console.WriteLine("Invalid min max page count");
        //    }

        //    return null;
        //}
        public Book RemoveBookByCode(string value)
        {
            foreach (var book in _books)
            {
                if (book.Code == value)
                    _books.Remove(book);
            }
            return null;
        }
        
    }
}
