namespace TrnNHibernate.Entidades
{
    public class Produto
    {

        public int Id { get; protected set; }
        public string Nome { get; protected set; }
        public decimal PrecoUnitario { get; protected set; }
        public int QuantidadeEstoque { get; protected set; }

        public Produto(string nome, decimal precoUnitario, int quantidadeEstoque)
        {
            Nome = nome;
            PrecoUnitario = precoUnitario;
            QuantidadeEstoque = quantidadeEstoque;
        }

        public void Atualizar(string nome, decimal precoUnitario, int quantidadeEstoque)
        {
            Nome = nome;
            PrecoUnitario = precoUnitario;
            QuantidadeEstoque = quantidadeEstoque;
        }
    }
}
