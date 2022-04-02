using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnaliser
    {
        private string message;

        public MoodAnaliser(string message)
        {
            this.message = message;
        }

        public string AnalizeMood()
        {
            try
            {
                if (this.message.Equals(String.Empty))
                {
                    throw new MoodAnalyserCustomeException(MoodAnalyserCustomeException.ExceptionType.EMPTY_MESSAGE, "Mood should not be Empty");
                }

                if (this.message.Contains("SAD"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserCustomeException(MoodAnalyserCustomeException.ExceptionType.NULL_MESSAGE, "Mood should not be Null");
            }
        }

    }
}

 





