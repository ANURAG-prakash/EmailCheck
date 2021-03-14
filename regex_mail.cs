using System;

namespace SimpleMailCheck
{
    class regex_mail
    {
        static void Main(string[] args)
        {
            Program patterns = new Program();
            Console.WriteLine(patterns.validateEmail("9@gmail.com"));
            Console.ReadKey();

        }
    }
}
