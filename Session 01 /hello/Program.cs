namespace abc
{
    struct Point
{
    public int X;
}

Point p1 = new Point();
p1.X = 5;

Point p2 = p1;
p2.X = 10;

Console.WriteLine(p1.X);
Console.WriteLine(p2.X);
}
