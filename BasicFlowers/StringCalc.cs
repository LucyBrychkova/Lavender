using System;
using System.Collections.Generic;
using System.Text;

namespace BasicFlowers
{public class TDDCalc
    {
        public int StringCalculator(string inputFromUser)
        {
            var whatWeReturn = 0;

            string[] values = inputFromUser.Split(',');

            foreach(var element in values)
            {
                int.TryParse(element, out var outputValue);
                //var outputValue = Int32.Parse(element);
                whatWeReturn += outputValue;
            }

            



            //try letter,number,letter

            return whatWeReturn;
        }
    }
}


