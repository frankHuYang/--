using algorithim.array;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var a = new ArrayList(5);
        a.Add(1);
        a.Add(2);
        a.Add(3);
        a.Add(4);
        a.Add(5);
        Console.WriteLine(a);
        a.Delete(4);
        Console.WriteLine(a);

        a.Delete(5);
        Console.WriteLine(a);

        a.Delete(3);
        Console.WriteLine(a);
        a.Delete(1);
        Console.WriteLine(a);
        a.Delete(2);
        Console.WriteLine(a);
        a.Delete(6);
        Console.WriteLine(a);
        a.Delete(6);
        Console.WriteLine(a.FindIndex(1));
        Console.WriteLine(a.FindIndex(6));
        a.Add(1);
        a.Add(2);
        a.Add(3);
        a.Add(4);
        a.Add(5);
        a.Add(6);
        a.Add(7);
        a.Add(8);
        a.Add(9);
        a.Add(10);
        Console.WriteLine(a);
        Console.WriteLine(a.FindIndex(5));
        Console.WriteLine(a.FindIndex(10));
        Console.WriteLine(a.FindIndex(11));
        a.Insert(4, 5);
        Console.WriteLine(a);
    }
}

