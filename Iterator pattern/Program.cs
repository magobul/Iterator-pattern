using Iterator_pattern;

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();

        library.AddBook(new Book("Война и мир", "Лев Толстой", 1869));
        library.AddBook(new Book("Преступление и наказание", "Фёдор Достоевский", 1866));
        library.AddBook(new Book("Анна Каренина", "Лев Толстой", 1877));

        foreach (var book in library)
        {
            Console.WriteLine(book);
        }
    }
}