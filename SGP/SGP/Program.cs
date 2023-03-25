using System;
using SGP.Domain;
using SGP.ValueObjects;

namespace SGP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-Vindo ao SGP");
            var opcao = 0;
            while (opcao != 10)
            {
                Console.WriteLine
                (
                 "[1] Inserir um Produto \n" +
                 "[2] Alterar Produto \n" +
                 "[3] Listar Produtos \n" +
                 "[4] Remover Produto \n" +
                 "[5] Cadastrar Formas PGTO \n" +
                 "[6] Cadastrar Pedido \n" +
                 "[7] Alterar Pedido \n" +
                 "[8] Listar Pedidos \n" +
                 "[9] Remover Pedido \n" +
                 "[10] Sair"
                );

                Console.Write("De acordo com as opções abaixo, digite a opção desejada: ");
                opcao = Int16.Parse(Console.ReadLine());
                Console.WriteLine("=#==#==#==#==#==#==#=");

                if (opcao == 1)
                {
                    InserirRegistros();
                    Console.WriteLine("=#==#==#==#==#==#==#=");
                }
                else if (opcao == 2)
                {
                    AlterarRegistros();
                    Console.WriteLine("=#==#==#==#==#==#==#=");
                }
                else if(opcao == 3)
                {
                    ListandoRegistros();
                }
                else if(opcao == 4)
                {
                    RemoverRegistros();
                }
                else if(opcao == 5){}
                else if(opcao == 6)
                {
                    InserirPedido();
                }
                else if(opcao == 7)
                {}
                else if(opcao == 8)
                {}
                else if(opcao == 9)
                {}
                else if(opcao == 10)
                {}
            }

        }

        private static void InserirRegistros()
        {
            Console.Write("Digite o id do produto: ");
            var idProduto = Int32.Parse(Console.ReadLine());
            Console.Write("Digite o nome do produto: ");
            var nomeProduct = Console.ReadLine();
            Console.Write("Digite a descricação da produto: ");
            var descricaoProduct = Console.ReadLine();
            Console.Write("Digite a quantidade: ");
            var qtd = Int16.Parse(Console.ReadLine());
            Console.Write("Digite o valor gasto para compra do produto: ");
            var vlrCompra = float.Parse(Console.ReadLine());
            var produto = new Produto
            {
                Nome = nomeProduct,
                Descricao = descricaoProduct,
                Quantidade = qtd,
                ValorCompra = vlrCompra,
            };

            using var db = new Data.ApplicationContext();
            db.Add(produto);
            var registros = db.SaveChanges();
            Console.WriteLine($"Total Registros {registros}");
        }

        public static void AlterarRegistros()
        {
            using var db = new Data.ApplicationContext();
            Console.WriteLine("Ok \n De acordo com as opções abaixo: ");
            foreach (var p in db.Produtos)
            {
                Console.WriteLine($"[{p.Id}] " + " " + p.Nome);
            }
            Produto.AlterarProduto();
            db.SaveChanges();
            Console.WriteLine("Pedido Alterado!");
            Console.WriteLine("=#==#==#==#==#==#==#=");
        }

        public static void ListandoRegistros()
        {
            using var db = new Data.ApplicationContext();
            foreach(var p in db.Produtos)
            {
                Console.WriteLine($"[{p.Id}" + " " + p.Nome);
            }
        }

        public static void RemoverRegistros()
        {
            Produto.RemoverProduto();
        }

        public static void InserirPedido()
        {
            using var db = new Data.ApplicationContext();
            Console.Write("Digite o nome do produto: ");
            var nomeProduct = Console.ReadLine();

            Console.Write("O pedido ja foi pago? 0 SIM - 1 NAO" );
            var pagamento = Int16.Parse(Console.ReadLine());
            var pago = true;
            if(pagamento == 1)
            {
                pago = false;
            }
            else{
                pago = true;
            }
            Console.Write("Digite o valor: ");
            var valor = float.Parse(Console.ReadLine());
            Console.Write("Digite a forma de entrega(Retirada ou Entrega): ");
            var formaEntrega = Console.ReadLine().ToLower();   

         
            if(formaEntrega == "retirada")
            {
                var pedido = new Pedido
                {
                    NomeProduto = nomeProduct,
                    formadeEntrega = FormadeEntrega.Entrega,
                    Pago = pago,
                    Valor = valor
                };
                db.Add(pedido);
            }
            else
            {
                var pedido = new Pedido
                {
                    NomeProduto = nomeProduct,
                    formadeEntrega = FormadeEntrega.Retirada,
                    Pago = pago,
                    Valor = valor
                };
                db.Add(pedido);
                

            }
            var registros = db.SaveChanges();
            Console.WriteLine($"Total Registros {registros}");

        }
    }
}
