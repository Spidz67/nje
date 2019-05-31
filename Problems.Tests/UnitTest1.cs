using NUnit.Framework;
using Problems;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Program p = new Program();
            string result = p.Prefix("hello");
            string result1 = p.Prefix("");
            string result2 = p.Prefix("what ... did you say?? ");
            Assert.AreEqual(result,"5,1:hello");
            Assert.AreEqual(result1,"0,0:");
            Assert.AreEqual(result2,"23,5:what ... did you say?? ");

        }

    }
}