/*Questão 01*/
using System;

public class gasolina
{
    public static void Main(string[] args)
    {
        float valor1 , valor2 , valor3 , pmedio;
        string nome;
        
        Console.WriteLine ("insira seu nome");
        nome = Console.ReadLine();
        
        Console.WriteLine ("insira valor1");
        valor1 = float.Parse(Console.ReadLine());
        
        Console.WriteLine ("insira valor2");
        valor2 = float.Parse(Console.ReadLine());
        
        Console.WriteLine ("insira valor3");
        valor3 = float.Parse(Console.ReadLine());
        
        pmedio = (valor1 + valor2 + valor3)/3;
        
        Console.WriteLine ("preco medio:" + pmedio);
    }
}
