using System;

namespace ConfMSProject.domain
{
    public class Duration
    {
        public virtual int Hours { get; private set; }

        public Duration()
        {
        }

        public Duration(int hours)
        {
            this.Hours = hours;
        }
    }
}