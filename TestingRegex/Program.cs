using System;
using System.Collections;
using System.Collections.Generic;
using TestingRegex;

namespace UserRegestrationRegex
{
    public class Program
    {
        static void Main(string[] args)
        {
                Pattern pattern = new Pattern();
                Console.WriteLine("Welcome to User Registration Problem");
                bool firstName = pattern.firstNameCheck("Prashant");
                Console.WriteLine("FirstName " + firstName);
                bool lastName = pattern.lastNameCheck("Bhure");
                Console.WriteLine("LastName " + lastName);
                bool email = pattern.EmailCheck("abc.xyz@bl.co.in");
                Console.WriteLine("Email " + email);
                bool mobile = pattern.MobileCheck("91 9876543210");
                Console.WriteLine("Mobile " + mobile);
                bool password = pattern.PasswordEmailCheck("Alokbhure1@");
                Console.WriteLine("Password " + password);

            //multiple Email
            ArrayList multipleEmail = new ArrayList();
            multipleEmail.Add("abc@yahoo.com");
            multipleEmail.Add("abc-100@yahoo.com");
            multipleEmail.Add("abc.100@yahoo.com");
            multipleEmail.Add("abc@1.com");
            multipleEmail.Add("abc-100@abc.net");
            multipleEmail.Add("abc@gmal.com.co");
            multipleEmail.Add("abc+100@gmail.com");
            foreach(string elements in multipleEmail)
            {
                bool checkEmail = pattern.EmailCheck(elements);
                Console.WriteLine("Multiple Email Check" + checkEmail);
            }


            //Reflection
            Console.WriteLine("Welcome to Reflection Test");
                Reflection.ReflectionTest();
                Console.ReadKey();           
        }
    }
}