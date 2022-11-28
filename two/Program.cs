// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: 
// каждая сторона треугольника меньше суммы двух других сторон.

Console.Write("Enter side1: ");
int side1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter side2: ");
int side2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter side31: ");
int side3 = Convert.ToInt32(Console.ReadLine());
if (side1 < side2 + side3 && side2 < side1 + side3 && side3 < side1 + side2) Console.WriteLine("Треугольник");
else Console.WriteLine("Не является треугольником");
