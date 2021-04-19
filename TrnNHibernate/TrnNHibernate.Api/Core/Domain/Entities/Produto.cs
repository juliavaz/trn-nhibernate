namespace TrnNHibernate.Entidades
{
    public class Produto
    {

        public virtual int Id { get; protected set; }
        public virtual string Nome { get; protected set; }
        public virtual decimal PrecoUnitario { get; protected set; }
        public virtual int QuantidadeEstoque { get; protected set; }

        protected Produto() { }

        public Produto(string nome, decimal precoUnitario, int quantidadeEstoque)
        {
            Nome = nome;
            PrecoUnitario = precoUnitario;
            QuantidadeEstoque = quantidadeEstoque;
        }

        public virtual void Atualizar(string nome, decimal precoUnitario, int quantidadeEstoque)
        {
            Nome = nome;
            PrecoUnitario = precoUnitario;
            QuantidadeEstoque = quantidadeEstoque;
        }
    }
}
