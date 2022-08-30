
using System;

class programa
{
    static void Main(string[] args)

    // write  ----> apenas escrever na tela.
    // writeline ---> vai escrever e pula a linha.

    {
        Console.WriteLine("Projeto 2 - Criando Variaveis");

        int idade;  // declarar a variavel.

        idade = 27;

        Console.WriteLine("Minha idade é " + idade);  // ( "texto" + variavel );

        idade = 25 + 5;

        Console.WriteLine(idade);

        idade = 5 * 2 - 6;

        Console.WriteLine(idade);

        idade = (10 + 5) * 2;

        Console.WriteLine(idade);

        Console.WriteLine("Tecla enter para fechar...");
        Console.ReadLine();
    }

}


