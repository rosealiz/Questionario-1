/*Questao 04*/
using System;

public class segundos
{
    public static void Main()
    {
        int horas , minutos , segundos , hs , ms , total;
        
        Console.WriteLine ("insira horas");
        horas = int.Parse(Console.ReadLine());
        
        Console.WriteLine ("insira minutos");
        minutos = int.Parse(Console.ReadLine());
        
        Console.WriteLine ("insira segundos");
        segundos = int.Parse(Console.ReadLine());
        
        hs = horas * 3600;
        ms = minutos * 60;
        total = ms + hs + segundos;
        
        Console.WriteLine("total de segundos:" + total);
    }
}
