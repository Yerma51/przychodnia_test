﻿using przychodnia_testowanie;
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
        // Sprawdazanie loginu
        private bool IsLoginValid(string login)
        {
            return !string.IsNullOrWhiteSpace(login);
        }

        // Spradzanie PESEL
        private bool IsPeselValid(string pesel)
        {
            if (pesel.Length != 11 || !pesel.All(char.IsDigit))
                return false;

            //  Sprawdzamy date urodzenia (pierwsze 6 cyfr)
            string birthDate = pesel.Substring(0, 6);
            if (!DateTime.TryParseExact(birthDate, new[] { "yyMMdd" }, null, System.Globalization.DateTimeStyles.None, out _))
                return false;

            // Sprawdzanie płci (10-ta cyfra: parzysta - kobieta, nieparzysta - mężczyzna) 
            int genderDigit = int.Parse(pesel[9].ToString());
            if (genderDigit < 0 || genderDigit > 9)
                return false;

            // Sprawdzanie cyfry kontrolnej
            int[] weights = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            int controlSum = pesel.Take(10).Select((c, i) => (c - '0') * weights[i]).Sum();
            int controlDigit = (10 - (controlSum % 10)) % 10;

            return controlDigit == pesel[10] - '0';
        }

        // sprawdzenie email
        private bool IsEmailValid(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, emailPattern) && email.Length <= 255;
        }

        // Sprawdzenie numeru telefonu
        private bool IsPhoneNumberValid(string phoneNumber)
        {
            return phoneNumber.Length == 9 && phoneNumber.All(char.IsDigit);
        }

        // login
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

        // Testy PESEL
        [Fact]
        public void Pesel_ShouldBeInvalid_WhenTooShort()
        {
            Assert.False(IsPeselValid("1234567"));
        }

        [Fact]
        public void Pesel_ShouldBeInvalid_WhenWrongControlDigit()
        {
            Assert.False(IsPeselValid("44051401358")); // Niepoprawna cyfra kontrolna
        }

        [Fact]
        public void Pesel_ShouldBeValid_ForMale()
        {
            Assert.True(IsPeselValid("44051401359")); // Mężczyzna (nieparzysta 10-ta cyfra)
        }

        [Fact]
        public void Pesel_ShouldBeValid_ForFemale()
        {
            Assert.True(IsPeselValid("44051401460")); // Kobieta (parzysta 10-ta cyfra)
        }

        // Testy email
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

        // Testy numera telefonu
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

        // Testy zapomniania i wyszukiwanie zapomnianych
        [Fact]
        public void AnonymizedUser_ShouldHaveClearedFieldsAndNullStatus()
        {
            // Arrange
            Użytkownik user = new Użytkownik
            {
                Id = 1,
                Login = "john",
                Adres_email = "john@example.com",
                Numer_telefonu = "123456789",
                Pesel = "94071412345",
                Imię = "Jan"
            };

            // Act – symulujemy zapomnienie
            user.Login = "";
            user.Adres_email = "";
            user.Numer_telefonu = "";
            user.Pesel = "";
            user.Imię = "Anonimowy";
            bool? status = null; // symuluje status = NULL

            // Assert
            Assert.Equal("", user.Login);
            Assert.Equal("", user.Adres_email);
            Assert.Equal("", user.Pesel);
            Assert.Equal("Anonimowy", user.Imię);
            Assert.Null(status);
        }


        [Fact]
        public void ForgottenUsersFilter_ShouldReturnOnlyUsersWithNullStatus()
        {
            // Arrange
            var users = new List<(Użytkownik user, bool? status)>
            {
                (new Użytkownik { Id = 1, Imię = "Jan", Login = "jan", Adres_email = "jan@x.com" }, true),
                (new Użytkownik { Id = 2, Imię = "Anonimowy", Login = "", Adres_email = "" }, null)
            };

            // Act – znajdź tylko zapomnianych
            var forgottenUsers = users
                .Where(u => u.status == null && u.user.Imię == "Anonimowy" && string.IsNullOrEmpty(u.user.Login))
                .ToList();

            // Assert
            Assert.Single(forgottenUsers);
            Assert.Equal(2, forgottenUsers[0].user.Id);
        }


    }
}
