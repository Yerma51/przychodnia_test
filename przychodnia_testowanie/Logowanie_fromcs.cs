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
using ZstdSharp.Unsafe;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace przychodnia_testowanie
{
    public partial class Logowanie_fromcs: Form
    {
        public Logowanie_fromcs()
        {
            InitializeComponent();
        }

        private void button_zaloguj_Click(object sender, EventArgs e)
        {


            string login = textBox_login.Text.Trim();
            //string pass = textBox2.Text.Trim();

            /*if (string.IsNullOrEmpty(login) && string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Proszę podać login i hasło");
                return;
            }*/
            if (string.IsNullOrEmpty(login))
            {
                MessageBox.Show("Proszę podać login");
                return;
            }
            /*else if (string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Proszę podać hasło");
                return;
            }*/

            try
            {
                string checkLoginQuery = "SELECT COUNT(*) FROM users WHERE login = @login";
                MySqlParameter[] checkParams = {
            new MySqlParameter("@login", login)
        };

                DataTable checkTable = new Laczenie_z_baza_danych().ExecuteQuery(checkLoginQuery, checkParams);
                int count = Convert.ToInt32(checkTable.Rows[0][0]);

                if (count == 0)
                {
                    MessageBox.Show("Podany login nie istnieje w systemie");
                    return;
                }

                // SQL: проверка логина и пароля + загрузка данных пациента
                string query = @"
            SELECT 
                u.id, u.login, u.email, u.phonenumber,
                p.name, p.lastname, p.pesel, p.city, p.postcode, 
                p.street, p.house_number, p.apartment_number, 
                p.gender, p.birth_date 
            FROM users u
            JOIN patients p ON u.id = p.user_id
            WHERE u.login = @login";

                MySqlParameter[] parameters = {
            new MySqlParameter("@login", login)

        };

                DataTable dt = new Laczenie_z_baza_danych().ExecuteQuery(query, parameters);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    DateTime dataUrodzenia;
                    string rawDate = row["birth_date"].ToString();
                    if (!DateTime.TryParse(rawDate, out dataUrodzenia))
                        dataUrodzenia = DateTime.Today;

                    Użytkownik user = new Użytkownik
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
                        Płec = row["gender"].ToString(),
                        Data_urodzenia = dataUrodzenia
                    };

                    // Шаг 3: Загрузка прав доступа
                    string uprawnieniaQuery = "SELECT permission_id FROM user_permissions WHERE user_id = @id";
                    MySqlParameter[] uprawnieniaParams = {
                new MySqlParameter("@id", user.Id)
            };

                    DataTable permTable = new Laczenie_z_baza_danych().ExecuteQuery(uprawnieniaQuery, uprawnieniaParams);
                    foreach (DataRow permRow in permTable.Rows)
                    {
                        user.Uprawnienia.Add(permRow["permission_id"].ToString());
                    }

                    Session.CurrentUser = user;

                    MessageBox.Show("Udane logowanie");
                    this.Hide();
                    new Form_strona_glowna().Show();
                }
                else
                {
                    MessageBox.Show("Błąd: użytkownik istnieje, ale nie można załadować danych");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd połączenia z bazą danych: " + ex.Message);
            }
        }
    }
}
