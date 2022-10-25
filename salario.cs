using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string nome;
        double inscricao , horasextras , horasnormais , salariobruto , inss , salarioliquido;
        
        Console.WriteLine ("Digite seu nome");
        nome = Console.ReadLine();
        
        Console.WriteLine ("Digite seu numero de inscricao");
        inscricao = double.Parse(Console.ReadLine());
        
        horasnormais = 1200;
        horasextras = 0.3 * horasnormais;
        salariobruto = (horasnormais + horasextras) * 1.3;
        inss = 0.11 * salariobruto;
        salarioliquido = salariobruto - inss;
        
        Console.WriteLine ("Numero de inscricao: " + inscricao);
        Console.WriteLine ("Nome do funcionario: " + nome);
        Console.WriteLine ("Salario horas normais: " + horasnormais);
        Console.WriteLine ("Salario horas extras: " + horasextras);
        Console.WriteLine ("Dedução INSS: " + inss);
        Console.WriteLine ("Salario liquido: " + salarioliquido);
    }
}
