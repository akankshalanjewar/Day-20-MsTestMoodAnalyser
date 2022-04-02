using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given_Null_Mood_Should_Throw_MoodAnalysisException()
        {
            try
            {
                string message = null;
                MoodAnaliser moodAnaliser = new MoodAnaliser(message);
                string mood = moodAnaliser.AnalizeMood();
            }
            catch (MoodAnalyserCustomeException ex)
            {
                Assert.AreEqual("Mood should not be null", ex.Message);
            }
        }

    }
} 
    




        
    

