using Loja.Content;

namespace Loja;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var clientes = new List<Cliente>();
        List<string> Clientes_nome = new List<string>();
        var opcao = 0;
        while(opcao != 3){
            Console.WriteLine("[1] Cadastrar CLiente\n" +
            "[2]Cadastrar Fornecedor \n" +
            "[3] Sair"
            );
            Console.Write("Digite uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            if(opcao == 1){
                var cliente2 =Cliente.NovoCliente();
                Clientes_nome.Add(cliente2.Nome);
                Console.WriteLine("Cliente Cadastrado");
                Console.WriteLine("#=#=##=#=##=#=##=#=#");
            }

            else if (opcao == 2){
                var forne2 = Fornecedor.NovoFornecedor();
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
