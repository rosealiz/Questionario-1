/*Questão 02*/
using System;

public class idade
{
    public static void Main(string[] args)
    {
        int idade , dias;
        string nome;
        
        Console.WriteLine ("insira nome");
        nome = Console.ReadLine();
        
        Console.WriteLine ("insira idade");
        idade = int.Parse(Console.ReadLine());
        
        dias = idade * 365;
        
        Console.WriteLine ("Total de dias:" + dias);
    }
}
