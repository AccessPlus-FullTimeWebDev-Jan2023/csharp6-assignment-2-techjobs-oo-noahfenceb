
using System;

namespace TechJobs.Tests
{
	[TestClass]
	public class JobTests
	{
        Job job1 = new Job();

        Job job2 = new Job();

        Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();
            int difference = job2.Id - job1.Id;
            Assert.AreEqual(1, difference);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {

            Job job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.AreEqual("Product tester", job.Name);
            Assert.AreEqual("ACME", job.EmployerName.Value);
            Assert.AreEqual("Desert", job.EmployerLocation.Value);
            Assert.AreEqual("Quality control", job.JobType.Value);
            Assert.AreEqual("Persistence", job.JobCoreCompetency.Value);

        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("QUality control"), new CoreCompetency("Persistence"));
            Assert.IsFalse(job1.Equals(job2));
        }
        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine()
        {
            Job job = new Job();
            string result = job.ToString();
            Assert.IsTrue(result.StartsWith("\n") && result.EndsWith("\n"));
        }

        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData()
        {
            Job job = new Job("Software Engineer", new Employer("Amazon"), new Location("Seattle"), new PositionType("Full-time"), new CoreCompetency("Java"));
            string result = job.ToString();
            Assert.IsTrue(result.Contains("ID:") && result.Contains("Name:") && result.Contains("Employer:") && result.Contains("Position Type:") && result.Contains("Core Competency:"));
            Assert.IsTrue(result.Contains("Software Engineer") && result.Contains("Amazon") && result.Contains("Seattle") && result.Contains("Full-time") && result.Contains("Java"));
        }
        [TestMethod]
        public void TestToStringHandlesEmptyField()
        {
            Job job = new Job();
            string result = job.ToString();
            string expected = $"{Environment.NewLine} ID:{job.Id}{Environment.NewLine} Name: Data not Available {Environment.NewLine} Employer: Data not Available {Environment.NewLine} Position Type: Data not Available {Environment.NewLine} Core Competency: Data not Available";
             
        }
    }
}

