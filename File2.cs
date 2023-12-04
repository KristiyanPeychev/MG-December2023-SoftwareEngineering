public class City
{
    public string CityName { get; set; }
    public string ZipCode { get; set; }
    public Country Country { get; set; }
}

public class Plovdiv: City
{
    public string OldNames { get; set; }
}
