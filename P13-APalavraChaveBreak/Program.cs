
using System;

class programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 13 - A palavra chave break - Ecadeando for");

        //*
        //**
        //***
        //****
        //*****

        // variavel + condição + contador
        for (int contadorLinhas = 0; contadorLinhas < 10; contadorLinhas++)
        {
            for (int contadorColunas = 0; contadorColunas < 10; contadorColunas++)
            {
                Console.Write("*");
                if (contadorColunas >= contadorLinhas)
                    break;
            }
            Console.WriteLine();
        }

        Console.WriteLine(); 

        // Uma forma diferente de fazer o desenho de asteríscos
        for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
        {
            for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }

}
