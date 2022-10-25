/*Questao 03*/
using System;

public class latasdetinta
{
    public static void Main()
    {
        double altura , largura , area , latas;
        
        Console.WriteLine ("insira altura");
        altura = double.Parse(Console.ReadLine());
        
        Console.WriteLine ("insira largura");
        largura = double.Parse(Console.ReadLine());
        
        area = altura * largura;
        latas = (area * 0.3)/2;
        
        Console.WriteLine ("Total de latas:" + latas);
    }
}
