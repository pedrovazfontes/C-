using Loja.Content;

namespace Loja;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        //var novo_cli = Cliente.NovoCliente();
        //var novo_for = Fornecedor.NovoFornecedor();
        var opcao = 0;
        while(opcao != 3){
            Console.WriteLine("[1] Cadastrar CLiente\n" +
            "[2]Cadastrar Fornecedor \n" +
            "[3] Sair"
            );
            Console.Write("Digite uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            if(opcao == 1){
                Cliente.NovoCliente();
                Console.WriteLine("Cliente Cadastrado");
                Console.WriteLine("#=#=##=#=##=#=##=#=#");
            }

            else if (opcao == 2){
                Fornecedor.NovoFornecedor();
                Console.WriteLine("Fornecedor Cadastrado");
                Console.WriteLine("#=#=##=#=##=#=##=#=#");
            }

            else{
                Console.WriteLine("Ok, até logo!");
                Console.WriteLine("#=#=##=#=##=#=##=#=#");
            }
        }
    }
}
