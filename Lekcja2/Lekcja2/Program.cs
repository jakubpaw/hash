using System;
public class Point
{
    public int x, y;
}
class Test
{
    static void Main()
    {
        Point p = null;
        Console.WriteLine(p == null);
        Console.ReadKey();
    }
}