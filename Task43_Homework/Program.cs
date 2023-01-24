// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// Пример: b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите коэффициенты уравнений двух прямых: ");
Console.Write("K1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("B1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("K2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("B2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

if(k1 == k2 && b1 == b2) 
{
Console.WriteLine("Прямые совпадают");    
}
else if (k1 == k2 && b1 != b2)
{
Console.WriteLine("Прямые параллельны");    
}
else
{
double pointCoordinateX = Math.Round(PointCoordinateX(k1, b1, k2, b2), 1, MidpointRounding.ToZero);
double pointCoordinateY = Math.Round(PointCoordinateY(k1, b1, k2, b2), 1, MidpointRounding.ToZero);  
Console.WriteLine($"Пересечение прямых в точке: {pointCoordinateX}, {pointCoordinateY}");
}

double PointCoordinateX(double m1, double n1, double m2, double n2)
{
    double x = -(n1 - n2) / (m1 - m2);
    return x;
}

double PointCoordinateY(double m1, double n1, double m2, double n2)
{
    double y = y = m1 * (-(n1 - n2) / (m1 - m2)) + n1;
    return y;
}
