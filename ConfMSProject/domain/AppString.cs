namespace ConfMSProject.domain
{
    public class AppString
    {
        public AppString()
        {
        }

        public AppString(string value)
        {
            Value = value;
        }

        public string Value { get; private set; }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Value.Equals(((AppString) obj).Value);
        }

        public override int GetHashCode()
        {
            return (Value != null ? Value.GetHashCode() : 0);
        }
    }
}