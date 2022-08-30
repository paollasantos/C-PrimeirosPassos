
using System;

class programa
{
    static void Main(string[] args)
    {
        // numero com ponto flutuante
        double salario = 3000.80;
        Console.WriteLine(salario);


        // conversão com numero inteiro e suporta até (32bits)
        int salarioInteiro = (int)salario;
        Console.WriteLine(salarioInteiro);


        // O long é um tipo de variável que suporta um valor maior (64bits)
        long x = 2000000000000;
        Console.WriteLine(x);


        // O short é um tipo de variável que suporta um valor menor (16bits)
        short y = 15000;
        Console.WriteLine(y);


        // nao suporta casa decimais muitos grandes
        float altura = 1.62f;
        Console.WriteLine(altura);


        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }

}
