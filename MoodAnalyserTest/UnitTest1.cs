using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given_Empty_Mood_Should_Throw_MoodAnalyseException_Indicating_EmptyMood()
        {
            try
            {
                string message = " ";
                MoodAnaliser moodAnaliser = new MoodAnaliser(message);
                string mood = moodAnaliser.AnalizeMood();
            }
            catch (MoodAnalyserCustomeException e)
            {
                Assert.AreEqual("Mood should not be Empty", e.Message);
            }
        }

    }
}






