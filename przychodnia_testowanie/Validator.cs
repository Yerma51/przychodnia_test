using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace przychodnia_testowanie
{
    internal  class Validator
    {
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email) || email.Length > 255)
                return false;

            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }

        // Проверка на уникальность email
        public static bool IsUniqueEmail(string email, List<Użytkownik> usersList)
        {
            return !usersList.Any(user => user.Adres_email == email);
        }

        // Валидация номера телефона (должно быть ровно 9 цифр)
        public static bool IsValidPhoneNumber(string phone)
        {
            return Regex.IsMatch(phone, @"^\d{9}$");
        }

        // Валидация логина (не пустой + уникальный)
        public static bool IsValidLogin(string login, List<Użytkownik> usersList)
        {
            if (string.IsNullOrWhiteSpace(login)) return false;
            return !usersList.Any(user => user.Login == login);
        }

        public static bool IsValidPESEL(string pesel, string gender)
        {
            if (!Regex.IsMatch(pesel, @"^\d{11}$"))
                return false;

            // Проверка даты рождения
            string year = pesel.Substring(0, 2);
            string month = pesel.Substring(2, 2);
            string day = pesel.Substring(4, 2);

            int fullYear = GetFullYear(year, month);
            int fullMonth = GetRealMonth(month);
            int fullDay = int.Parse(day);

            if (!IsValidDate(fullYear, fullMonth, fullDay))
                return false;

            // Проверка пола (предпоследняя цифра)
            int genderDigit = int.Parse(pesel[9].ToString());
            if ((gender == "Mężczyzna" && genderDigit % 2 == 0) || (gender == "Kobieta" && genderDigit % 2 != 0))
                return false;

            // Проверка контрольной цифры
            return IsValidControlDigit(pesel);
        }

        // Проверка уникальности PESEL
        public static bool IsUniquePESEL(string pesel, List<Użytkownik> usersList)
        {
            return !usersList.Any(user => user.Pesel == pesel);
        }

        // Восстановление полного года из PESEL
        private static int GetFullYear(string year, string month)
        {
            int y = int.Parse(year);
            int m = int.Parse(month);
            if (m >= 1 && m <= 12) return 1900 + y;
            if (m >= 21 && m <= 32) return 2000 + y;
            if (m >= 41 && m <= 52) return 2100 + y;
            if (m >= 61 && m <= 72) return 2200 + y;
            if (m >= 81 && m <= 92) return 1800 + y;
            return 1900 + y;
        }

        // Преобразование месяца PESEL в настоящий месяц
        private static int GetRealMonth(string month)
        {
            int m = int.Parse(month);
            return (m % 20);
        }

        // Проверка корректности даты рождения
        private static bool IsValidDate(int year, int month, int day)
        {
            try
            {
                DateTime date = new DateTime(year, month, day);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Проверка контрольной цифры PESEL
        private static bool IsValidControlDigit(string pesel)
        {
            int[] weights = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            int sum = 0;

            for (int i = 0; i < 10; i++)
            {
                sum += weights[i] * int.Parse(pesel[i].ToString());
            }

            int controlDigit = (10 - (sum % 10)) % 10;
            return controlDigit == int.Parse(pesel[10].ToString());
        }
    }
}
