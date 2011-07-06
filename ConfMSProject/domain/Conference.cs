using System;

namespace ConfMSProject.domain
{
    public class Conference
    {
        public virtual int Id { get; set; }
        public virtual string Title { get; private set; }
        public virtual DateTime StartTime { get; private set; }
        public virtual Duration Duration { get; private set; }

        public Conference()
        {
        }

        public Conference(string title, DateTime startTime, Duration duration)
        {
            Title = title;
            StartTime = startTime;
            Duration = duration;
        }
    }
}