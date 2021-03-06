using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using TestingRegex;

namespace UserRegestrationRegex
{
    public class Pattern
    {

        private const string FIRST_NAME_REGEX = "^[A-Z][a-zA-Z]{2,}$";
        private const string LAST_NAME_REGEX = "^[A-Z][a-zA-Z]{2,}$";
        private const string EMAIL_REGEX = "^[a-zA-Z]{3}[.]([a-zA-z]{3})[@][a-zA-Z]{2}[.][a-zA-Z]{2}[.]([a-zA-Z]{2})";
        private const string MOBILE_REGEX = "^[1-9]{2,2}[ ][0-9]{10}$";
        private const string PASSWORD_EMAIL_REGEX = "(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&*()_+]).{8,}$";


        public Func<string, bool> firstNameCheck = (firstName) =>
         {
             if (firstName == string.Empty)
             {
                 throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "Null Value");
             }
             else
             {
                 return Regex.IsMatch(firstName, FIRST_NAME_REGEX);
             }
         };
        public Func<string,bool> lastNameCheck =(lastName) =>
        {
            if (lastName == string.Empty)
            {
                throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "Null Value");
            }
            else
            {
                return Regex.IsMatch(lastName, LAST_NAME_REGEX);
            }
        };
        public Func<string, bool> EmailCheck = (email) =>
         {
             if (email == string.Empty)
             {
                 throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "Null Value");
             }
             else
             {
                 return Regex.IsMatch(email, EMAIL_REGEX);
             }
         };
        public Func<string, bool> MobileCheck = (mobileNo) =>
        {
            if (mobileNo == string.Empty)
            {
                throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "Null Value");
            }
            else
            {
                return Regex.IsMatch(mobileNo, MOBILE_REGEX);
            }
        };
        public Func<string, bool> PasswordEmailCheck = (emailPassword)=>
        {
            if (emailPassword == string.Empty)
            {
                throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "Null Value");
            }
            else
            {
                return Regex.IsMatch(emailPassword, PASSWORD_EMAIL_REGEX);
            }
        };
    }
}