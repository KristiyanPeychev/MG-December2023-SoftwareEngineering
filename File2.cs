public class City
{
    public string Name { get; set; }
    public string ZipCode { get; set; }
    public Country Country { get; set; }
}

public class Plovdiv: City
{
    public string OldNames { get; set; }
}
