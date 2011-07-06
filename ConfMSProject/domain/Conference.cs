using System;

namespace ConfMSProject.domain
{
    public class Conference
    {
        public string Title { get; private set; }
        public DateTime StartTime { get; private set; }
        public Duration Duration { get; private set; }

        public Conference(string title, DateTime startTime, Duration duration)
        {
            Title = title;
            StartTime = startTime;
            Duration = duration;
        }
    }
}