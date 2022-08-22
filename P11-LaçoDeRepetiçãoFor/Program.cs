
using System;

class programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 11 - Laço de repetição for - calcula Poupança2");

        /*
        while (mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("no mês " + mes + " você tem R$ " + investimento);

            mes += 1;
        }
        */

        double investimento = 1000;

              // variavel + condição + contador
        for (int mes = 1; mes <= 12; mes += 1)
        {
            investimento *= 1.005;
            Console.WriteLine("no mês " + mes + " você tem R$ " + investimento);
        }


        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }

}