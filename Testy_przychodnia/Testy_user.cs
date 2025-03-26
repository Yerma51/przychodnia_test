using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xunit;

namespace Testy_przychodnia
{
    public class Testy_user
    {
        // Проверка логина
        private bool IsLoginValid(string login)
        {
            return !string.IsNullOrWhiteSpace(login);
        }

        // Проверка PESEL
        private bool IsPeselValid(string pesel)
        {
            if (pesel.Length != 11 || !pesel.All(char.IsDigit))
                return false;

            // Проверяем дату рождения (первые 6 цифр)
            string birthDate = pesel.Substring(0, 6);
            if (!DateTime.TryParseExact(birthDate, new[] { "yyMMdd" }, null, System.Globalization.DateTimeStyles.None, out _))
                return false;

            // Проверка пола (10-я цифра: четная - женщина, нечетная - мужчина)
            int genderDigit = int.Parse(pesel[9].ToString());
            if (genderDigit < 0 || genderDigit > 9)
                return false;

            // Примитивная проверка контрольной цифры
            int[] weights = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            int controlSum = pesel.Take(10).Select((c, i) => (c - '0') * weights[i]).Sum();
            int controlDigit = (10 - (controlSum % 10)) % 10;

            return controlDigit == pesel[10] - '0';
        }

        // Проверка email
        private bool IsEmailValid(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, emailPattern) && email.Length <= 255;
        }

        // Проверка номера телефона
        private bool IsPhoneNumberValid(string phoneNumber)
        {
            return phoneNumber.Length == 9 && phoneNumber.All(char.IsDigit);
        }

        // Тесты логина
        [Fact]
        public void Login_ShouldBeInvalid_WhenEmpty()
        {
            Assert.False(IsLoginValid(""));
        }

        [Fact]
        public void Login_ShouldBeValid_WhenCorrect()
        {
            Assert.True(IsLoginValid("User123"));
        }

        // Тесты PESEL
        [Fact]
        public void Pesel_ShouldBeInvalid_WhenTooShort()
        {
            Assert.False(IsPeselValid("1234567"));
        }

        [Fact]
        public void Pesel_ShouldBeInvalid_WhenWrongControlDigit()
        {
            Assert.False(IsPeselValid("44051401358")); // Некорректная контрольная цифра
        }

        [Fact]
        public void Pesel_ShouldBeValid_ForMale()
        {
            Assert.True(IsPeselValid("44051401359")); // Мужчина (нечетная 10-я цифра)
        }

        [Fact]
        public void Pesel_ShouldBeValid_ForFemale()
        {
            Assert.True(IsPeselValid("44051401460")); // Женщина (четная 10-я цифра)
        }

        // Тесты email
        [Fact]
        public void Email_ShouldBeInvalid_WhenMissingAtSymbol()
        {
            Assert.False(IsEmailValid("user.example.com"));
        }

        [Fact]
        public void Email_ShouldBeValid_WhenCorrect()
        {
            Assert.True(IsEmailValid("user@example.com"));
        }

        [Fact]
        public void Email_ShouldBeInvalid_WhenTooLong()
        {
            string longEmail = new string('a', 250) + "@example.com";
            Assert.False(IsEmailValid(longEmail));
        }

        // Тесты номера телефона
        [Fact]
        public void PhoneNumber_ShouldBeInvalid_WhenTooShort()
        {
            Assert.False(IsPhoneNumberValid("12345"));
        }

        [Fact]
        public void PhoneNumber_ShouldBeValid_WhenNineDigits()
        {
            Assert.True(IsPhoneNumberValid("123456789"));
        }

        [Fact]
        public void PhoneNumber_ShouldBeInvalid_WhenContainsLetters()
        {
            Assert.False(IsPhoneNumberValid("1234567A9"));
        }
    }
}
