namespace Loja.Content
{
    public class Cliente : Pessoa
    {
        public string CPF { get; set; }
        public static Cliente NovoCliente(){
            var cliente = new Cliente();
            Console.Write("Digite o login do cliente: ");
            cliente.Nome = Console.ReadLine();
            Console.Write("Digite o cpf do cliente: ");
            cliente.CPF  = Console.ReadLine();
            Console.Write("Digite a descrição do cliente: ");
            cliente.Descricao = Console.ReadLine();
            Console.Write("Digite o email do cliente: ");
            cliente.Email = Console.ReadLine();
            Console.Write("Por fim, digite o nº de telefone: ");
            cliente.Telefone = Console.ReadLine();
            return cliente;
        }
    }
}