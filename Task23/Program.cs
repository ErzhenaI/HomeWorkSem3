﻿Console.Clear();
Console.Write("Ведите число: ");
int n = int.Parse (Console.ReadLine()!);
for (int i = 1; i <= n; i++)
Console.WriteLine($"{Math.Pow(i, 3)}");