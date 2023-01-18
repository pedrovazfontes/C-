namespace Loja.Content
{
    public class Fornecedor : Pessoa
    {
        public string CNPJ { get; set; }

        public static Fornecedor NovoFornecedor(){
            var fornecedor = new Fornecedor();
            Console.Write("Digite o nome do fornecedor: ");
            fornecedor.Nome = Console.ReadLine();
            Console.Write("Digite o CNPJ do fornecedor: ");
            fornecedor.CNPJ = Console.ReadLine();
            Console.WriteLine("Digite a descrição do fornecedor: ");
            fornecedor.Descricao = Console.ReadLine();
            Console.Write("Digite o email do fornecedor: ");
            fornecedor.Email = Console.ReadLine();
            Console.Write("Digite o telefone do fornecedor: ");
            fornecedor.Telefone = Console.ReadLine();
            return fornecedor;
        }
    }
}