namespace Loja.Content
{
    public class Pessoa
    {
        public Pessoa()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Email { get; set; }   
        public string Telefone { get; set; }
    }
}