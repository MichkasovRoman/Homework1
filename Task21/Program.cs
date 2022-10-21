// Задача 21. Напишите программу, 
//которая принимает на вход 
//координаты двух точек и 
//находит расстояние 
//между ними в 3D пространстве.

double GetDistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double x = x2 - x1;
    double y = y2 - y1;
    double z = z2 - z1;
    return Math.Sqrt(x*x + y*y + z*z);
}

Console.Clear();
Console.WriteLine("Введите координаты точки A:");
Console.Write("x = ");
double X1 = double.Parse(Console.ReadLine()!);
Console.Write("y = ");
double Y1 = double.Parse(Console.ReadLine()!);
Console.Write("z = ");
double Z1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты точки B:");
Console.Write("x = ");
double X2 = double.Parse(Console.ReadLine()!);
Console.Write("y = ");
double Y2 = double.Parse(Console.ReadLine()!);
Console.Write("z = ");
double Z2 = double.Parse(Console.ReadLine()!);
Console.WriteLine($"Расстояние между введенными вами точками равно {GetDistance(X1, Y1, Z1, X2, Y2, Z2):f2}");
