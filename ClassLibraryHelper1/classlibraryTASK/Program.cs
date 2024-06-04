using System;
using ClassLibraryHelper1;

namespace classlibraryTASK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Helper helper = new Helper();
            Library library = new Library();
            Book book = new Book(); 

            Book book1 = new Book();
            book1.Name = "Programming";
            book1.AuthorName = "John Wick";
            book1.PageCount = 10;
            book1.Code = Helper.CreateBookCode("Programming", 1);           

            Book book2 = new Book();
            book2.Name = "Design";
            book2.AuthorName = "John Wash";
            book2.PageCount = 100;
            book2.Code = Helper.CreateBookCode("Design", 2); 
            
            library.AddBook(book1);
            library.AddBook(book2);

            //library.RemoveAllBooksByName(book1.Name);
            library.FindAllBooksByName("John");
            //book1.ShowInfo();
            //book2.ShowInfo();
        }
    }
}