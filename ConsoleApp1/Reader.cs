
public class Reader : Person
{
    public Reader(string firstName, string lastName, int age) : base(firstName, lastName, age)
    {
    }

    public void ReadBook(Library library, string bookName)
    {
        if (library == null)
            throw new ArgumentNullException(nameof(library));

        if (string.IsNullOrEmpty(bookName))
        {
            Console.WriteLine("Название книги не указано.");
            return;
        }

        if (library.Books.Contains(bookName))
        {
            Console.WriteLine($"Reader {FirstName} {LastName} прочитал книгу {bookName}");
        }
        else
        {
            Console.WriteLine($"Книга '{bookName}' не найдена в библиотеке.");
        }
    }
}