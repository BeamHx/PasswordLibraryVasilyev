using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PasswordLibraryVasilyev
{
    public class PasswordClass
    {
        /// <summary>
        /// Метод, который проводит проверку над паролем и проверяет его на сложность
        /// </summary>
        /// <param name="password">В качестве параметра передается строка - пароль</param>
        /// <returns>Метод возвращает целое число, соответствующее сложности пароля</returns>
        public static int PasswordStrengthCheker(string password)
        {
            int scores = 0;

            if (Regex.Match(password, @"(?=.{7,}$)").Success)
            {
                scores++;
            }
            if (Regex.Match(password, @"(?=.*\d)").Success)
            {
                scores++;
            }
            if (Regex.Match(password, @"(?=.*[a-z])").Success)
            {
                scores++;
            }
            if (Regex.Match(password, @"(?=.*[A-Z])").Success)
            {
                scores++;
            }
            if (Regex.Match(password, @"[!\@\#\$\%\^\&\*\(\)\-\+\=\'\/\.\,\;\|]").Success)
            {
                scores++;
            }

            if (Regex.Match(password, @"(?=.*[а-я])|(?=.*[А-Я])").Success)
            {
                throw new Exception("");
            }



            return scores;

        }
    }
}
