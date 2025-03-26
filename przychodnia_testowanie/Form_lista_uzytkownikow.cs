using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Mysqlx.Datatypes;
using System.Reflection;

namespace przychodnia_testowanie
{ 
  
    public partial class Form_lista_uzytkownikow : Form
    {
        Laczenie_z_baza_danych DBconn = new Laczenie_z_baza_danych();
        public Form_lista_uzytkownikow()
        {
            InitializeComponent();
            refresh();
        }

        static string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2")); // Konwersja na zapis szesnastkowy
                }
                return builder.ToString();
            }
        }

        void refresh()
        {           
            DataTable result = DBconn.ExecuteQuery("SELECT p.name as Imię, p.lastname as Nazwisko, u.login, u.role as Rola, u.email, u.phonenumber as 'Numer Telefonu', u.regdate as 'Data Rejestracji', p.pesel as Pesel, p.country as Kraj, p.city as Miasto, p.postcode as 'Kod pocztowy', p.street as Ulica, p.house_number as 'Numer domu', p.apartment_number as 'Numer apartamentu' FROM users as u JOIN patients as p ON u.id = p.user_id;");
            dtGrdVw_lista_uż.DataSource = result;            
        }
        public bool AreAllPropertiesSet(Użytkownik uzytkownik)
        {
            // Pobieramy wszystkie właściwości obiektu Uzytkownik
            PropertyInfo[] properties = uzytkownik.GetType().GetProperties();

            foreach (var property in properties)
            {
                var value = property.GetValue(uzytkownik);

                // Sprawdzamy, czy wartość właściwości jest null (dla referencyjnych typów) lub pusta (dla stringów)
                if (value == null || (value is string && string.IsNullOrWhiteSpace((string)value)))
                {
                    return false; // Jeśli któraś z właściwości nie jest ustawiona, zwróć false
                }
            }

            return true; // Wszystkie właściwości są ustawione
        }
        private void btn_nowy_użytkow_Click(object sender, EventArgs e)
        {

            Użytkownik nowy_uzytkownik = new Użytkownik();
            Form_profil form = new Form_profil(nowy_uzytkownik);
            DialogResult result = form.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;//Sprawdzenie, czy wynik dialogu jest różny od DialogResult.OK. Jeśli tak, metoda kończy działanie (

            }
            if (!AreAllPropertiesSet(nowy_uzytkownik))
            {
                return;
            }
                Laczenie_z_baza_danych DBconn = new Laczenie_z_baza_danych();
                DataTable insertUser = DBconn.ExecuteQuery("INSERT INTO users (id, login, password, role, email, phonenumber, status, regdate) VALUES ( NULL, @login, @password, @role, @email, @phonenumber, @status, NOW())",

                new MySqlParameter("@login", nowy_uzytkownik.Login),
                new MySqlParameter("@password", ComputeSha256Hash(nowy_uzytkownik.Login)),
                new MySqlParameter("@role", "patient"),
                new MySqlParameter("@email", nowy_uzytkownik.Adres_email),
                new MySqlParameter("@phonenumber", nowy_uzytkownik.Numer_telefonu),
                new MySqlParameter("@status", 1));

                DataTable lastinsertID = DBconn.ExecuteQuery("SELECT LAST_INSERT_ID()");
                object lastID = lastinsertID.Rows[0][0];

                DataTable insertPatient = DBconn.ExecuteQuery("INSERT INTO patients (id, user_id, pesel, country, city, postcode, street, house_number, apartment_number, name, lastname) VALUES ( NULL, @user_id, @pesel, 'Poland', @city, @postcode, @street, @house_number, @apartment_number, @name, @lastname)",

                new MySqlParameter("@user_id", lastID),
                new MySqlParameter("@pesel", nowy_uzytkownik.Pesel),
                new MySqlParameter("@city", nowy_uzytkownik.Miejscowość),
                new MySqlParameter("@postcode", nowy_uzytkownik.Kod_pocztowy),
                new MySqlParameter("@street", nowy_uzytkownik.Ulica),
                new MySqlParameter("@house_number", nowy_uzytkownik.Numer_pos),
                new MySqlParameter("@apartment_number", nowy_uzytkownik.Numer_lokalu),
                new MySqlParameter("@name", nowy_uzytkownik.Imię),
                new MySqlParameter("@lastname", nowy_uzytkownik.Nazwisko));

            refresh();

            MessageBox.Show("Użytkownik został dodany pomyślnie!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dtGrdVw_lista_uż_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txb_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_wyszukiwarka_Click(object sender, EventArgs e)
        {
            string szukany = "%"+txb_search.Text+"%";
            DataTable result = DBconn.ExecuteQuery("SELECT u.id, p.name, p.lastname, u.login, u.role, u.email, u.phonenumber, u.regdate, p.pesel, p.country, p.city, p.postcode, p.street, p.house_number, p.apartment_number FROM users as u JOIN patients as p ON u.id = p.user_id WHERE name LIKE @szukany;",
            new MySqlParameter("@szukany", szukany));
            dtGrdVw_lista_uż.DataSource = result;
        }

       /* private void btn_edycja_użytkownika_Click(object sender, EventArgs e)
        {
            if (dtGrdVw_lista_uż.SelectedRows.Count < 1)
                return;

            int index = dtGrdVw_lista_uż.Rows.IndexOf(dtGrdVw_lista_uż.SelectedRows[0]);
            //Pobranie indeksu pierwszego wybranego wiersza z DataGridView.

            Użytkownik użytkownik_do_edycji = (Użytkownik)dtGrdVw_lista_uż.SelectedRows[0].Tag;
            Form_profil form = new Form_profil(użytkownik_do_edycji);
            form.ShowDialog();
            //Wyświetlenie formularza w trybie dialogowym.Użytkownik może edytować dane naprawy w formularzu.
            refresh();

            dtGrdVw_lista_uż.Rows[index].Selected = true;
        }*/
    }
}
