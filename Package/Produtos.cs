namespace Package
{
    public class Produtos : Cadastro
    {
        public int NumNF { get; set; }
        public double valor { get; set; }

        public delegate void CadastrarProdutos();
        
    }
}