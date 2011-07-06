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
    }
}
