﻿using System;

class Program
{
    static void Main()
    {
        double A = double.Parse(Console.ReadLine());
        double B = double.Parse(Console.ReadLine());

        double media = (A * 3.5 + B * 7.5) / 11;

        Console.WriteLine($"MEDIA = {media:F5}");
    }
}

