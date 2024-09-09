using System;
using System.Text.RegularExpressions;

namespace PasswordCheck
{
    public class Passwd
    {
        public int CheckPassword(string password)
        {
            int result = 0;
            if (password.Length >= 10)
            {
                result += 1;
            }
            if (Regex.IsMatch(password, @"\d"))
            {
                result += 1;
            }
            if (Regex.IsMatch(password, @"[a-z]"))
            {
                result += 1;
            }
            if (Regex.IsMatch(password, @"[A-Z]"))
            {
                result += 1;
            }
            if (Regex.IsMatch(password, @"[^\w]"))
            {
                result += 1;
            }
            Console.WriteLine("Ваш результат:" + result);
            return result;
        }
    }
}
