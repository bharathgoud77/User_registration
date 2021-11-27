using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexDemo
{
    public class Patterns
    {
        public static string REGEX_PINCODE = "^[9][1][7-9]{1}[0-9]{9}$";

        public bool validatePinCode(string PinCode)
        {
            return Regex.IsMatch(PinCode, REGEX_PINCODE);
        }
    }
}