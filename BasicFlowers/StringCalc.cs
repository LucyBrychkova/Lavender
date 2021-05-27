using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace BasicFlowers
{
    public class TDDCalc
    {
        public int StringCalculator(string inputFromUser)
        {
            var whatWeReturn = 0;

            if (Step5(inputFromUser))
            {
                inputFromUser.Replace("-n", ",");
                Console.WriteLine(inputFromUser);
            }

            string[] values = inputFromUser.Split(',');

            //char[] delims = new[] { '\r', '\n', ',' };
            //string[] values = inputFromUser.Split(delims);


            //string[] values = Regex.Split(inputFromUser, "[,\r\n]");
            foreach (var element in values)
            {
                int.TryParse(element, out var outputValue);
                //var outputValue = Int32.Parse(element);
                whatWeReturn += outputValue;
            }




            return whatWeReturn;
        }

        public static bool Step5(string SlashN)
        {

            if (SlashN.IndexOf("-n") >= 0)
            {
                //SlashN.Replace("\n", ",");
                return true;
            }
            else { return false; }
        }
    }
}


