/*Questao 05*/
using System;

public class Tijolos
{
    public static void Main()
    {
        int alturaporta , larguraporta , alturajanela , largurajanela , areasala , areajanela , areaporta;
        int alturaparede , larguraparede , alturatijolo , larguratijolo , areaparede , areatijolo;
        int sala , totaltijolo , somaportajanela;
        
        Console.WriteLine ("altura do tijolo");
        alturatijolo = int.Parse(Console.ReadLine());
        Console.WriteLine ("largura do tijolo");
        larguratijolo = int.Parse(Console.ReadLine());
        
        Console.WriteLine ("altura da parede");
        alturaparede = int.Parse(Console.ReadLine());
        Console.WriteLine ("largura da parede");
        larguraparede = int.Parse(Console.ReadLine());
        
        Console.WriteLine ("altura da porta");
        alturaporta = int.Parse(Console.ReadLine());
        Console.WriteLine ("largura da porta");
        larguraporta = int.Parse(Console.ReadLine());
        
        Console.WriteLine ("altura da janela");
        alturajanela = int.Parse(Console.ReadLine());
        Console.WriteLine ("largura da janela");
        largurajanela = int.Parse(Console.ReadLine());
        
        areatijolo = alturatijolo * larguratijolo;
        areaparede = alturaparede * larguraparede;
        areaporta = alturaporta * larguraporta;
        areajanela = alturajanela * largurajanela;
        
        somaportajanela = areaporta + areajanela;
        sala = (areaparede * 4)- somaportajanela;
        
        totaltijolo = sala/areatijolo;
        
        Console.WriteLine ("Total de tijolos" + totaltijolo);
    }
}
