using System;


namespace Package{
    class Program
    {
        static void Main(string[] args)
        {
            var fornecedor = new Fornecedor();
            Console.Write("Digite o nome do Fornecedor: ");
            fornecedor.Nome = Console.ReadLine();
            Console.Write("Agora digite o CNPJ: ");
            fornecedor.CNPJ = Console.ReadLine();
            Console.Write("Agora digite a data do Inicio do Contrato(dd/mm/yyyy): ");
            fornecedor.InicioContrato = Convert.ToDateTime(Console.ReadLine());
            var dataformatada = String.Format("{0:d/M/yyyy}",fornecedor.InicioContrato);
            Console.Write("Ok, o contrato ainda está ativo? ");
            fornecedor.VerificaContrato(false);
            Console.WriteLine("Abaixo o resultado das informações");

            Console.WriteLine("=+==+==+==+==+==+==+=");
            Console.WriteLine(fornecedor.Nome);
            Console.WriteLine(fornecedor.CNPJ);
            Console.WriteLine(dataformatada);

            Console.WriteLine(fornecedor.VerificaContrato);
            }
    }


    public class Fornecedor {
       public string Nome { get; set; }
       public string CNPJ { get; set; }
       public DateTime InicioContrato { get; set; }
       private bool _contratoAtivo;
       public bool ContratoAtivo
       {
        get { return _contratoAtivo; }
        set { _contratoAtivo = false; }
       }
       public bool VerificaContrato(bool contract){
            Console.Write("Seu contrato está ativo? ");
            var pergunta = Console.ReadLine().ToLower();
            if (pergunta != "sim"){
                Console.WriteLine("Ok, acionar setor de Compras e verificar situação!");
                return _contratoAtivo = false;
            } else{
                Console.WriteLine("Perfeito!");
                return _contratoAtivo = true;
            }
       }

        
    }

    public class Produto {
        public int NumNotaFiscal { get; set; }
        public string Nome { get; set; }
        public float preco { get; set; }
        
    }

    public class Pagamento{
        public DateTime DataPagamento { get; set; }
        public string NomeCliente { get; set; }
        private bool _maiorIdade = false;
        public bool MaiorIdade
        {
            get { return _maiorIdade; }
            set { _maiorIdade = value; }
        }
        public bool ValidaIdade(bool idade){
            var maior = Console.ReadLine().ToLower();
            if (maior != "sim"){
                Console.WriteLine("Menor de Idade não pode pegar bebidas");
                return _maiorIdade = false;
            }else{
                Console.WriteLine("Ok");
                 return _maiorIdade = true;
            }
        }
        
    }

    public class PagamentoBoleto : Pagamento{

    }


    
 
} 

