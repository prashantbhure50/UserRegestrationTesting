using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegestrationRegex
{
    public class Pattern
    {

        private string firstNameRegex = "^[A-Z][a-zA-Z]{2,}$";
        private string lastNameRegex = "^[A-Z][a-zA-Z]{2,}$";
        private string emailRegex = "^[a-zA-Z]{3}[.]([a-zA-z]{3})[@][a-zA-Z]{2}[.][a-zA-Z]{2}[.]([a-zA-Z]{2})";
        private string mobileRegex = "^[1-9]{2,2}[ ][0-9]{10}$";
        private string passwordEmailRegex = "(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&*()_+]).{8,}$";
        public bool firstNameCheck(string input)
        {
            return Regex.IsMatch(input, firstNameRegex);
        }
        public bool lastNameCheck(string input)
        {
            return Regex.IsMatch(input, lastNameRegex);
        }
        public bool EmailCheck(string input)
        {
            return Regex.IsMatch(input, emailRegex);
        }
        public bool MobileCheck(string input)
        {
            return Regex.IsMatch(input, mobileRegex);
        }
        public bool PasswordEmailCheck(string input)
        {
            return Regex.IsMatch(input, passwordEmailRegex);
        }
    }
}