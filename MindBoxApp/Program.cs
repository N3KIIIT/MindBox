
using MindBoxGeometryLib.Figure;
using MindBoxGeometryLib.Interface;

public class Program
{
    public static void Main()
    {
        var list = new List<IShape>();

        list.Add(new Circle(10));
        list.Add(new Triangle(5,5,5));

        foreach (var item in list)
        {
            Console.WriteLine(item.GetArea());
        }
    }
}