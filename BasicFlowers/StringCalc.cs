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
            string MakeTheChange = inputFromUser;
            if (Step5(MakeTheChange))
            {
                //inputFromUser.Replace("\n", ",");

                
                MakeTheChange = MakeTheChange.Replace("\n", ",");

                //inputFromUser.Replace("1", ",");//this does not work at all
                //Console.WriteLine(inputFromUser);
                Console.WriteLine(MakeTheChange);
            }

            //string[] values = inputFromUser.Split(',');
            string[] values = MakeTheChange.Split(',');
            //Console.WriteLine(values);
            //char[] delims = new[] { '\r', '\n', ',' };
            //string[] values = inputFromUser.Split(delims);


            //string[] values = Regex.Split(inputFromUser, "[,\r\n]");
            foreach (var element in values)
            {
                Console.WriteLine(element);
                int.TryParse(element, out var outputValue);
                //var outputValue = Int32.Parse(element);
                whatWeReturn += outputValue;
            }




            return whatWeReturn;
        }

        public static bool Step5(string SlashN)
        {

            if (SlashN.IndexOf("\n") >= 0)
            {
                //SlashN.Replace("\n", ",");
                return true;
            }
            else { return false; }
        }
    }
}


