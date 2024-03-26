using HW3_GenericsAndCollections;

// Complex number
Console.WriteLine("\nComplex number:");
var complexNumber1 = new ComplexNumber<int>(2, 3);
var complexNumber2 = new ComplexNumber<int>(1, 4);

var sum = complexNumber1 + complexNumber2;
var difference = complexNumber1 - complexNumber2;

Console.WriteLine("Sum:");
sum.Print();
Console.WriteLine("Diff:");
difference.Print();


// Point
Console.WriteLine("\nPoint Class:");
var myPoint = new Point(5.0, 10.0);
myPoint.PrintCoordinates();

myPoint.X = 20.0;
myPoint.Y = 30.0;
myPoint.PrintCoordinates();

Console.WriteLine("\nNext Task");

//
