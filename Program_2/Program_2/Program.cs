using System;

class Place
{
    protected string name { get; set; }
    protected double area { get; set; }
    protected int population { get; set; }

    public Place(string name, double area, int population)
    {
        this.name = name; 
        this.area = area;
        this.population = population;
    }
    public void Show()
    {
        Console.WriteLine($"Мiсце: {name}");
        Console.WriteLine($"Площа: {area}");
        Console.WriteLine($"Населення: {population}");
    }
}

class Region : Place
{
    protected int v_c { get; set; }
    public Region(string name, double area, int population, int v_c) : base(name, area, population)
    {
        this.v_c = v_c;
    }
    public new void Show()
    {
        base.Show();
        Console.WriteLine($"Мiста i села: {v_c}");
    }
}

class City : Place
{
    protected int district { get; set; }

    public City(string name, double area, int population, int district) : base(name, area, population)
    {
        this.district = district;
    }
    public new void Show()
    {
        base.Show();
        Console.WriteLine($"Кiлькiсть районiв: {district}");
    }
}

class Megapolis : City
{
    protected double population_d { get; set; }
    public Megapolis(string name, double area, int population, int district, double population_d) : base(name, area, population, district)
    {
        this.population_d = population_d;
    }

    public new void Show()
    {
        base.Show();
        Console.WriteLine($"Густота населення: {population_d}");
    }
}

class Program_2
{
    static void Main(string[] args)
    {
        Place place = new Place("Топорiвцi", 8, 4425);
        Region region = new Region("Чернiвецька Область", 8100, 922800, 409);
        City city = new City("Чернiвцi", 153, 264298, 3);
        Megapolis megapolis = new Megapolis("Київ", 839, 3000000, 10, 3516);

        place.Show();
        Console.WriteLine();

        region.Show();
        Console.WriteLine();

        city.Show();
        Console.WriteLine();

        megapolis.Show();
    }
}
