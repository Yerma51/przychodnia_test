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
using System.Data.SqlClient;

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

        /*static string ComputeSha256Hash(string rawData)
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
        }*/         //hashowanie hasła

        void refresh()
        {
            DataTable result = DBconn.ExecuteQuery("SELECT p.name as Imię, p.lastname as Nazwisko, u.login, u.role as Rola, u.email, u.phonenumber as 'Numer Telefonu', u.regdate as 'Data Rejestracji', p.pesel as Pesel, p.country as Kraj, p.city as Miasto, p.postcode as 'Kod pocztowy', p.street as Ulica, p.house_number as 'Numer domu', p.apartment_number as 'Numer apartamentu', u.id FROM users as u JOIN patients as p ON u.id = p.user_id;");
            dtGrdVw_lista_uż.DataSource = result;
        }

        /*public bool AreAllPropertiesSet(Użytkownik uzytkownik, out string missingPropertyName)
        {
            PropertyInfo[] properties = uzytkownik.GetType().GetProperties();
            foreach (var property in properties)
            {
                if (property.Name == "Numer_lokalu")
                {
                    continue;
                }
                var value = property.GetValue(uzytkownik);
                if (value == null || (value is string && string.IsNullOrWhiteSpace((string)value)))
                {
                    missingPropertyName = property.Name;
                    return false;
                }
            }

            missingPropertyName = null;
            return true;
        }*/     //walidacja danych (ale lepiej)


private void btn_nowy_użytkow_Click(object sender, EventArgs e)
        {
            Użytkownik nowy_uzytkownik = new Użytkownik();
            Form_profil form = new Form_profil(nowy_uzytkownik);
            DialogResult result = form.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;//Sprawdzenie, czy wynik dialogu jest różny od DialogResult.OK. Jeśli tak, metoda kończy działanie (

            }
            /*if (!AreAllPropertiesSet(nowy_uzytkownik, out string missingProperty))
            {
                Console.WriteLine($"Nie podano: {missingProperty}");
            }
            else
            {*/
                // sukces
                Laczenie_z_baza_danych DBconn = new Laczenie_z_baza_danych();
                DataTable insertUser = DBconn.ExecuteQuery("INSERT INTO users (id, login, role, email, phonenumber, status, regdate) VALUES ( NULL, @login, @role, @email, @phonenumber, @status, NOW())",

                new MySqlParameter("@login", nowy_uzytkownik.Login),               
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
            //}
        }

        private void btn_wyszukiwarka_Click(object sender, EventArgs e)
        {
            string szukany = txb_search.Text.Trim();

            // Jeśli pole wyszukiwania nie jest puste
            if (!string.IsNullOrWhiteSpace(szukany))
            {
                // Podział wpisanej frazy na części (imię i nazwisko)
                string[] searchParts = szukany.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string searchName = searchParts.Length > 0 ? searchParts[0] : "";
                string searchLastname = searchParts.Length > 1 ? searchParts[1] : "";

                DataTable result;

                if (searchParts.Length == 2)
                {
                    // Wyszukiwanie po imieniu i nazwisku (w dowolnej kolejności)
                    result = DBconn.ExecuteQuery(
                        "SELECT p.name as Imię, p.lastname as Nazwisko, u.login, u.role as Rola, u.email, u.phonenumber as 'Numer Telefonu', u.regdate as 'Data Rejestracji', p.pesel as Pesel, p.country as Kraj, p.city as Miasto, p.postcode as 'Kod pocztowy', p.street as Ulica, p.house_number as 'Numer domu', p.apartment_number as 'Numer apartamentu', u.id " +
                        "FROM users as u " +
                        "JOIN patients as p ON u.id = p.user_id " +
                        "WHERE (p.name LIKE @name AND p.lastname LIKE @lastname) OR (p.name LIKE @lastname AND p.lastname LIKE @name);",
                        new MySqlParameter("@name", "%" + searchName + "%"),
                        new MySqlParameter("@lastname", "%" + searchLastname + "%"));
                }
                else
                {
                    // Wyszukiwanie po imieniu lub nazwisku
                    result = DBconn.ExecuteQuery(
                        "SELECT p.name as Imię, p.lastname as Nazwisko, u.login, u.role as Rola, u.email, u.phonenumber as 'Numer Telefonu', u.regdate as 'Data Rejestracji', p.pesel as Pesel, p.country as Kraj, p.city as Miasto, p.postcode as 'Kod pocztowy', p.street as Ulica, p.house_number as 'Numer domu', p.apartment_number as 'Numer apartamentu', u.id " +
                        "FROM users as u " +
                        "JOIN patients as p ON u.id = p.user_id " +
                        "WHERE p.name LIKE @szukany OR p.lastname LIKE @szukany;",
                        new MySqlParameter("@szukany", "%" + szukany + "%"));
                }

                dtGrdVw_lista_uż.DataSource = result;
            }
            else
            {
                // Jeśli pole wyszukiwania jest puste, wyświetlamy całą listę
                DataTable result = DBconn.ExecuteQuery(
                    "SELECT p.name as Imię, p.lastname as Nazwisko, u.login, u.role as Rola, u.email, u.phonenumber as 'Numer Telefonu', u.regdate as 'Data Rejestracji', p.pesel as Pesel, p.country as Kraj, p.city as Miasto, p.postcode as 'Kod pocztowy', p.street as Ulica, p.house_number as 'Numer domu', p.apartment_number as 'Numer apartamentu', u.id FROM users as u JOIN patients as p ON u.id = p.user_id;" 
                    );

                dtGrdVw_lista_uż.DataSource = result;
            }
        }













        private void btn_edycja_użytkownika_Click(object sender, EventArgs e)
        {
            if (dtGrdVw_lista_uż.SelectedRows.Count == 0)
            {
                MessageBox.Show("Proszę wybrać użytkownika do edytowania!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Pobieramy ID wybranego użytkownika
            int userId = Convert.ToInt32(dtGrdVw_lista_uż.SelectedRows[0].Cells["id"].Value);

            // Pobieramy dane użytkownika z bazy danych
            DataTable userData = DBconn.ExecuteQuery("SELECT u.id, u.login, u.email, u.phonenumber, p.name, p.lastname, p.pesel, p.city, p.postcode, p.street, p.house_number, p.apartment_number FROM users u JOIN patients p ON u.id = p.user_id WHERE u.id = @id",
                new MySqlParameter("@id", userId));

            if (userData.Rows.Count == 0)
            {
                MessageBox.Show("Nie znaleziono danych użytkownika!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tworzymy obiekt z danymi użytkownika
            DataRow row = userData.Rows[0];
            Użytkownik selectedUser = new Użytkownik
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
                Numer_lokalu = row["apartment_number"].ToString()
            };

            // Otwieramy formularz edycji i przekazujemy do niego dane
            Form_Edycja_profilu editForm = new Form_Edycja_profilu(selectedUser);
            DialogResult result = editForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Jeśli edycja zakończona sukcesem, aktualizujemy dane w bazie danych
                DBconn.ExecuteQuery("UPDATE users SET login = @login, email = @email, phonenumber = @phonenumber WHERE id = @id",
                    new MySqlParameter("@login", selectedUser.Login),
                    new MySqlParameter("@email", selectedUser.Adres_email),
                    new MySqlParameter("@phonenumber", selectedUser.Numer_telefonu),
                    new MySqlParameter("@id", selectedUser.Id));

                DBconn.ExecuteQuery("UPDATE patients SET name = @name, lastname = @lastname, pesel = @pesel, city = @city, postcode = @postcode, street = @street, house_number = @house_number, apartment_number = @apartment_number WHERE user_id = @user_id",
                    new MySqlParameter("@name", selectedUser.Imię),
                    new MySqlParameter("@lastname", selectedUser.Nazwisko),
                    new MySqlParameter("@pesel", selectedUser.Pesel),
                    new MySqlParameter("@city", selectedUser.Miejscowość),
                    new MySqlParameter("@postcode", selectedUser.Kod_pocztowy),
                    new MySqlParameter("@street", selectedUser.Ulica),
                    new MySqlParameter("@house_number", selectedUser.Numer_pos),
                    new MySqlParameter("@apartment_number", selectedUser.Numer_lokalu),
                    new MySqlParameter("@user_id", selectedUser.Id));

                // Po zaktualizowaniu danych, odświeżamy DataGridView
                refresh();

                MessageBox.Show("Dane użytkownika zostały zaktualizowane!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

       
    }
}
