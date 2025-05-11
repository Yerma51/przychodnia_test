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
        private int aktualnieWybraneUprawnienieId = -1;
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

        public void refresh()
        {
            string query = @"
                        SELECT p.name as Imię, p.lastname as Nazwisko, u.login, p.pesel as Pesel, 
                       u.status, u.id,
                       GROUP_CONCAT(per.name SEPARATOR ', ') AS Uprawnienia
                FROM users u
                JOIN patients p ON u.id = p.user_id
                LEFT JOIN user_permissions up ON u.id = up.user_id
                LEFT JOIN permissions per ON up.permission_id = per.id
                GROUP BY u.id
                ;";

            DataTable result = DBconn.ExecuteQuery(query);
            dtGrdVw_lista_uż.DataSource = result;

            foreach (DataGridViewRow row in dtGrdVw_lista_uż.Rows)
            {
                var statusValue = row.Cells["status"].Value;
                if (statusValue == DBNull.Value) // status IS NULL = zapomniany
                {
                    row.DefaultCellStyle.BackColor = Color.LightGray;
                    row.DefaultCellStyle.ForeColor = Color.DarkGray;
                    row.DefaultCellStyle.Font = new Font(dtGrdVw_lista_uż.Font, FontStyle.Italic);
                    row.ReadOnly = true;
                }
            }

            if (dtGrdVw_lista_uż.Columns.Contains("status"))
                dtGrdVw_lista_uż.Columns["status"].Visible = false;
            if (dtGrdVw_lista_uż.Columns.Contains("id"))
                dtGrdVw_lista_uż.Columns["id"].Visible = false;
        }

        //PropertyInfo[] properties = uzytkownik.GetType().GetProperties();
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


        private void Wyszukaj(string szukany, int permissionId)
        {
            DataTable result;

            if (permissionId == -1)
            {
                result = DBconn.ExecuteQuery(
                    @"SELECT u.id AS id, u.status AS status, u.login, p.name AS 'Imię', p.lastname AS 'Nazwisko', p.pesel AS 'Pesel', 
              GROUP_CONCAT(per.name SEPARATOR ', ') AS 'Uprawnienia'
              FROM users u
              JOIN patients p ON u.id = p.user_id
              LEFT JOIN user_permissions up ON u.id = up.user_id
              LEFT JOIN permissions per ON up.permission_id = per.id
              WHERE p.name LIKE @search OR p.lastname LIKE @search OR u.login LIKE @search
              GROUP BY u.id;",
                    new MySqlParameter("@search", "%" + szukany + "%")
                );
            }
            else
            {
                result = DBconn.ExecuteQuery(
                    @"SELECT u.id AS id, u.status AS status, u.login, p.name AS 'Imię', p.lastname AS 'Nazwisko', p.pesel AS 'Pesel',
              GROUP_CONCAT(per.name SEPARATOR ', ') AS 'Uprawnienia'
              FROM users u
              JOIN patients p ON u.id = p.user_id
              LEFT JOIN user_permissions up ON u.id = up.user_id
              LEFT JOIN permissions per ON up.permission_id = per.id
              WHERE (p.name LIKE @search OR p.lastname LIKE @search OR u.login LIKE @search)
                AND EXISTS (SELECT 1 FROM user_permissions up2 WHERE up2.user_id = u.id AND up2.permission_id = @permissionId)
              GROUP BY u.id;",
                    new MySqlParameter("@search", "%" + szukany + "%"),
                    new MySqlParameter("@permissionId", permissionId)
                );
            }

            dtGrdVw_lista_uż.DataSource = result;
        }




        private void btn_nowy_użytkow_Click(object sender, EventArgs e)
        {
            Użytkownik nowy_uzytkownik = new Użytkownik();
            Form_profil form = new Form_profil(nowy_uzytkownik);

            this.Hide(); 

            DialogResult result = form.ShowDialog();
            int genderValue = 0;

            if (nowy_uzytkownik.Płec == "Mężczyzna")
            {
                genderValue = 1;
            }

            if (result == DialogResult.OK)
            {
                // Dodajemy użytkownika do bazy dopiero jeśli kliknięto OK

                Laczenie_z_baza_danych DBconn = new Laczenie_z_baza_danych();
                DataTable insertUser = DBconn.ExecuteQuery("INSERT INTO users (id, login, role, email, phonenumber, status, regdate) VALUES (NULL, @login, @role, @email, @phonenumber, @status, NOW())",
                    new MySqlParameter("@login", nowy_uzytkownik.Login),
                    new MySqlParameter("@role", "patient"),
                    new MySqlParameter("@email", nowy_uzytkownik.Adres_email),
                    new MySqlParameter("@phonenumber", nowy_uzytkownik.Numer_telefonu),
                    new MySqlParameter("@status", 1));

                DataTable lastinsertID = DBconn.ExecuteQuery("SELECT LAST_INSERT_ID()");
                object lastID = lastinsertID.Rows[0][0];

                DataTable insertPatient = DBconn.ExecuteQuery("INSERT INTO patients (id, user_id, pesel, country, city, postcode, street, house_number, apartment_number, name, lastname, gender, birth_date) VALUES (NULL, @user_id, @pesel, 'Poland', @city, @postcode, @street, @house_number, @apartment_number, @name, @lastname, @gender, @birth_date)",
                    new MySqlParameter("@user_id", lastID),
                    new MySqlParameter("@pesel", nowy_uzytkownik.Pesel),
                    new MySqlParameter("@city", nowy_uzytkownik.Miejscowość),
                    new MySqlParameter("@postcode", nowy_uzytkownik.Kod_pocztowy),
                    new MySqlParameter("@street", nowy_uzytkownik.Ulica),
                    new MySqlParameter("@house_number", nowy_uzytkownik.Numer_pos),
                    new MySqlParameter("@apartment_number", nowy_uzytkownik.Numer_lokalu),
                    new MySqlParameter("@name", nowy_uzytkownik.Imię),
                    new MySqlParameter("@lastname", nowy_uzytkownik.Nazwisko),
                    new MySqlParameter("@birth_date", nowy_uzytkownik.Data_urodzenia),
                    new MySqlParameter("@gender", genderValue));

                refresh();

                MessageBox.Show("Użytkownik został dodany pomyślnie!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form_lista_uzytkownikow formLista = new Form_lista_uzytkownikow();
                formLista.Show();

                this.Hide();
            }
            else
            {
                this.Show();
            }
        }



        private void btn_wyszukiwarka_Click(object sender, EventArgs e)
        {
            string szukany = txb_search.Text.Trim();
            if (string.IsNullOrWhiteSpace(szukany) || szukany == "Podaj imię, nazwisko lub login")
            {
                MessageBox.Show("Proszę podać imię, nazwisko lub login do wyszukiwania.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Wyszukaj(szukany, aktualnieWybraneUprawnienieId);
        }



        private void anuluj_wyszukiwarka_Click(object sender, EventArgs e)
        {
            txb_search.Text = "Podaj imię, nazwisko lub login";
            txb_search.ForeColor = Color.Silver;

            DataTable result = DBconn.ExecuteQuery(
                @"SELECT 
              u.id AS id,
              u.status AS status,
              p.name AS 'Imię',
              p.lastname AS 'Nazwisko',
              u.login AS 'Login',
              p.pesel AS 'Pesel',
              GROUP_CONCAT(per.name SEPARATOR ', ') AS 'Uprawnienia'
          FROM users u
          JOIN patients p ON u.id = p.user_id
          LEFT JOIN user_permissions up ON u.id = up.user_id
          LEFT JOIN permissions per ON up.permission_id = per.id
          GROUP BY u.id;"
            );

            dtGrdVw_lista_uż.DataSource = result;
            lbl_filtr_info.Text = "Brak wybranego filtru uprawnień";
        }



        //Podpowiedź do wyszukiwania
        private void txb_search_Leave(object sender, EventArgs e)
        {
            if (txb_search.Text == "")
            {
                txb_search.Text = "Podaj imię, nazwisko lub login";
                txb_search.ForeColor = Color.Silver;
            }
        }
        private void txb_search_Enter(object sender, EventArgs e)
        {
            if (txb_search.Text == "Podaj imię, nazwisko lub login")
            {
                txb_search.Text = "";
                txb_search.ForeColor = Color.Black;
            }
        }

        //Żeby nie było automatycznego ustawienia kursora
        private void Form_lista_uzytkownikow_Shown(object sender, EventArgs e)
        {
            ActiveControl = null;
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
            DataTable userData = DBconn.ExecuteQuery("SELECT u.id, u.login, u.email, u.phonenumber, p.name, p.lastname, p.pesel, p.city, p.postcode, p.street, p.house_number, p.apartment_number, p.gender, p.birth_date FROM users u JOIN patients p ON u.id = p.user_id WHERE u.id = @id",
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
                Numer_lokalu = row["apartment_number"].ToString(),
                Data_urodzenia = Convert.ToDateTime(row["birth_date"]),
                Płec = Convert.ToInt32(row["gender"]) == 1 ? "Mężczyzna" : "Kobieta"
            };

            // Otwieramy formularz edycji i przekazujemy do niego dane
            Form_Edycja_profilu editForm = new Form_Edycja_profilu(selectedUser);
            this.Hide();

            DialogResult result = editForm.ShowDialog();

            this.Show();

            if (result == DialogResult.OK)
            {
                // Jeśli edycja zakończona sukcesem, aktualizujemy dane w bazie danych
                DBconn.ExecuteQuery("UPDATE users SET login = @login, email = @email, phonenumber = @phonenumber WHERE id = @id",
                    new MySqlParameter("@login", selectedUser.Login),
                    new MySqlParameter("@email", selectedUser.Adres_email),
                    new MySqlParameter("@phonenumber", selectedUser.Numer_telefonu),
                    new MySqlParameter("@id", selectedUser.Id));

                DBconn.ExecuteQuery("UPDATE patients SET name = @name, lastname = @lastname, pesel = @pesel, city = @city, postcode = @postcode, street = @street, house_number = @house_number, apartment_number = @apartment_number, gender = @gender, birth_date = @birth_date WHERE user_id = @user_id",
                    new MySqlParameter("@name", selectedUser.Imię),
                    new MySqlParameter("@lastname", selectedUser.Nazwisko),
                    new MySqlParameter("@pesel", selectedUser.Pesel),
                    new MySqlParameter("@city", selectedUser.Miejscowość),
                    new MySqlParameter("@postcode", selectedUser.Kod_pocztowy),
                    new MySqlParameter("@street", selectedUser.Ulica),
                    new MySqlParameter("@house_number", selectedUser.Numer_pos),
                    new MySqlParameter("@apartment_number", selectedUser.Numer_lokalu),
                    new MySqlParameter("@gender", selectedUser.PlecInt),
                    new MySqlParameter("@birth_date", selectedUser.Data_urodzenia),
                    new MySqlParameter("@user_id", selectedUser.Id));

                // Po zaktualizowaniu danych, odświeżamy DataGridView
                refresh();

                MessageBox.Show("Dane użytkownika zostały zaktualizowane!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void ZapomnijUzytkownika(int userId)
        {
            try
            {
                Random rng = new Random();
                string randomName = "Anonim" + rng.Next(1000, 9999);
                string randomLastname = "User" + rng.Next(1000, 9999);

                DateTime today = DateTime.Today;
                DateTime birthDate;
                do
                {
                    birthDate = new DateTime(rng.Next(1950, today.Year + 1), rng.Next(1, 13), 1);
                    int maxDay = DateTime.DaysInMonth(birthDate.Year, birthDate.Month);
                    birthDate = new DateTime(birthDate.Year, birthDate.Month, rng.Next(1, maxDay + 1));
                } while (birthDate > today);

                int gender = rng.Next(2); // 0 = M, 1 = K
                DateTime forgetDate = DateTime.Now;

                string anonymLogin = "anonim_" + Guid.NewGuid().ToString("N").Substring(0, 8);
                string anonymEmail = $"anonim_{Guid.NewGuid().ToString("N").Substring(0, 8)}@example.com";
                string anonymPhone = "000" + rng.Next(1000000, 9999999).ToString();

                string randomPesel = GeneratePesel(birthDate, gender);

                DataTable loginData = DBconn.ExecuteQuery("SELECT login FROM users WHERE id = @id", new MySqlParameter("@id", userId));
                string login = loginData.Rows.Count > 0 ? loginData.Rows[0]["login"].ToString() : "brak";

                DBconn.ExecuteQuery(
                    @"INSERT INTO forgotten_users (login, random_name, random_lastname, random_pesel, birth_date, gender, forget_date)
              VALUES (@login, @name, @lastname, @pesel, @birthdate, @gender, @forgetdate)",
                    new MySqlParameter("@login", login),
                    new MySqlParameter("@name", randomName),
                    new MySqlParameter("@lastname", randomLastname),
                    new MySqlParameter("@pesel", randomPesel),
                    new MySqlParameter("@birthdate", birthDate),
                    new MySqlParameter("@gender", gender),
                    new MySqlParameter("@forgetdate", forgetDate)
                );

                DBconn.ExecuteQuery(
                    @"DELETE FROM patients WHERE user_id = @id;

              UPDATE users 
              SET login = @anonimLogin, email = @anonimEmail, phonenumber = @anonimPhone, status = NULL, role = NULL 
              WHERE id = @id;",
                    new MySqlParameter("@anonimLogin", anonymLogin),
                    new MySqlParameter("@anonimEmail", anonymEmail),
                    new MySqlParameter("@anonimPhone", anonymPhone),
                    new MySqlParameter("@id", userId)
                );

                MessageBox.Show("Użytkownik został zapomniany. Dane zostały usunięte, a konto zdezaktywowane.",
                                "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas zapominania użytkownika: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GeneratePesel(DateTime birthDate, int gender)
        {
            string year = birthDate.Year.ToString().Substring(2, 2);
            int month = birthDate.Month;
            int day = birthDate.Day;

            if (birthDate.Year >= 2000 && birthDate.Year < 2100)
            {
                month += 20;
            }
            else if (birthDate.Year >= 2100 && birthDate.Year < 2200)
            {
                month += 40;
            }
            else if (birthDate.Year >= 2200 && birthDate.Year < 2300)
            {
                month += 60;
            }
            else if (birthDate.Year >= 1800 && birthDate.Year < 1900)
            {
                month += 80;
            }

            string monthStr = month.ToString("D2");
            string dayStr = day.ToString("D2");
            string serial = new Random().Next(1000, 9999).ToString();


            int genderDigit = gender == 0 ? new Random().Next(1, 10) | 1 : new Random().Next(0, 10) & ~1;
            string peselWithoutControl = year + monthStr + dayStr + serial + genderDigit;

            int[] weights = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum += weights[i] * int.Parse(peselWithoutControl[i].ToString());
            }
            int controlDigit = (10 - (sum % 10)) % 10;

            return peselWithoutControl + controlDigit;
        }









        private void btn_zapomnij_Click(object sender, EventArgs e)
        {
            if (dtGrdVw_lista_uż.SelectedRows.Count == 0)
            {
                MessageBox.Show("Wybierz użytkownika do zapomnienia.");
                return;
            }

            int userId = Convert.ToInt32(dtGrdVw_lista_uż.SelectedRows[0].Cells["id"].Value);
            var status = dtGrdVw_lista_uż.SelectedRows[0].Cells["status"].Value;

            // Sprawdź, czy użytkownik już zapomniany
            if (status == DBNull.Value)
            {
                MessageBox.Show("Użytkownik został zapomniany. Wszystkie dane zostały usunięte, a dostęp do systemu został zablokowany.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Czy na pewno chcesz zapomnieć tego użytkownika? Wszystkie dane wrażliwe zostaną usunięte i zastąpione losowymi danymi.",
                "Potwierdzenie",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                ZapomnijUzytkownika(userId);
            }
        }

        private void btn_strona_główna_Click(object sender, EventArgs e)
        {
            Form_strona_glowna form = new Form_strona_glowna();
            form.Show();
            this.Hide();
            
        }



        private void btn_podglad_danych_Click(object sender, EventArgs e)
        {
            if (dtGrdVw_lista_uż.SelectedRows.Count == 0)
            {
                MessageBox.Show("Proszę wybrać użytkownika do podglądu!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Pobieramy ID wybranego użytkownika
            int userId = Convert.ToInt32(dtGrdVw_lista_uż.SelectedRows[0].Cells["id"].Value);

            // Pobieramy dane użytkownika z bazy danych
            DataTable userData = DBconn.ExecuteQuery("SELECT u.id, u.login, u.email, u.phonenumber, p.name, p.lastname, p.pesel, p.city, p.postcode, p.street, p.house_number, p.apartment_number, p.gender, p.birth_date FROM users u JOIN patients p ON u.id = p.user_id WHERE u.id = @id",
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
                Numer_lokalu = row["apartment_number"].ToString(),
                Data_urodzenia = Convert.ToDateTime(row["birth_date"]),
                Płec = Convert.ToInt32(row["gender"]) == 1 ? "Mężczyzna" : "Kobieta"
            };

            // Otwieramy formularz podgladu i przekazujemy do niego dane
            Form_podglad_danych podgladForm = new Form_podglad_danych(selectedUser);
            this.Close();
            podgladForm.Show();
        }

        private void btn_nadaj_uprawnienia_Click(object sender, EventArgs e)
        {
            if (dtGrdVw_lista_uż.SelectedRows.Count == 0)
            {
                MessageBox.Show("Proszę wybrać użytkownika.", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtGrdVw_lista_uż.SelectedRows.Count > 1)
            {
                MessageBox.Show("Możesz wybrać tylko jednego użytkownika!", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int userId = Convert.ToInt32(dtGrdVw_lista_uż.SelectedRows[0].Cells["id"].Value);

            Form_nadawanie_uprawnien form = new Form_nadawanie_uprawnien(userId, this);
            form.ShowDialog();
        }

        private void btn_filtruj_uprawnienia_Click(object sender, EventArgs e)
        {
            Form_filtruj_uprawnienia filtrForm = new Form_filtruj_uprawnienia();
            if (filtrForm.ShowDialog() == DialogResult.OK)
            {
                aktualnieWybraneUprawnienieId = filtrForm.WybraneUprawnienieId;

                Wyszukaj("", aktualnieWybraneUprawnienieId);

                if (aktualnieWybraneUprawnienieId == -1)
                {
                    lbl_filtr_info.Text = "Brak wybranego filtru uprawnień";
                }
                else
                {
                    DataTable permissionNameTable = DBconn.ExecuteQuery(
                        "SELECT name FROM permissions WHERE id = @id;",
                        new MySqlParameter("@id", aktualnieWybraneUprawnienieId)
                    );

                    if (permissionNameTable.Rows.Count > 0)
                    {
                        string permissionName = permissionNameTable.Rows[0]["name"].ToString();
                        lbl_filtr_info.Text = $"Filtruj według: {permissionName}";
                    }
                    else
                    {
                        lbl_filtr_info.Text = "Filtruj według: (nieznane uprawnienie)";
                    }
                }
            }
        }


        private void btn_wyczysc_filtr_Click(object sender, EventArgs e)
        {
            try
            {
                aktualnieWybraneUprawnienieId = -1;
                Wyszukaj("", aktualnieWybraneUprawnienieId);

                lbl_filtr_info.Text = "Brak wybranego filtru uprawnień";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas czyszczenia filtru: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form_lista_uzytkownikow_Load(object sender, EventArgs e)
        {
            var user = Session.CurrentUser;

            if (user != null)
            {
                btn_edycja_użytkownika.Enabled = user.MaUprawnienie("2");
                btn_nadaj_uprawnienia.Enabled = user.MaUprawnienie("4");
            }
            else
            {
                // Możesz dodać logikę awaryjną (np. ukrycie przycisków lub wylogowanie)
                btn_edycja_użytkownika.Enabled = false;
                btn_nadaj_uprawnienia.Enabled = false;
            }
        }
       
    }
}

