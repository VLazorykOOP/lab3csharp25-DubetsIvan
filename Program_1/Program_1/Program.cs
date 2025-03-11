using System;

class IsoTriangle
{
    protected int a, b, c;
    public int Side
    {
        get { return a; }
        set { a = value; }
    }

    public int Base
    {
        get { return b; }
        set { b = value; }
    }

    public int Color
    {
        get { return c; }
    }
    public IsoTriangle(int side, int base_, int color) 
    {
        a = side;
        b = base_;
        c = color;
    }
    public void getSide()
    {
        Console.WriteLine($"Бiчнi сторони: {a}");
        Console.WriteLine($"Основа: {b}");
    }
    public void getPerim()
    {
        int perim = a + a + b;
        Console.WriteLine($"Периметр: {perim}");
    }
    public void getArea()
    {
        int piv_perim = (a + a + b) / 2;
        double area = Math.Sqrt(piv_perim * (piv_perim - a) * (piv_perim - a) * (piv_perim - b));
        Console.WriteLine($"Площа: {area:F2}");
    }
    public void isRight()
    {
        if (a == b)
        {
            Console.WriteLine("Трикутник правильний");
        }
        else
        {
            Console.WriteLine("Трикутник не правильний");
        }
    }
}

class Program_1
{
    public static void Main(string[] args)
    {
       IsoTriangle[] triangles = new IsoTriangle[]
       {
            new IsoTriangle(4, 5, 1),
            new IsoTriangle(6, 6, 2),
            new IsoTriangle(3, 4, 3),
            new IsoTriangle(5, 5, 4)
       };

        foreach (var triangle in triangles)
        {
            triangle.getSide();
            triangle.getPerim();
            triangle.getArea();
            triangle.isRight();
            Console.WriteLine();
        }
    }
}
