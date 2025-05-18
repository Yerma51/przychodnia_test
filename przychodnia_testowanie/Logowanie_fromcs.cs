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
    public partial class Logowanie_fromcs : Form
    {
        public Logowanie_fromcs()
        {
            InitializeComponent();
        }

        private void button_zaloguj_Click(object sender, EventArgs e)
        {
            string login = textBox_login.Text.Trim();
            string password = textBox_haslo.Text.Trim();

            if (string.IsNullOrEmpty(login) && string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Proszę podać login i hasło");
                return;
            }
            if (string.IsNullOrEmpty(login))
            {
                MessageBox.Show("Proszę podać login");
                return;
            }
            else if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Proszę podać hasło");
                return;
            }

            try
            {
                // Sprawdzenie czy istnieje użytkownik
                string userCheckQuery = "SELECT id, failed_attempts, lockout_time FROM users WHERE login = @login";
                MySqlParameter[] checkParams = { new MySqlParameter("@login", login) };
                DataTable checkResult = new Laczenie_z_baza_danych().ExecuteQuery(userCheckQuery, checkParams);

                if (checkResult.Rows.Count == 0)
                {
                    MessageBox.Show("Podany login nie istnieje w systemie.");
                    return;
                }

                DataRow checkRow = checkResult.Rows[0];
                int userId = Convert.ToInt32(checkRow["id"]);
                int failedAttempts = checkRow["failed_attempts"] != DBNull.Value ? Convert.ToInt32(checkRow["failed_attempts"]) : 0;
                DateTime? lockoutTime = checkRow["lockout_time"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(checkRow["lockout_time"]) : null;

                if (lockoutTime != null && DateTime.Now < lockoutTime)
                {
                    MessageBox.Show("Konto jest zablokowane. Spróbuj ponownie po " + lockoutTime.Value.ToString("HH:mm:ss"));
                    return;
                }

                // Sprawdzenie loginu i hasła 
                string loginQuery = @"
            SELECT u.*, p.* 
            FROM users u
            JOIN patients p ON u.id = p.user_id
            WHERE u.login = @login AND u.password = @password";

                MySqlParameter[] loginParams = {
            new MySqlParameter("@login", login),
            new MySqlParameter("@password", password)
        };

                DataTable dt = new Laczenie_z_baza_danych().ExecuteQuery(loginQuery, loginParams);

                if (dt.Rows.Count > 0)
                {
                    // udane logowanie
                    DataRow row = dt.Rows[0];

                    DateTime.TryParse(row["birth_date"].ToString(), out DateTime birthDate);
                    Użytkownik user = new Użytkownik
                    {
                        Id = Convert.ToInt32(row["id"]),
                        Login = row["login"].ToString(),
                        Password = row["password"].ToString(),
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
                        Data_urodzenia = birthDate
                    };

                    // ładowanie uprawnień
                    string uprawnieniaQuery = "SELECT permission_id FROM user_permissions WHERE user_id = @id";
                    MySqlParameter[] uprawnieniaParams = { new MySqlParameter("@id", user.Id) };
                    DataTable permTable = new Laczenie_z_baza_danych().ExecuteQuery(uprawnieniaQuery, uprawnieniaParams);
                    foreach (DataRow permRow in permTable.Rows)
                        user.Uprawnienia.Add(permRow["permission_id"].ToString());

                    Session.CurrentUser = user;

                    // resetowanie udanej próby logowania
                    string resetAttemptsQuery = "UPDATE users SET failed_attempts = 0, lockout_time = NULL WHERE id = @id";
                    MySqlParameter[] resetParams = { new MySqlParameter("@id", user.Id) };
                    new Laczenie_z_baza_danych().ExecuteQuery(resetAttemptsQuery, resetParams);

                    // spawdzenie tymczasowego hasła
                    if (row["password_expiry"] != DBNull.Value)
                    {
                        DateTime.TryParse(row["password_expiry"].ToString(), out DateTime expiryTime);

                        if (DateTime.Now <= expiryTime)
                        {
                            MessageBox.Show("Zalogowano tymczasowym hasłem. Zmień hasło.");
                            this.Hide();
                            new Nowe_haslo(user.Id).Show();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Hasło tymczasowe wygasło. Skontaktuj się z administratorem lub zresetuj hasło.");
                            Session.CurrentUser = null;
                            return;
                        }
                    }

                    MessageBox.Show("Udane logowanie.");
                    this.Hide();
                    new Form_strona_glowna().Show();
                }
                else
                {
                    //nieprawidłowe hasło +1próba
                    failedAttempts++;
                    MySqlParameter[] updateParams;

                    if (failedAttempts >= 3)
                    {
                        string lockQuery = "UPDATE users SET failed_attempts = @fa, lockout_time = @lt WHERE login = @login";
                        updateParams = new MySqlParameter[]
                        {
                    new MySqlParameter("@fa", failedAttempts),
                    new MySqlParameter("@lt", DateTime.Now.AddMinutes(15)),
                    new MySqlParameter("@login", login)
                        };
                        MessageBox.Show("Błąd logowania. Konto zablokowane na 15 minut.");
                    }
                    else
                    {
                        string failQuery = "UPDATE users SET failed_attempts = @fa WHERE login = @login";
                        updateParams = new MySqlParameter[]
                        {
                    new MySqlParameter("@fa", failedAttempts),
                    new MySqlParameter("@login", login)
                        };
                        MessageBox.Show("Błędne hasło. Próba: " + failedAttempts + "/3");
                    }

                    new Laczenie_z_baza_danych().ExecuteQuery(failedAttempts >= 3 ?
                        "UPDATE users SET failed_attempts = @fa, lockout_time = @lt WHERE login = @login" :
                        "UPDATE users SET failed_attempts = @fa WHERE login = @login", updateParams);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd połączenia z bazą danych: " + ex.Message);
            }
        }



        private void button_nie_pamietam_Click(object sender, EventArgs e)
        {
            this.Hide();
            new odzyskanie().Show();
        }
    }
}
