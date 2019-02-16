using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment12
{
    public static class StringValidator
    {
        public static bool IsEmail(this String Email)
        {
            
            const string Pattern = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            // Regular expression explained below. 
            /*
             * We have 3 parts in a email. 
             * ^- represents start of the character
             * first part ([a-zA-Z0-9_\-\.]+)
             * which means we are allowing characters a-z , 0-9 numbers , special/other character such as _-. . 
             * We have should atleast those character one more more time
             * @ is the mandatory character in the string
             * in the second part  ((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+)) number allowed 1 to 3 times
             * [a-zA-Z0-9\-]+ represents character from : a to z , 0 to 9 and - allowed 0 or more time  and [a-z0-9])?.) part tells 0 to 9 , a to z and - allowed one or more time. 
             * Similar to that number also allowed in the Email.
             * Third part represents ([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)
             * we should have only one sequence of characters a to z or A to Z , 0 to 9 one to 3 times. 
             * $- end of the string
             * */

            Regex re = new Regex(Pattern);
            if (re.IsMatch(Email))
                return (true);
            else
                return (false);
        }
    }
}
