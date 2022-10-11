using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

internal class program{

 private static void Main()
 {
Console.WriteLine("Circle or triangle or rectangle?");
string answer = Console.ReadLine();
if (answer == "rectangle" || answer =="Rectangle")
{
 Console.WriteLine("height: ");
 int height = int.Parse(Console.ReadLine());
 Console.WriteLine("Width: ");
 int Width = int.Parse(Console.ReadLine());
Rectangle rectangle = new Rectangle();
rectangle.Area(Result: height * Width);
rectangle.Circumferance(Result: height*2 + Width*2);
}
else if ( answer == "triangle" || answer == "Triangle")
{
Console.WriteLine("height: ");
 int height = int.Parse(Console.ReadLine());
 Console.WriteLine("Width: ");
 int Width = int.Parse(Console.ReadLine());
Triangle triangle = new Triangle();
triangle.Area(Result: height * Width/2);
triangle.Circumferance(Result:(int)Math.Sqrt(Width*Width + height*height) + Width + height );
}
else if (answer == "Circle"|| answer == "circle" )
{
 Console.WriteLine("Radie: ");
 int Radie = int.Parse(Console.ReadLine());
 Circle circle = new Circle();
 circle.Area(Result: Radie*Radie*(int)Math.PI);
 circle.Circumferance(Result: 2*(int)Math.PI*Radie);
}
else {
    Console.WriteLine("Please write either circle or rectangle or triangle");
}

}
}
