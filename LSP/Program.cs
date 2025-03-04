using LSP;
using LSP.ShapeLSP;

//Rectangle rectangle = new();
//rectangle.height = 10;
//rectangle.width = 2;

//Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");

//Square square = new();
//square.width = 10;
//Console.WriteLine($"Square Area: {rectangle.GetArea()}");

IShape rectangle = new LSP.ShapeLSP.Rectangle { width = 10, height=4};
IShape square = new LSP.ShapeLSP.Square { length = 10 };

Console.WriteLine($"Rectange Area: {rectangle.getArea()}");
Console.WriteLine($"Square Area: {square.getArea()}");