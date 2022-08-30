
using System;

class programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 7 - Condicionais");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        if (idadeJoao >= 18)
        {
            Console.WriteLine("pode entrar!");
        }
        else
        {
            if (quantidadePessoas >= 2)
            {
                Console.WriteLine("Ele está acompanhado. Pode entrar!");
            }
            else
            {
                Console.WriteLine("Não está acompanhado. Infelizmente não pode entar!");
            }

        }

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }

}
