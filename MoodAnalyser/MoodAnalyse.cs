using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyzer
    {
        private string message;
        public MoodAnalyzer(string message)
        {
            this.message = message;
        }

        public string AnalizeMood()
        {
            if (this.message.Contains(""))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }

        }
    }
}


