using System;

Console.WriteLine("Hello!");

int number;

var result = int.TryParse("abc", out number);

if (result) {
	Console.WriteLine(number);
}
else {
	Console.WriteLine("Conversion failed...");
}

try {
var point = new Point(10, 20);
Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

point.Move(new Point(40, 60));
Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

point.Move(null);
Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
}
catch (Exception e) {
	Console.WriteLine(e);
	// throw;
}

static void UseParams() {
	var calculator = new Calculator();

	Console.WriteLine(calculator.Add(1, 2));
	Console.WriteLine(calculator.Add(new int[] {1, 2, 3, 4, 5}));
}
