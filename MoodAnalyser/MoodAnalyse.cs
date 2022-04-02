using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
     public class MoodAnalize
        {
            private string message;

            public MoodAnalize(string message)
            {
                this.message = message;
            }

            public string AnalizeMood()
            {
                if (this.message.Contains("SAD"))
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


