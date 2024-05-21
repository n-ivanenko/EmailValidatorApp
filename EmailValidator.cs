using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailValidatorApp
{
    public static class EmailValidator
    {
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email)) return false;

            int atIndex = email.IndexOf('@');
            int dotIndex = email.LastIndexOf('.');

            if (atIndex <= 0 || dotIndex <= atIndex + 1 || dotIndex == email.Length - 1) return false;

            string username = email.Substring(0, atIndex);
            string domain = email.Substring(atIndex + 1);

            if (username.Length < 1 || username.Length > 100) return false;
            if (domain.Length < 3 || domain.Length > 100) return false;

            if (email.Contains(" ")) return false;

            if (!char.IsLetterOrDigit(email[0]) || !char.IsLetterOrDigit(email[email.Length - 1])) return false;

            return true;
        }
    }
}

