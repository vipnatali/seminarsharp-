// Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в3D
// пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату xa: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату ya: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату za: ");
int za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату xb: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату yb: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату zb: ");
int zb = Convert.ToInt32(Console.ReadLine());

double Distance(int xa, int ya, int za,
                int xb, int yb, int zb)
{
    double x1 = (xa - xb ) * (xa - xb );
    double y1 = (ya - yb ) * (ya - yb );
    double z1 = (za - zb ) * (za - zb );
    double result = Math.Sqrt(x1 + y1 + z1);
    return result;
}

double res = Distance(xa, ya, za, xb, yb, zb);
double resRound = Math.Round(res, 2, MidpointRounding.ToZero);
Console.WriteLine(resRound);