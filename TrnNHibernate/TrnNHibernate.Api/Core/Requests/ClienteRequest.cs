namespace TrnNHibernate.Api.Core.Requests
{
    public class ClienteRequest
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Email { get; set; }
        public virtual string Senha { get; set; }


    }
}
