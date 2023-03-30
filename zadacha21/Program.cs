// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53




double Distance3D (int X1Coord, int Y1Coord, int Z1Coord, int X2Coord,int Y2Coord, int Z2Coord)
{
    return Math.Sqrt((X1Coord-X2Coord)*(X1Coord-X2Coord)+(Y1Coord-Y2Coord)*(Y1Coord-Y2Coord)+(Z1Coord-Z2Coord)*(Z1Coord-Z2Coord)); 
}

Console.Write("Введи  X1:");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи  Y1:");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи  Z1:");
int Z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи  X2:");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи  Y2:");
int Y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи  Z2:");
int Z2 = Convert.ToInt32(Console.ReadLine());


double result = Distance3D(X1,Y1,Z1 ,X2,Y2,Z2);
Console.Write(Math.Round(result,2,MidpointRounding.ToZero));
