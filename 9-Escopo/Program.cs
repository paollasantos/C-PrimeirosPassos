
class programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 9 - Escopo");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas >= 2;

        string textoAdicional;

        if(acompanhado == true)
        {
            textoAdicional = "João está acompanhado";
        }
        else
        {
            textoAdicional = "João não esta acompanhado";
        }
        
        if (idadeJoao >= 18 || acompanhado)

        {
            Console.WriteLine(textoAdicional);
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
