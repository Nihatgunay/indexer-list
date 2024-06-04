namespace ClassLibraryHelper1
{
    public class Helper
    {
        public static string CreateBookCode(string book, int number)
        {
            if (string.IsNullOrWhiteSpace(book) || number < 0)
            {
                Console.WriteLine("invalid code");
            }
            string book1 = book.Substring(0, 2).ToUpper() + number.ToString();
            return book1;
        }
    }
}
