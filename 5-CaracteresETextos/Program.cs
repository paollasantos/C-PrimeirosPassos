
using System;

class programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 5 - Caracteres e Textos");

        char letra = 'a'; // aspas simples no char pois estamos escrevendo uma variavel somente.
        Console.WriteLine(letra);

        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char)(86 + 1);
        Console.WriteLine(letra);

        string primeiraFrase = "Alura - Cursos de Tecnologia ";  
        Console.WriteLine(primeiraFrase + 2022);

        string vazia = "";
        Console.WriteLine(vazia);

        letra = ' ';
        // na string conseguimos deixar vazio ja no char ele precisar ter um caracter nem que seja um espaço.

        string cursos = @"Cursos disponiveis: 
- Go 
- C# 
- Python 
- Java";
        Console.WriteLine(cursos);
        // @ conseguimos fazer uma lista.

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }

}

