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
        public int PlecInt { get; set; } // 1 - Mężczyzna, 0 - Kobieta
        public DateTime Data_urodzenia { get; set; }
        public string Pesel { get; set; }
        public string Adres_email { get; set; }
        public string Miejscowość { get; set; }
        public string Ulica { get; set; }
        public string Numer_pos { get; set; }
        public string Numer_lokalu { get; set; }
        public string Kod_pocztowy { get; set; }
        public string Numer_telefonu { get; set; }
        public List<string> Uprawnienia { get; set; } = new List<string>();
        public bool MaUprawnienie(string kod)
        {
            return Uprawnienia.Contains(kod);
        }





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

        public static List<Użytkownik> PobierzWszystkichUżytkownikówZBazy()
        {
            var lista = new List<Użytkownik>();

            Laczenie_z_baza_danych DBconn = new Laczenie_z_baza_danych();

            DataTable dt = DBconn.ExecuteQuery("SELECT u.id, u.login, u.email, u.phonenumber, p.name, p.lastname, p.pesel, p.city, p.postcode, p.street, p.house_number, p.apartment_number, p.gender FROM users u JOIN patients p ON u.id = p.user_id");

            foreach (DataRow row in dt.Rows)
            {
                lista.Add(new Użytkownik
                {
                    Id = Convert.ToInt32(row["id"]),
                    Login = row["login"].ToString(),
                    Adres_email = row["email"].ToString(),
                    Numer_telefonu = row["phonenumber"].ToString(),
                    Imię = row["name"].ToString(),
                    Nazwisko = row["lastname"].ToString(),
                    Pesel = row["pesel"].ToString(),
                    Miejscowość = row["city"].ToString(),
                    Kod_pocztowy = row["postcode"].ToString(),
                    Ulica = row["street"].ToString(),
                    Numer_pos = row["house_number"].ToString(),
                    Numer_lokalu = row["apartment_number"].ToString(),
                    Płec = row["gender"] != DBNull.Value ? row["gender"].ToString() : "0",
                });
            }

            return lista;
        }

    }

}
