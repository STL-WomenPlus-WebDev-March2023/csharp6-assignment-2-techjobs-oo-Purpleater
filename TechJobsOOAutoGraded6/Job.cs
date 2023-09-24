using System;
namespace TechJobsOOAutoGraded6
{
	public class Job
	{
            public int Id { get; }
            private static int nextId = 1;
            public string Name { get; set; }
            public Employer EmployerName { get; set; }
            public Location EmployerLocation { get; set; }
            public PositionType JobType { get; set; }
            public CoreCompetency JobCoreCompetency { get; set; }

            // TODO: Task 3: Add the two necessary constructors.

        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Id = nextId++;
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        // TODO: Task 3: Generate Equals() and GetHashCode() methods.  

        public override bool Equals(object? obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public string CheckForEmptyField(object data)
        {
            if (data == null)
            {
                return ("Data not available");
            }
            else
            {
                return data.ToString();
            }
        }

        // TODO: Task 5: Generate custom ToString() method.
        //Until you create this method, you will not be able to print a job to the console.

        public override string ToString()
        {
            // the reason I gave the Name a single line conditional and the objects a method is because there's multiple
            // objects and only one string present in Job
            return $"\n" +
                $"ID: {Id}\n" +
                $"Name: {(string.IsNullOrEmpty(Name) ? "Data not available" : Name)}\n" +
                $"Employer: {CheckForEmptyField(EmployerName)}\n" +
                $"Location: {CheckForEmptyField(EmployerLocation)}\n" +
                $"Position Type: {CheckForEmptyField(JobType)}\n" +
                $"Core Competency: {CheckForEmptyField(JobCoreCompetency)}\n";
        }


    }
}

