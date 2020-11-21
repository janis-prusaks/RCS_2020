using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Day8
{
    class Task2
    {
        public static bool PasswordValidate(string password)
        {
            if (password.Length >= 8)
            {
                bool checkDigits = password.Any(item => char.IsDigit(item));
                bool checkLetters = password.Any(item => char.IsLetter(item));
                return checkDigits && checkLetters;
            }
            return false;
           
        }

    }
}
