
class programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 8 - Condicionais2");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;
        bool grupo = true;
                            // &&
        if (idadeJoao >= 18 || grupo)
        {
            Console.WriteLine("pode entrar!");
        }
        else
        {
            Console.WriteLine("Não pode entar!");
        }

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}

