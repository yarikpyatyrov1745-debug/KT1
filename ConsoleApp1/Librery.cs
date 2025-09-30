
public class Library : Building
{
    private List<string> _books;

    public Library(string address, List<string> books) : base(address)
    {
        _books = books ?? new List<string>();
    }

    public List<string> Books
    {
        get { return _books; }
        set { _books = value ?? new List<string>(); }
    }
}