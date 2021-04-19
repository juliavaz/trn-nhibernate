using FluentNHibernate.Mapping;
using TrnNHibernate.Entidades;

namespace TrnNHibernate.Api.Core.Infrastructure.Maps
{
    public class ProdutoMap : ClassMap<Produto>
    {
        public ProdutoMap()
        {
            Id(x => x.Id)
                .Column("ID_PRODUTO")
                .GeneratedBy.Identity();
            Map(x => x.Nome)
                .Column("NM_PRODUTO")
                .CustomSqlType("varchar(100)");
            Map(x => x.PrecoUnitario)
                .Column("NM_PRECO_UNITARIO")
                .CustomSqlType("decimal");
            Map(x => x.QuantidadeEstoque)
                .Column("NM_QUANTIDADE_ESTOQUE")
                .CustomSqlType("int");
        }
    }
}
