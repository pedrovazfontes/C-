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

        public static void CadastrarPedido()
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
                

            }
           
           
        }
      
    }
}