using ClassLibraryHelper1;

namespace classlibraryTASK
{
    public class Book
    {
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public string Code { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"name - {Name}");
            Console.WriteLine($"authorname - {AuthorName}");
            Console.WriteLine($"pagecount - {PageCount}");
            Console.WriteLine($"code - {Code}");

        }

    }
}
