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

        public virtual Organization Organization { get; set; }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof (Speaker)) return false;
            var other = (Speaker)obj;
            return Equals(other.Name, Name) && Equals(other.Email, Email) && Equals(other.Organization, Organization);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int result = (Name != null ? Name.GetHashCode() : 0);
                result = (result*397) ^ (Email != null ? Email.GetHashCode() : 0);
                result = (result*397) ^ (Organization != null ? Organization.GetHashCode() : 0);
                return result;
            }
        }
    }
}