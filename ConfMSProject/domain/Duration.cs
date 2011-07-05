using System;

namespace ConfMSProject.domain
{
    public class Duration
    {
        public int Hours { get; set; }

        public Duration(int hours)
        {
            this.Hours = hours;
        }
    }
}