using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace RegexPatternMatchingDemo
{
    class Patterns
    {
        //string Regex_Emails = "^[a-zA-Z0-9]{1,}@[A-Za-z]+[.][A-Za-z]{2,4}$";
        public static string Regex_Email = "^[a - z0 - 9A - Z] + ([._ + -][a - z0 - 9A - Z] +) *[@][a - z0 - 9A - Z] +[.][a - zA - Z]{2,3}(.[a-zA-Z]{2})? $";



        public bool validateEmail(string email)
        {
            return Regex.IsMatch(email, Regex_Email);
        }
    }
}