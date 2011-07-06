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

        // override object.Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Format other = (Format)obj;
            return this.Name.Equals(other.Name);
        }

// override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            throw new NotImplementedException();
            return base.GetHashCode();
        }
    }
}