using System;
namespace TechJobsOOAutoGraded6
{
	public class PositionType
	{
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        public PositionType()
        {
            Id = nextId;
            nextId++;
        }

        public PositionType(string value) : this()
        {
            Value = value;
        }

        // TODO: Task 2: Add custom Equals(), GetHashCode(), and ToString() methods.
        public override bool Equals(object obj)
        {
            if (!(obj is PositionType other))
            {
                return false;
            }
            return Id == other.Id && Value == other.Value;
        }
            public override int GetHashCode()
        {
            return HashCode.Combine(Id, Value);
        }
        public override string ToString()
        {
            return Value;
        }
    }
    
}

