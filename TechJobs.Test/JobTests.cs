
namespace TechJobs.Tests
{
	[TestClass]
	public class JobTests
	{
        //Testing Objects

        Job job1 = new Job();

        Job job2 = new Job();

        Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

     
        //initalize your testing objects here

        [TestMethod]
        public void TestSettingJobId()
        {
            Assert.IsFalse(job1.Id == job2.Id);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {         
            Assert.AreEqual(job3.Name, "Product tester");
            
            Assert.AreEqual(job3.EmployerName.ToString(), "ACME");
            
            Assert.AreEqual(job3.EmployerLocation.ToString(), "Desert");
            Assert.AreEqual(job3.JobType.ToString(), "Quality control");
            Assert.AreEqual(job3.JobCoreCompetency.ToString(), "Persistence");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.IsFalse(Equals(job3, job4));
        }
    }

}

