using System;

namespace ConfMSProject.domain
{
    public class Conference
    {
        public string Title { get; set; }
        public DateTime StartTime { get; set; }
        public int Duration { get; set; }

        public Conference(string title, DateTime startTime, int duration)
        {
            Title = title;
            StartTime = startTime;
            Duration = duration;
        }
    }
}