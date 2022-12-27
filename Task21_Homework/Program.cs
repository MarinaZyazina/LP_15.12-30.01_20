// Напишите программу, которая 
// принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// Примеры:
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты двух точек:");

Console.Write("XA : ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("YA : ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("ZA : ");
int za = Convert.ToInt32(Console.ReadLine());

Console.Write("XB : ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("YB : ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("ZB : ");
int zb = Convert.ToInt32(Console.ReadLine());

double ourDistance = Math.Round(Distance(xa, ya, za, xb, yb, zb), 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между двумя точками в 3D пространстве {ourDistance}");

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
    return distance;
}