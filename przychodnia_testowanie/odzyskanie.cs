using System;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace przychodnia_testowanie
{
    public partial class odzyskanie : Form
    {
        private Laczenie_z_baza_danych db = new Laczenie_z_baza_danych();
        public odzyskanie()
        {
            InitializeComponent();
        }

        private void button_odzyskaj_Click(object sender, EventArgs e)
        {
            string email = textBox_email.Text.Trim();
            string login = textBox_login.Text.Trim();

            if (string.IsNullOrEmpty(login))
            {
                MessageBox.Show("Wprowadź login.");
                return;
            }

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Wprowadź e-mail.");
                return;
            }

            if (!Validator.IsValidEmail(email))
            {
                MessageBox.Show("“Wprowadź e-mail w odpowiednim formacie");
                return;
            }

            if (!EmailExists(email))
            {
                MessageBox.Show("Podany email nie istnieje w systemie.");
                return;
            }

            if (!LoginEmailMatch(login, email))
            {
                MessageBox.Show("Login nie jest powiązany z podanym emailem.");
                return;
            }

            

           

            string tempPassword = GeneratePassword();
            DateTime expiryTime = DateTime.Now.AddMinutes(15);

            if (SaveTemporaryPassword(email, tempPassword, expiryTime))  // przedyłamy zwykłe hasło
            {
                if (SendEmail(email, tempPassword))
                {
                    MessageBox.Show("Tymczasowe hasło zostało wysłane na email i będzie ważne przez 15 minut.");
                    this.Hide();
                    Logowanie_fromcs formLogowanie = new Logowanie_fromcs();
                    formLogowanie.Show();
                }
                else
                {
                    MessageBox.Show("Wystąpił błąd podczas wysyłania emaila.");
                }
            }
        }

        private bool LoginEmailMatch(string login, string email)
        {
            string query = "SELECT COUNT(*) FROM users WHERE login = @login AND email = @email";
            MySqlParameter[] parameters = {
        new MySqlParameter("@login", login),
        new MySqlParameter("@email", email)
    };

            DataTable result = db.ExecuteQuery(query, parameters);
            return result.Rows.Count > 0 && Convert.ToInt32(result.Rows[0][0]) > 0;
        }


        private bool EmailExists(string email)
        {
            string query = "SELECT COUNT(*) FROM users WHERE email = @email";
            MySqlParameter[] parameters = { new MySqlParameter("@email", email) };

            DataTable result = db.ExecuteQuery(query, parameters);
            return result.Rows.Count > 0 && Convert.ToInt32(result.Rows[0][0]) > 0;
        }



        private bool SaveTemporaryPassword(string email, string plainPassword, DateTime expiry)
        {
            // Pobierz user_id i aktualne hasło użytkownika
            string getUserQuery = "SELECT id, password FROM users WHERE email = @email";
            DataTable result = db.ExecuteQuery(getUserQuery, new MySqlParameter("@email", email));
            if (result.Rows.Count == 0)
                return false;

            int userId = Convert.ToInt32(result.Rows[0]["id"]);
            string oldPassword = Convert.ToString(result.Rows[0]["password"]);

            // Dodaj stare hasło do historii (jeśli istnieje)
            if (!string.IsNullOrEmpty(oldPassword))
            {
                string insertOldPassQuery = "INSERT INTO password_history (user_id, password) VALUES (@userId, @password)";
                MySqlParameter[] insertOldParams = {
            new MySqlParameter("@userId", userId),
            new MySqlParameter("@password", oldPassword)
        };
                db.ExecuteQuery(insertOldPassQuery, insertOldParams);
            }

            // Zaktualizuj hasło użytkownika na tymczasowe i ustaw datę wygaśnięcia
            string updateQuery = "UPDATE users SET password = @password, password_expiry = @expiry WHERE email = @email";
            MySqlParameter[] updateParams = {
        new MySqlParameter("@password", plainPassword),
        new MySqlParameter("@expiry", expiry),
        new MySqlParameter("@email", email)
    };
            db.ExecuteQuery(updateQuery, updateParams);

            // Dodaj tymczasowe hasło do historii
            string insertTempPassQuery = "INSERT INTO password_history (user_id, password) VALUES (@userId, @password)";
            MySqlParameter[] insertTempParams = {
        new MySqlParameter("@userId", userId),
        new MySqlParameter("@password", plainPassword)
    };
            db.ExecuteQuery(insertTempPassQuery, insertTempParams);

            // Usuń stare wpisy, pozostawiając tylko 3 najnowsze
            string deleteOldQuery = @"
        DELETE FROM password_history 
        WHERE user_id = @userId 
          AND id NOT IN (
              SELECT id FROM (
                  SELECT id FROM password_history 
                  WHERE user_id = @userId 
                  ORDER BY created_at DESC 
                  LIMIT 3
              ) AS latest
          );";
            db.ExecuteQuery(deleteOldQuery, new MySqlParameter("@userId", userId));

            return true;
        }





        private string GeneratePassword()
        {
            Random rand = new Random();
            string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lower = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string specials = "-_!*#$&";

            StringBuilder password = new StringBuilder();

            for (int i = 0; i < 3; i++) password.Append(upper[rand.Next(upper.Length)]);
            for (int i = 0; i < 3; i++) password.Append(lower[rand.Next(lower.Length)]);
            for (int i = 0; i < 2; i++) password.Append(digits[rand.Next(digits.Length)]);
            for (int i = 0; i < 2; i++) password.Append(specials[rand.Next(specials.Length)]);

            return new string(password.ToString().ToCharArray().OrderBy(x => rand.Next()).ToArray());
        }


        /* private string HashPassword(string password)
         {
             using (SHA256 sha = SHA256.Create())
             {
                 byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                 return BitConverter.ToString(bytes).Replace("-", "").ToLower();
             }
         }*/



        private bool SendEmail(string toEmail, string tempPassword)
        {
            try
            {
                string fromEmail = "y.yeromin69@gmail.com";
                string fromPassword = "vkqrskazwtapxrke";

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(fromEmail);
                mail.To.Add(toEmail);
                mail.Subject = "Tymczasowe hasło";
                mail.Body = $"Twoje tymczasowe hasło to: {tempPassword}\nHasło ważne przez 15 minut.";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential(fromEmail, fromPassword);
                smtp.EnableSsl = true;
                smtp.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd wysyłki emaila: " + ex.Message);
                return false;
            }
        }

        private void button_anuluj_Click(object sender, EventArgs e)
        {
            this.Hide();
            Logowanie_fromcs formLogowanie = new Logowanie_fromcs();
            formLogowanie.Show();
        }
    }
}
