Console.Write("Enter side1: ");
int side1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter side2: ");
int side2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter side31: ");
int side3 = Convert.ToInt32(Console.ReadLine());
if (side1 < side2 + side3 && side2 < side1 + side3 && side3 < side1 + side2) Console.WriteLine("Triangle");
else Console.WriteLine("Not triangle");
