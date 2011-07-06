using System;

namespace ConfMSProject.domain
{
    public class Duration
    {
        public int Hours { get; private set; }

        public Duration(int hours)
        {
            this.Hours = hours;
        }
    }
}