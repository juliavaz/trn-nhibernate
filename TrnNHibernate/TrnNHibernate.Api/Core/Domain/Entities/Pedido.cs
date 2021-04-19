using System;
using System.Collections.Generic;

namespace TrnNHibernate.Entidades
{
    public class Pedido
    {
        public int Id { get; protected set; }
        public DateTime Data { get; protected set; }
        public Cliente Cliente { get; protected set; }
        public IList<ItemPedido> Itens { get; protected set; }

        public Pedido(Cliente cliente)
        {
            Data = DateTime.Now;
            Cliente = cliente;
        }
    }
}
