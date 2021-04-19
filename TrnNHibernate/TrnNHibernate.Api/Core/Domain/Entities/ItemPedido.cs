namespace TrnNHibernate.Entidades
{
    public class ItemPedido
    {
        public int Id { get; protected set; }
        public Pedido Pedido { get; protected set; }
        public Produto Produto { get; protected set; }
        public int Quantidade { get; protected set; }

        public ItemPedido(Pedido pedido, Produto produto, int quantidade)
        {
            Pedido = pedido;
            Produto = produto;
            Quantidade = quantidade;
        }

    }
}
