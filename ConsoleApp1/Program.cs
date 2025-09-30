
class Program
{
    static void Main(string[] args)
    {
        var books = new List<string>
        {
            "Незнайка", "Мастер и Маргарита", "Преступление и наказание", "Мальчик с пальчик"
        };

        var library = new Library("Улица Ленина, 10", books);
        var reader = new Reader("Иван", "Иванов", 25);

        reader.ReadBook(library, "1984");
        reader.ReadBook(library, "Доктор Живаго");
        reader.ReadBook(library, "Мальчик с пальчик");

        Console.ReadKey();
    }
}