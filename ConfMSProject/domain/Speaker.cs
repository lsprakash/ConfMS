namespace ConfMSProject.domain
{
    public class Speaker
    {
        public Speaker()    // To satisfy NHibernate
        {
        }

        public Speaker(string name, string email)
        {
            Name = new Name(name);
            Email = new Email(email);
        }

        public virtual Name Name { get ; set; }

        public virtual Email Email { get; set; }

        public virtual string Id { get; set; }
    }
}