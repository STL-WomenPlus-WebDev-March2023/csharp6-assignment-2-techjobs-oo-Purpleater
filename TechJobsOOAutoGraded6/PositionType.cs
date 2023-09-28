using System;
namespace TechJobsOOAutoGraded6
{
	public class PositionType : JobField
	{
        public PositionType(string value) : base()
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value;
        }

        public override bool Equals(object? obj)
        {
            return obj is PositionType type &&
                   Id == type.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }

}

