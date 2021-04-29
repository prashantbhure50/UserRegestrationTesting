using System;

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
                bool password = pattern.PasswordEmailCheck("abcdefghiA@1");
                Console.WriteLine("Password " + password);
                Console.ReadKey();           
        }
    }
}