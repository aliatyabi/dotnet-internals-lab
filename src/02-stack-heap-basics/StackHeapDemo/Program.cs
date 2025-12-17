class Person
{
    public int Age;
}

struct Point
{
    public int X;
    public int Y;
}

class Program
{
    static void Main()
    {
        int a = 10;
        Point p = new Point { X = 1, Y = 2 };
        Person person = new Person { Age = 30 };

        Modify(a, p, person);

        Console.WriteLine($"a: {a}");
        Console.WriteLine($"p.X: {p.X}");
        Console.WriteLine($"person.Age: {person.Age}");

        Console.ReadLine();
    }

    static void Modify(int a, Point p, Person person)
    {
        a = 20;
        p.X = 100;
        person.Age = 99;
    }
}
