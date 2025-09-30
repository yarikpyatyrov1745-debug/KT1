
public class Person
{
    private string _firstName;
    private string _lastName;
    private int _age;

    public Person(string firstName, string lastName, int age)
    {
        if (age < 0)
            throw new ArgumentException("Возраст не может быть отрицательным.");

        _firstName = firstName;
        _lastName = lastName;
        _age = age;
    }

    public string FirstName
    {
        get { return _firstName; }
    }

    public string LastName
    {
        get { return _lastName; }
    }

    public int Age
    {
        get { return _age; }
    }
}