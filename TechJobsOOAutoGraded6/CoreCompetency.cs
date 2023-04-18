using System;
namespace TechJobsOOAutoGraded6
{
	public class CoreCompetency
	{
        private static int nextId = 1;
        public int Id { get; }
        public string Value { get; }

        // TODO: Task 2: Change the fields to auto-implemented properties.

        
        public CoreCompetency()
        {
            Id = nextId;
            nextId++;
        }

        public CoreCompetency(string v) : this()
        {
            Value = v;
        }

        public override string ToString()
        {
            return Value;
        }

        public override bool Equals(object? obj)
        {
            return obj is CoreCompetency competency &&
                   Id == competency.Id &&
                   Value == competency.Value;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Value);
        }
    }
}

