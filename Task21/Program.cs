﻿Console.Clear();
Console.Write("Ведите координату x1: ");
double x1 = double.Parse (Console.ReadLine()!);
Console.Write("Ведите координату y1: ");
double y1 = double.Parse (Console.ReadLine()!);
Console.Write("Ведите координату z1: ");
double z1 = double.Parse (Console.ReadLine()!);
Console.Write("Ведите координату x2: ");
double x2 = double.Parse (Console.ReadLine()!);
Console.Write("Ведите координату y2: ");
double y2 = double.Parse (Console.ReadLine()!);
Console.Write("Ведите координату z2: ");
double z2 = double.Parse (Console.ReadLine()!);
double S = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"Расстояние равно {Math.Round(S, 2)}");