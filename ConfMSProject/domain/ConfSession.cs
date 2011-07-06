using System;

namespace ConfMSProject.domain
{
    public class ConfSession
    {

        public ConfSession()
        {
         //Nothing to do
            
        }

        public ConfSession(string sessionTitle)
        {
            SessionTitle = new Title(sessionTitle);
        }

        public virtual Title SessionTitle { get; set; }

        public virtual string Description { get; set; }
        
        public virtual string Id { get; set; }

        public virtual Format Format { get; set; }

        // override object.Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            ConfSession other = (ConfSession) obj;
            return (this.SessionTitle.Equals(other.SessionTitle) && this.Format.Equals(other.Format));
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            return SessionTitle.GetHashCode();
        }
    }
}
