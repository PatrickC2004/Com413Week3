class Book
{
    //Properties
    string Title;
    string Author;
    string ISBN;
    int NoPages;

    //Constructor for book project
    public Book(string bookTitle, string bookAuthor,string bookISBN,int bookNoPages)
    {
        Title = bookTitle;
        Author = bookAuthor;
        ISBN = bookISBN;
        NoPages = bookNoPages;
    }


    void DisplayInfo()
    {
        Console.WriteLine("Book Information \n ------------");
        Console.WriteLine($"Book title {Title},\nBook author {Author}, \nBook ISBN {ISBN}, \nNumber of pages {NoPages}");  //print book
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        //Create new instance of book class
        Book book = new Book("C# for biggeners", "Bill Gates", "232134", 200);
        Book book2 = new Book("Game of throness", "GRR Martin", "87756267", 600);

        
        book.DisplayInfo();
        book2.DisplayInfo();
    }
}