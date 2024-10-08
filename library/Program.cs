class Book
{
    string Title;
    string Author;
    string ISBN;

    static void Main(string[] args)
    {
        //Create new instance of book class
        Book book = new Book();

        book.Title = "C# for biggeners";
        book.Author = "Bill Gates";
        book.ISBN = "12345678";

        Book book2 = new Book();

        book2.Title = "C# Methods and Classes";
        book2.Author = "Microsoft";
        book2.ISBN = "153561";

        //Output book information
        Console.WriteLine($"Book title {book.Title}, Book author {book.Author}, Book ISBN {book.ISBN}");  //print first book
        Console.WriteLine($"Book title {book2.Title}, Book author {book2.Author}, Book ISBN {book2.ISBN}"); //print second book

    }
}