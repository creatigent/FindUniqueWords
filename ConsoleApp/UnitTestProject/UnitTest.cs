using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        public string Paragraph { get; set; }

        [TestInitialize]
        public void init()
        {
            Paragraph = 
                "Thank you for your interest in this position!  " +
               "We believe it is important for all engineers to write code as part of the interview process, " +
               "and this exercise helps us learn about how you approach problems. Write a simple program that, " +
               "given a paragraph of text, will output the paragraph’s unique words and count of each word.  " +
               "Please include a few unit tests in your solution to demonstrate that your program works. " +
               "Don’t spend more than hour or so on this, we’re aren’t trying to ruin your weekend! " +
               "We’re not trying to trick you, so don’t overthink it.  " +
               "We are just trying to get a sense for how you approach a problem like this. " +
               "If you see obvious issues with your solution, " +
               "you can include a note that explains the issue and how you might approach solving it. " +
               "Solutions may be presented in c# or javascript, " +
               "which are the two most broadly used languages in our platform. " +
               "Feel free to send any questions to info@cnn.com " +
               "Email your solution to info@cnn.com or send a link to a github repo if you prefer";
        }

        [TestCleanup]
        public void cleanup()
        {

        }

        [TestMethod]
        public void TestMethod_FindWords()
        {
            string[] words = Paragraph.Split(null);
            Assert.IsNotNull(words);
        }

        [TestMethod]
        public void TestMethod_GroupWords()
        {
            string[] words = Paragraph.Split(null);
            var collections = words.GroupBy(x => x);
            Assert.IsNotNull(collections);
        }
    }
}
