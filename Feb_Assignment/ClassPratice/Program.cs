// See https://aka.ms/new-console-template for more information
using ClassPratice;

Color c = new Color(1, 1, 1, 1);
Console.WriteLine(c.GetGrayscale(c));

Ball b = new Ball(3, c);
b.Thrown();
b.Thrown();
Console.WriteLine(b.GetTimes());