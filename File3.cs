public class City
{
    public string NiggaName { get; set; }
    public string ZipCode { get; set; }
    public Country Country { get; set; }
}

public class Sofia: City
{
    public bool Capital { get; set; }
}
