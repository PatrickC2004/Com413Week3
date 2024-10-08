class Book
{
    string Title;
    string Author;
    string ISBN;
    int NoPages;

    void DisplayInfo()
    {
        Console.WriteLine("Book Information \n ------------");
        Console.WriteLine($"Book title {Title},\nBook author {Author}, \nBook ISBN {ISBN}, \nNumber of pages {NoPages}");  //print book
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        //Create new instance of book class
        Book book = new Book();
        book.Title = "C# for biggeners";
        book.Author = "Bill Gates";
        book.ISBN = "12345678";
        book.NoPages = 200;

        Book book2 = new Book();
        book2.Title = "C# Methods and Classes";
        book2.Author = "Microsoft";
        book2.ISBN = "153561";
        book2.NoPages = 50;

        book.DisplayInfo();
        book2.DisplayInfo();
       
    }
}