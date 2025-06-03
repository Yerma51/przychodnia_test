using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace przychodnia_testowanie
{
    public partial class Nowe_haslo : Form
    {
        private int userId;
        private Laczenie_z_baza_danych db = new Laczenie_z_baza_danych();

        public Nowe_haslo(int id)
        {
            InitializeComponent();
            userId = id;
        }



        private bool ZmienHaslo(int id, string noweHaslo)
        {
            string query = "UPDATE users SET password = @password, password_expiry = NULL WHERE id = @id";
            MySqlParameter[] parameters = {
                new MySqlParameter("@password", noweHaslo),
                new MySqlParameter("@id", id)
            };

            new Laczenie_z_baza_danych().ExecuteQuery(query, parameters);
            return true;
        }

        private bool IsPasswordInHistory(int userId, string newPassword)
        {
            string query = @"
            SELECT password FROM password_history
            WHERE user_id = @userId
            ORDER BY created_at DESC
            LIMIT 3";

            MySqlParameter param = new MySqlParameter("@userId", userId);
            DataTable dt = db.ExecuteQuery(query, param);

            foreach (DataRow row in dt.Rows)
            {
                if (row["password"].ToString() == newPassword)
                    return true;
            }
            return false;
        }


        



        private void button_zmien_haslo_Click(object sender, EventArgs e)
        {
            string haslo = textBox_haslo.Text.Trim();
            string powtorzHaslo = textBox_powtorz_haslo.Text.Trim();

            if (string.IsNullOrEmpty(haslo) || string.IsNullOrEmpty(powtorzHaslo))
            {
                MessageBox.Show("Wprowadź i potwierdź nowe hasło.");
                return;
            }

            if (haslo != powtorzHaslo)
            {
                MessageBox.Show("Hasła się nie zgadzają.");
                return;
            }

            if (!Validator.IsValidPassword(haslo))
            {
                MessageBox.Show("“Hasło nie spełnia wymagań. Hasło musi mieć między 8 a 15 znaków i zawierać co najmniej: -wielką literę -małą literę -cyfrę -znak specjalny: -, _, !, *, #, $, & .");
                return;
            }

            if (IsPasswordInHistory(userId, haslo))
            {
                MessageBox.Show("Nowe hasło nie może być takie samo jak jedno z ostatnich trzech haseł.");
                return;
            }

            if (ZmienHaslo(userId, haslo))
            {
                if (Session.CurrentUser != null && Session.CurrentUser.Id == userId)
                {
                    Session.CurrentUser.Password = haslo;
                }
                MessageBox.Show("“Zmieniono hasło");
                this.Hide();
                new Form_strona_glowna().Show();
            }
            else
            {
                MessageBox.Show("Błąd podczas zmiany hasła.");
            }
        }

    }
}
