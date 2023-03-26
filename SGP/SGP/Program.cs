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
            while (opcao != 9)
            {
                Console.WriteLine
                (
                 "[1] Inserir um Produto \n" +
                 "[2] Alterar Produto \n" +
                 "[3] Listar Produtos \n" +
                 "[4] Remover Produto \n" +
                 "[5] Cadastrar Pedido \n" +
                 "[6] Alterar Pedido \n" +
                 "[7] Listar Pedidos \n" +
                 "[8] Remover Pedido \n" +
                 "[9] Sair"
                );

                Console.Write("De acordo com as opções abaixo, digite a opção desejada: ");
                opcao = Int16.Parse(Console.ReadLine());
                Console.WriteLine("=#==#==#==#==#==#==#=");

                if (opcao == 1) { InserirRegistros(); Console.WriteLine("=#==#==#==#==#==#==#="); }
                else if (opcao == 2) { AlterarRegistros(); Console.WriteLine("=#==#==#==#==#==#==#="); }
                else if (opcao == 3) { ListandoRegistros(); }
                else if (opcao == 4) { RemoverRegistros(); }
                else if (opcao == 5) { InserirPedido(); }
                else if (opcao == 6) { AlterarPedido(); }
                else if (opcao == 7) { ListarPedidos(); }
                else if (opcao == 8) { RemoverPedido(); }
                else if (opcao == 9) { Console.WriteLine("Ok,\n obrigado por usar o sistema"); }
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
            Console.WriteLine("=#==#==#==#==#==#==#=");
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
            foreach (var p in db.Produtos)
            {
                Console.WriteLine($"[{p.Id}]" + " " + p.Nome);
            }
            Console.WriteLine("=#==#==#==#==#==#==#=");
        }

        public static void RemoverRegistros()
        {
            Produto.RemoverProduto();
            Console.WriteLine("=#==#==#==#==#==#==#=");
        }

        public static void InserirPedido()
        {
            using var db = new Data.ApplicationContext();
            Console.Write("Digite o nome do produto: ");
            var nomeProduct = Console.ReadLine();

            Console.Write("O pedido ja foi pago? 0 SIM - 1 NAO: ");
            var pagamento = Int16.Parse(Console.ReadLine());

            Console.Write("Digite a forma de pagamento \n" +
            "Dinheiro \n" +
            "Cartão Crédito \n" +
            "Cartão Débito \n" +
            "Pix \n" +
            "Nenhuma: ");
            var formadepgto = Console.ReadLine();

            Console.Write("Digite o valor: ");
            var valor = float.Parse(Console.ReadLine());
            Console.Write("Digite a forma de entrega(Retirada ou Entrega): ");
            var formaEntrega = Console.ReadLine().ToLower();


            if (formaEntrega == "retirada")
            {
                var pedido = new Pedido
                {
                    NomeProduto = nomeProduct,
                    formadeEntrega = FormadeEntrega.Entrega,
                    Pago = pagamento,
                    FormadePgto = formadepgto,
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
                    Pago = pagamento,
                    FormadePgto = formadepgto,
                    Valor = valor
                };
                db.Add(pedido);


            }
            var registros = db.SaveChanges();
            Console.WriteLine($"Total Registros {registros}");
            Console.WriteLine("=#==#==#==#==#==#==#=");

        }
        public static void CadastrarPgto()
        {
            using var db = new Data.ApplicationContext();

            Console.Write("Digite o nome da forma de pgto: ");
            var nome = Console.ReadLine();
            var formapgto = new FormadePgto
            {
                Nome = nome
            };
            db.Add(formapgto);
            var registros = db.SaveChanges();
            Console.WriteLine($"Total Registros {registros}");
            Console.WriteLine("=#==#==#==#==#==#==#=");
        }

        public static void AlterarPedido()
        {

            Pedido.AlterarPedido();
            Console.WriteLine("=#==#==#==#==#==#==#=");
        }

        public static void ListarPedidos()
        {
            using var db = new Data.ApplicationContext();
            foreach (var p in db.Pedidos)
            {
                Console.WriteLine($"[{p.Id}] " + " " + p.NomeProduto + " " + "R$ " + p.Valor);
            }
            Console.WriteLine("=#==#==#==#==#==#==#=");
        }

        public static void RemoverPedido()
        {
            Pedido.RemoverPedido();
            Console.WriteLine("=#==#==#==#==#==#==#=");
        }

    }
}
