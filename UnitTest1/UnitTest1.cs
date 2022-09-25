using Exception_moodAnalyzer;
using System.Security.Cryptography.X509Certificates;
namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("Happy mood")]
        public void TestMethod1()
        {
            MoodAnalyse mood = new MoodAnalyse();

            string expected = "happy";
            var actual = mood.Mood("Iam in happy mood");
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }
        [TestMethod]
        [TestCategory("sad mood")]

        public void TestMethod2()
        {
            MoodAnalyse mood = new MoodAnalyse();

            string expected = "sad";
            var actual = mood.Mood("I am in sad mood");
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }

    }
}