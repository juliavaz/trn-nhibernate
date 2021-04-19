using FluentNHibernate.Mapping;
using TrnNHibernate.Entidades;

namespace TrnNHibernate.Api.Core.Infrastructure.Maps
{
    public class ClienteMap : ClassMap<Cliente>
    {
        public ClienteMap()
        {
            Id(x => x.Id)
                .Column("ID_CLIENTE")
                .GeneratedBy.Identity();

            Map(x => x.Nome)
                .Column("NM_CLIENTE")
                .CustomSqlType("varchar(100)");
                //.Length(100);

            Map(x => x.Email)
                .Column("TXT_EMAIL")
                .CustomSqlType("varchar(80)");
            //.Length(80);

            Map(x => x.Senha)
                .Column("TXT_SENHA")
                .CustomSqlType("varchar(1024)");
                //.Length(1024);
        }
    }
}
