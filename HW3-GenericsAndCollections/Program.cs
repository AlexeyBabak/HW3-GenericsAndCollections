using HW3_GenericsAndCollections;

// Complex number
var complexNumber1 = new ComplexNumber<int>(2, 3);
var complexNumber2 = new ComplexNumber<int>(1, 4);

var sum = complexNumber1 + complexNumber2;
var difference = complexNumber1 - complexNumber2;

Console.WriteLine("Sum:");
sum.Print();
Console.WriteLine("Diff:");
difference.Print();

// 
