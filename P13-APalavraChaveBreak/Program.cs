﻿
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

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }

}
