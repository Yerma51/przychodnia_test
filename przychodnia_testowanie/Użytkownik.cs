using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace przychodnia_testowanie
{
    public class Użytkownik
    {
        public int Id { get; set; }
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

        
        


        private static List<Użytkownik> użytkownicy = new List<Użytkownik>();// defenuje listę 



        static internal List<Użytkownik> Użytkownicy => użytkownicy;

        // Konstruktor domyślny
        public Użytkownik() { }


        // Konstruktor kopiujący
        public Użytkownik(Użytkownik u)
        {
            Id = u.Id;
            Login = u.Login;
            Imię = u.Imię;
            Nazwisko = u.Nazwisko;
            Data_urodzenia = u.Data_urodzenia;
            Pesel = u.Pesel;
            Adres_email = u.Adres_email;
            Miejscowość = u.Miejscowość;
            Ulica = u.Ulica;
            Numer_pos = u.Numer_pos;
            Numer_lokalu = u.Numer_lokalu;
            Kod_pocztowy = u.Kod_pocztowy;
            Numer_telefonu = u.Numer_telefonu;
        }
    }

}
