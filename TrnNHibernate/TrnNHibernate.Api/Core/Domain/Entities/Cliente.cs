namespace TrnNHibernate.Entidades
{
    public class Cliente
    {

        public virtual int Id { get; protected set; }
        public virtual string Nome { get; protected set; }
        public virtual string Email { get; protected set; }
        public virtual string Senha { get; protected set; }

        public Cliente(string nome, string email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
        }
        protected Cliente() { }

        public virtual void Atualizar(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

    }
}
