using System;

namespace ConfMSProject.domain
{
    public class Format
    {
        public string Name { get; set; }
        public Duration Duration { get; set; }

        public Format(string name, Duration duration)
        {
            Name = name;
            Duration = duration;
        }
    }
}