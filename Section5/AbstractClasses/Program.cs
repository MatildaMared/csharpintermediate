
var circle = new Circle();
circle.Draw();

var rectangle = new Rectangle();
rectangle.Draw();

public class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a rectangle");
    }
}