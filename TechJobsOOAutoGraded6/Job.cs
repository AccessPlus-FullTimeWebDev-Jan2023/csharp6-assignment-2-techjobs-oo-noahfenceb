using System;
namespace TechJobsOOAutoGraded6
{
	public class Job
	{
        

            public int Id { get; }
            private static int nextId = 1;
        public object JobLocation;

        public string Name { get; set; }
            public Employer EmployerName { get; set; }
            public Location EmployerLocation { get; set; }
            public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }


        public Job()
        {
            Id = nextId;
            nextId++;
        }
        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency; 

        }


        

        public override string ToString()
        {
            string emptyField = "Data not available";
            string idString = $"ID: {Id}";
            string nameString = $"Name: {(String.IsNullOrEmpty(Name) ? emptyField : Name)}";
            string employerString = $"Employer: {(EmployerName == null || String.IsNullOrEmpty(EmployerName.Value) ? emptyField : EmployerName.Value)}";
            string locationString = $"Location: {(EmployerLocation == null || String.IsNullOrEmpty(EmployerLocation.Value) ? emptyField : EmployerLocation.Value)}";
            string jobTypeString = $"Position Type: {(JobType == null || String.IsNullOrEmpty(JobType.Value) ? emptyField : JobType.Value)}";
            string jobCCString = $"Core Competency: {(JobCoreCompetency == null || String.IsNullOrEmpty(JobCoreCompetency.Value) ? emptyField : JobCoreCompetency.Value)}";
            //Console.WriteLine($"\n{idString}\n{nameString}\n{employerString}\n{locationString}\n{jobTypeString}\n{jobCCString}\n");
            return $"{Environment.NewLine}{idString}{Environment.NewLine}{nameString}{Environment.NewLine}{employerString}{Environment.NewLine}{locationString}{Environment.NewLine}{jobTypeString}{Environment.NewLine}{jobCCString}{Environment.NewLine}";

        }

        public override bool Equals(object? obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }



        // TODO: Task 3: Add the two necessary constructors.

        // TODO: Task 4: Generate Equals() and GetHashCode() methods.  

        // TODO: Task 5: Generate custom ToString() method.
        //Until you create this method, you will not be able to print a job to the console.



    }
}

