namespace ConfMSProject.domain
{
    public class Title
    {
        public virtual string Name { get; set; }

        public Title()
        {
            
        }

        public Title(string title)
        {
            this.Name = title;
        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            if (((Title)obj).Name.Equals(Name))
                return true;

            return false;
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            return 1;
        }
    }
}