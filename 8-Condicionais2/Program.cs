
class programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 8 - Condicionais2");

        int idadeJoao = 16;

        //int quantidadePessoas = 2;

        //bool acompanhado = quantidadePessoas >= 2;   //booleana == bool

        bool grupo = true;
                            // ou &&
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

