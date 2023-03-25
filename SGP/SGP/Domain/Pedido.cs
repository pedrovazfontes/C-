using System;
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
        public bool Pago { get; set; }
        public float Valor { get; set; }
        
    }
}