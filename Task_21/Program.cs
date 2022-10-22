/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
//Функция
double SearchDistance(int xa, int ya, int za, int xb, int yb, int zb)
{
    double dis = Math.Sqrt((((xb-xa)*(xb-xa))+((yb-ya)*(yb-ya))+((zb-za)*(zb-za))));
    return dis;
}

//Тело программы
Console.WriteLine("Введите координаты точки А: ");
Console.Write("X: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int za = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B: ");
Console.Write("X: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int zb = Convert.ToInt32(Console.ReadLine());

//вывод результата
double distance = SearchDistance(xa, ya, za, xb, yb, zb);
Console.Write($"Расстояние между точками = {Math.Round(distance, 2, MidpointRounding.ToZero)}");