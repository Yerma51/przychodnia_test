using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace przychodnia_testowanie
{
    internal class Validator
    {
        // Sprawdzanie poprawności adresu e-mail
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email) || email.Length > 255)
                return false;

            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }

        // Sprawdzanie unikalności adresu e-mail
        public static bool IsUniqueEmail(string email, List<Użytkownik> usersList, Użytkownik aktualnyUżytkownik)
        {
            return !usersList.Any(user =>
                user.Adres_email == email &&
                (aktualnyUżytkownik == null || user.Id != aktualnyUżytkownik.Id)
            );
        }



        // Walidacja numeru telefonu (musi zawierać dokładnie 9 cyfr)
        public static bool IsValidPhoneNumber(string phone)
        {
            return Regex.IsMatch(phone, @"^\d{9}$");
        }

        // Walidacja loginu (pole nie może być puste i musi być unikalne)
       
        public static bool IsValidLogin(string login, List<Użytkownik> usersList, Użytkownik aktualnyUżytkownik)
        {
            if (string.IsNullOrWhiteSpace(login)) return false;

            return !usersList.Any(user =>
                user.Login == login &&
                (aktualnyUżytkownik == null || user.Id != aktualnyUżytkownik.Id)
            );
        }



        // Walidacja numeru PESEL
        public static bool IsValidPESEL(string pesel, string gender)
        {
            if (!Regex.IsMatch(pesel, @"^\d{11}$"))
                return false;

            // Sprawdzanie daty urodzenia
            string yearPart = pesel.Substring(0, 2);
            string monthPart = pesel.Substring(2, 2);
            string dayPart = pesel.Substring(4, 2);

            int fullYear = GetFullYear(yearPart, monthPart);
            int fullMonth = GetRealMonth(monthPart);
            int fullDay;

            if (!int.TryParse(dayPart, out fullDay) || fullDay < 1 || fullMonth < 1 || fullMonth > 12)
                return false;

            if (!IsValidDate(fullYear, fullMonth, fullDay))
                return false;

            DateTime birthDate = new DateTime(fullYear, fullMonth, fullDay);
            if (birthDate > DateTime.Now)
                return false;

            int genderDigit = int.Parse(pesel[9].ToString());
            if ((gender == "Mężczyzna" && genderDigit % 2 == 0) || (gender == "Kobieta" && genderDigit % 2 != 0))
                return false;

            return IsValidControlDigit(pesel);
        }

        // Sprawdzanie unikalności numeru PESEL
        public static bool CzyUnikalnyPesel(string pesel, List<Użytkownik> użytkownicy, Użytkownik aktualnyUżytkownik)
        {
            return !użytkownicy.Any(u =>
                u.Pesel == pesel &&
                (aktualnyUżytkownik == null || u.Id != aktualnyUżytkownik.Id)
            );
        }




        // Pobieranie pełnego roku na podstawie numeru PESEL
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

        // Konwersja miesiąca z numeru PESEL na rzeczywisty miesiąc
        private static int GetRealMonth(string month)
        {
            int m = int.Parse(month);
            return (m % 20);
        }

        // Sprawdzanie poprawności daty urodzenia
        private static bool IsValidDate(int year, int month, int day)
        {
            return day > 0 && day <= DateTime.DaysInMonth(year, month);
        }

        // Sprawdzanie cyfry kontrolnej numeru PESEL
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

        // Porównanie daty urodzenia z PESEL z datą z DateTimePicker
        public static bool DoesBirthDateMatchPESEL(string pesel, DateTime selectedDate)
        {
            if (!Regex.IsMatch(pesel, @"^\d{11}$"))
                return false;

            string yearPart = pesel.Substring(0, 2);
            string monthPart = pesel.Substring(2, 2);
            string dayPart = pesel.Substring(4, 2);

            int fullYear = GetFullYear(yearPart, monthPart);
            int fullMonth = GetRealMonth(monthPart);
            int fullDay = int.Parse(dayPart);

            DateTime dateFromPESEL;
            try
            {
                dateFromPESEL = new DateTime(fullYear, fullMonth, fullDay);
            }
            catch
            {
                return false;
            }

            return dateFromPESEL.Date == selectedDate.Date;
        }


        public static bool IsUniqueLogin(string login, List<Użytkownik> usersList)
        {
            return !usersList.Any(user => user.Login == login);
        }

        public static bool IsUniqueEmail(string email, List<Użytkownik> usersList)
        {
            return !usersList.Any(user => user.Adres_email == email);
        }

        public static bool IsUniquePESEL(string pesel, List<Użytkownik> usersList)
        {
            return !usersList.Any(user => user.Pesel == pesel);
        }




        // Walidacja kodu pocztowego (format: 00-000)
        public static bool IsValidPostalCode(string postalCode)
        {
            string pattern = @"^\d{2}-\d{3}$";
            return Regex.IsMatch(postalCode, pattern);
        }
    }
}
