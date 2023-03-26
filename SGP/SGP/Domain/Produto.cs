using System;
using Microsoft.EntityFrameworkCore;

namespace SGP.Domain
{
    public class Produto
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public float ValorCompra { get; set; }
        public float ValorVenda { get; set; }
        public float Lucro { get; set; }

        public static void AlterarProduto()
        {
            using var db = new Data.ApplicationContext();
            Console.Write("Informe o código do produto que será alterado: ");
            var produto = db.Produtos.Find(Int32.Parse(Console.ReadLine()));
            Console.Write("Digite o nome do produto: ");
            var nomeProduct = Console.ReadLine();
            Console.Write("Digite a descricação da produto: ");
            var descricaoProduct = Console.ReadLine();
            Console.Write("Digite a quantidade: ");
            var qtd = Int16.Parse(Console.ReadLine());
            Console.Write("Digite o valor gasto para compra do produto: ");
            var vlrCompra = float.Parse(Console.ReadLine());
            produto.Nome = nomeProduct;
            produto.Descricao = descricaoProduct;
            produto.Quantidade = qtd;
            produto.ValorCompra = vlrCompra;
            db.Produtos.Update(produto);
            db.SaveChanges();
            Console.WriteLine("Produto Alterado!");
        }

        public static void RemoverProduto()
        {
            using var db = new Data.ApplicationContext();
            foreach (var p in db.Produtos)
            {
                Console.WriteLine($"[{p.Id}] " + " " + p.Nome);
            }
            Console.Write("Informe o código do produto que será removido: ");
            var produto = db.Produtos.Find(Int32.Parse(Console.ReadLine()));
            db.Entry(produto).State = EntityState.Deleted;
            db.SaveChanges();
            Console.WriteLine("Produto Removido");
        }
    }
}