using System;
namespace TechJobsOOAutoGraded6
{
	public class Location : JobField
    { 
      
        public Location(string value) : base()
        {
            Value = value;
        }

        public override bool Equals(object obj)
        {
            return obj is Location location &&
                   Id == location.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        }
    }
}

