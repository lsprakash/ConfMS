using System;

namespace ConfMSProject.domain
{
    public class ConfSession
    {

        public ConfSession(string sessionTitle)
        {
            SessionTitle = new Title(sessionTitle);
        }

        public Title SessionTitle { get; set; }

        public string Description { get; set; }
    }
}
