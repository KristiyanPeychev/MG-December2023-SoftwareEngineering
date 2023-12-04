public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Address Address { get; set; }
}

public class Asian: Person
{
    public bool StreachedEyes { get; set; }
}
    
public class BlackPerson: Person
{
    public int Chicken { get; set; }
}
