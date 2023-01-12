﻿using System;
using System.Globalization;
class URI {

    static void Main(string[] args){


        string[] valores = Console.ReadLine().Split(' ');

        double A = double.Parse(valores[0]);
        double B = double.Parse(valores[1]);
        double C = double.Parse(valores[2]);

        double delta = (Math.Pow(B, 2)) - (4*A*C);

        double R1 = (-B + Math.Sqrt(delta)) / (2*A);
        double R2 = (-B - Math.Sqrt(delta)) / (2*A);
        
        if ((A != 0) && (delta > 0))
        {
        Console.WriteLine("R1 = " + R1.ToString("F5", CultureInfo.InvariantCulture));
        Console.WriteLine("R2 = " + R2.ToString("F5", CultureInfo.InvariantCulture));
        }
        else {
            Console.WriteLine("Impossivel calcular");
        }
    
    }
}