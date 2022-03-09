namespace MethodOverriding;

public class Shape {
	public int Width { get; set; }
	public int Height { get; set; }
	// public Position Position { get; set; }

	public virtual void Draw()
	{
	
	}
}

public class Circle : Shape {
	public override void Draw()
	{
		Console.WriteLine("Drawing a circle");
	}
}

public class Rectangle : Shape {
	public override void Draw()
	{
		Console.WriteLine("Drawing a rectangle");
	}
}

public class Triangle : Shape
{
	public override void Draw()
	{
		Console.WriteLine("Drawing a triangle");
	}
}