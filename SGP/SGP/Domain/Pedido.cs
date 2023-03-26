using System;
using Microsoft.EntityFrameworkCore;
using SGP.ValueObjects;

namespace SGP.Domain
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string NomeProduto { get; set; }
        public FormadeEntrega formadeEntrega { get; set; }
        //Herda nome forma de pgto
        public int Pago { get; set; }
        public string FormadePgto { get; set; }
        public float Valor { get; set; }

        public static void AlterarPedido()
        {
            using var db = new Data.ApplicationContext();
            Console.WriteLine("Ok, \n Abaixo os pedidos existentes que podem ser alterados: ");
            foreach (var p in db.Pedidos)
            {
                Console.WriteLine($"[{p.Id}] " + " " + p.NomeProduto);
            }
            Console.Write("Informe o código do produto que será alterado: ");
            var pedido = db.Pedidos.Find(Int32.Parse(Console.ReadLine()));
            Console.Write("Digite o nome do Produto: ");
            var nomeProduto = Console.ReadLine();
            Console.Write("O produto foi pago? [0] SIM [1]NAO: ");
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
                pedido.NomeProduto = nomeProduto;
                pedido.Pago = pagamento;
                pedido.Valor = valor;
                pedido.FormadePgto = formadepgto;
                pedido.formadeEntrega = FormadeEntrega.Retirada;
                db.Pedidos.Update(pedido);
                db.SaveChanges();
                Console.WriteLine("Produto Alterado!");


            }
            else
            {
                pedido.NomeProduto = nomeProduto;
                pedido.Pago = pagamento;
                pedido.FormadePgto = formadepgto;
                pedido.Valor = valor;
                pedido.formadeEntrega = FormadeEntrega.Entrega;
                db.Pedidos.Update(pedido);
                db.SaveChanges();
                Console.WriteLine("Produto Alterado!");

            }


        }

        public static void RemoverPedido()
        {
            using var db = new Data.ApplicationContext();
            Console.WriteLine("Ok, \n Abaixo os pedidos existentes que podem ser alterados: ");
            foreach (var p in db.Pedidos)
            {
                Console.WriteLine($"[{p.Id}] " + " " + p.NomeProduto);
            }
            Console.Write("Informe o código do pedido a ser removido: ");
            var pedido = db.Pedidos.Find(Int32.Parse(Console.ReadLine()));
            db.Entry(pedido).State = EntityState.Deleted;
            db.SaveChanges();
            Console.WriteLine("Pedido Removido");
        }
    }
}