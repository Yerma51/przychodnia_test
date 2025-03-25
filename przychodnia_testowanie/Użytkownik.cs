using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace przychodnia_testowanie
{
    internal class Użytkownik
    {
        public string Login { get; set; }
        public string Imię { get; set; }
        public string Nazwisko { get; set; }
        public string Płec { get; set; }
        public DateTime Data_urodzenia { get; set; }
        public string Pesel { get; set; }
        public string Adres_email { get; set; }
        public string Miejscowość { get; set; }
        public string Ulica { get; set; }
        public string Numer_pos { get; set; }
        public string Numer_lokalu { get; set; }
        public string Kod_pocztowy { get; set; }
        public string Numer_telefonu { get; set; }


        private static List<Użytkownik> użytkownicy = new List<Użytkownik>();// defenuje listę napraw

        internal object[] infoUżytkownik => new object[] { Login.ToString(), Imię.ToString(), Nazwisko.ToString(), Adres_email.ToString() };


        static internal List<Użytkownik> Użytkownicy => użytkownicy;
    }
}
