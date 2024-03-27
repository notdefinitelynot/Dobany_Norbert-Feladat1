public class Allat
{
    public string Name;
    public string Species;
    public int BirthYear;
    public int Weight;

    public Allat()
    {
    }

    public Allat(string name, string species, int birthYear, int weight)
    {
        Name = name;
        Species = species;
        BirthYear = birthYear;
        Weight = weight;
    }

    public override string? ToString()
    {
        return $"Név: {Name}, Faj: {Species}, SzülÉv: {BirthYear}, Súly: {Weight}kg";
    }

    static void Main(string[] args)
    {
        Allat a = new Allat("Muci","Macska",2023,3);
        Console.WriteLine(a.ToString());
    }


}
