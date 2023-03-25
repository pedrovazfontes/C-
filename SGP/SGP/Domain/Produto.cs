using System;

namespace SGP.Domain
{
    public class Produto
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Nome { get; set; }SGP/Domain/Produto.cs
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public float ValorCompra { get; set; }
        public float ValorVenda { get; set ; }
        public float Lucro { get; set; } 

    }
}