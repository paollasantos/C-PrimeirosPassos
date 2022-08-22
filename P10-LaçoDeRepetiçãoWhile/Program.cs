
using System;

class programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 10 - Laço de repetição while - calcula Poupança");

        double investimento = 1000;

        // rendimento de 0.5% (0.005) ao mês.

        //investimento = investimento + investimento * 0.005;
        //Console.WriteLine(investimento);

        int mes = 1;

        while (mes <= 12) 
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("no mês " + mes + " você tem R$ " + investimento);

            mes += 1;
        }

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }

}
