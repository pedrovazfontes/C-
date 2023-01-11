using System;


namespace Package{
    class Program
    {   
        public static void Main(string[] args)
        {
            var opcao = "";
            var cad_fornecedor = new Fornecedor.CadastrarFornecedor(NovoFornecedor);
            var cad_produto = new Produtos.CadastrarProdutos(NovoProduto);
        
            while(opcao != "4"){
                Console.WriteLine("\n[1] Cadastrar Fornecedor \n" +
                "[2] Cadastrar Produto \n" +
                "[3] Realizar Venda \n" +
                "[4] Sair \n" );
                Console.Write("De acordo com as opções abaixo, digite a desejada: ");
                opcao = Console.ReadLine();

                if(opcao == "1"){
                    cad_fornecedor();
                    IList<Fornecedor> cadastros = new List<Fornecedor>();
                    
                    
                }

                else if(opcao == "2"){
                    NovoProduto();
                    Console.WriteLine($"{cad_fornecedor.}");
                }

                else if(opcao == "3"){
                    Console.WriteLine("ok!");
                }
            }
            
  
        }


        public static void NovoFornecedor(){
            var fornecedor = new Fornecedor();
            Console.Write("Digite o nome do Fornecedor: ");
            fornecedor.Nome = Console.ReadLine();
            Console.Write("Agora digite o CNPJ: ");
            fornecedor.CNPJ = Console.ReadLine();
            Console.Write("Agora digite a data do Inicio do Contrato(dd/mm/yyyy): ");
            fornecedor.InicioContrato = (Console.ReadLine());
            Console.Write("Ok, o contrato ainda está ativo? ");
            fornecedor.VerificaContrato();
            Console.WriteLine("Abaixo o resultado das informações");
     
        }

        public static void NovoProduto(){
            var produto = new Produtos();
            Console.Write("Digite o nome do Produto: ");

        }

     


    
        
    }

   
 
} 

