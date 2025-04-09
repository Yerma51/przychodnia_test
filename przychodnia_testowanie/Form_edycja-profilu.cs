using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace przychodnia_testowanie
{
    public partial class Form_Edycja_profilu : Form
    {
        Użytkownik użytkownik1;

        public Form_Edycja_profilu(Użytkownik użytkownik)
        {
            InitializeComponent();
            ZaładujUżytkownikówZBazy(); 

            użytkownik1 = użytkownik;




            txb_login.Text = użytkownik1.Login;
            imie_textBox.Text = użytkownik1.Imię;
            nazwisko_textBox.Text = użytkownik1.Nazwisko;
            plec_comboBox.SelectedItem = użytkownik1.Płec;
            użytkownik1.PlecInt = użytkownik1.Płec == "Mężczyzna" ? 1 : 0;
            dataUrodzenia_dateTimePicker.MinDate = new DateTime(1900, 1, 1);
            dataUrodzenia_dateTimePicker.MaxDate = DateTime.Today;
            if (użytkownik1.Data_urodzenia < dataUrodzenia_dateTimePicker.MinDate || użytkownik1.Data_urodzenia > dataUrodzenia_dateTimePicker.MaxDate)
            {
                dataUrodzenia_dateTimePicker.Value = DateTime.Today;
            }
            else
            {
                dataUrodzenia_dateTimePicker.Value = użytkownik1.Data_urodzenia;
            }

            pesel_textBox.Text = użytkownik1.Pesel;
            mail_textBox.Text = użytkownik1.Adres_email;
            miejcowosc_textBox.Text = użytkownik1.Miejscowość;
            ulica_textBox.Text = użytkownik1.Ulica;
            numerPosesji_textBox.Text = użytkownik1.Numer_pos;
            numerLokalu_textBox.Text = użytkownik1.Numer_lokalu;
            kodPocztowy_textBox.Text = użytkownik1.Kod_pocztowy;
            numerTelefonu_textBox.Text = użytkownik1.Numer_telefonu;
        }

        private bool ValidateForm()
        {
            List<Użytkownik> usersList = Użytkownik.Użytkownicy;

            // Sprawdzenie wymaganych pól
            if (string.IsNullOrWhiteSpace(txb_login.Text) ||
                string.IsNullOrWhiteSpace(imie_textBox.Text) ||
                string.IsNullOrWhiteSpace(nazwisko_textBox.Text) ||
                string.IsNullOrWhiteSpace(miejcowosc_textBox.Text) ||
                string.IsNullOrWhiteSpace(kodPocztowy_textBox.Text) ||
                string.IsNullOrWhiteSpace(numerPosesji_textBox.Text) ||
                string.IsNullOrWhiteSpace(pesel_textBox.Text) ||
                string.IsNullOrWhiteSpace(mail_textBox.Text) ||
                string.IsNullOrWhiteSpace(numerTelefonu_textBox.Text) ||
                plec_comboBox.SelectedItem == null) // Płeć jest polem wymaganym
            {
                MessageBox.Show("Wypełnij wszystkie wymagane pola", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //login
            if (!Validator.IsValidLogin(txb_login.Text, usersList, użytkownik1))
            {
                MessageBox.Show("Podany login już istnieje!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Sprawdzenie poprawności adresu e-mail
            if (!Validator.IsValidEmail(mail_textBox.Text))
            {
                MessageBox.Show("Nieprawidłowy adres e-mail!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Sprawdzenie unikalności adresu e-mail
            if (!Validator.IsUniqueEmail(mail_textBox.Text, usersList, użytkownik1))
            {
                MessageBox.Show("Podany adres e-mail już istnieje!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Sprawdzenie unikalności PESEL       

            if (!Validator.CzyUnikalnyPesel(pesel_textBox.Text, usersList, użytkownik1))
            {
                MessageBox.Show("Użytkownik z takim PESEL już istnieje.");
                return false;
            }


            // Sprawdzenie poprawności kodu pocztowego
            if (!Validator.IsValidPostalCode(kodPocztowy_textBox.Text))
            {
                MessageBox.Show("Proszę wpisać kod pocztowy w formacie 00-000", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Sprawdzenie poprawności numeru telefonu
            if (!Validator.IsValidPhoneNumber(numerTelefonu_textBox.Text))
            {
                MessageBox.Show("Numer telefonu musi zawierać dokładnie 9 cyfr!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Sprawdzenie poprawności numeru PESEL
            if (!Validator.IsValidPESEL(pesel_textBox.Text, plec_comboBox.SelectedItem.ToString()))
            {
                MessageBox.Show("Numer PESEL jest nieprawidłowy!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Sprawdzenie zgodności daty urodzenia z PESEL
            if (!Validator.DoesBirthDateMatchPESEL(pesel_textBox.Text, dataUrodzenia_dateTimePicker.Value))
            {
                MessageBox.Show("Data urodzenia nie zgadza się z numerem PESEL!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btn_anuluj_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void button1_zapisz_Click(object sender, EventArgs e)
        {
            List<Użytkownik> usersList = Użytkownik.PobierzWszystkichUżytkownikówZBazy();

            if (ValidateForm())
            {
                użytkownik1.Login = txb_login.Text;
                użytkownik1.Imię = imie_textBox.Text;
                użytkownik1.Nazwisko = nazwisko_textBox.Text;
                użytkownik1.Płec = plec_comboBox.SelectedItem.ToString();
                użytkownik1.PlecInt = użytkownik1.Płec == "Mężczyzna" ? 1 : 0;

                użytkownik1.Data_urodzenia = dataUrodzenia_dateTimePicker.Value;
                użytkownik1.Pesel = pesel_textBox.Text;
                użytkownik1.Adres_email = mail_textBox.Text;
                użytkownik1.Miejscowość = miejcowosc_textBox.Text;
                użytkownik1.Ulica = ulica_textBox.Text;
                użytkownik1.Numer_pos = numerPosesji_textBox.Text;
                użytkownik1.Numer_lokalu = numerLokalu_textBox.Text;
                użytkownik1.Kod_pocztowy = kodPocztowy_textBox.Text;
                użytkownik1.Numer_telefonu = numerTelefonu_textBox.Text;

                DialogResult = DialogResult.OK;
                Close();

            }

        }

        private void btn_lista_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ZaładujUżytkownikówZBazy()
        {
            DataTable dt = new Laczenie_z_baza_danych().ExecuteQuery(
                "SELECT u.id, u.login, u.email, u.phonenumber, p.name, p.lastname, p.pesel, p.city, p.postcode, p.street, p.house_number, p.apartment_number, p.gender, p.birth_date FROM users u JOIN patients p ON u.id = p.user_id"
            );

            Użytkownik.Użytkownicy.Clear(); // Żeby nie było dublikatów

            foreach (DataRow row in dt.Rows)
            {
                DateTime dataUrodzenia;
                string rawDate = row["birth_date"].ToString();

                if (!string.IsNullOrEmpty(rawDate) && DateTime.TryParse(rawDate, out dataUrodzenia))
                {
                    
                }
                else
                {
                    dataUrodzenia = DateTime.Today; 
                }

                Użytkownik.Użytkownicy.Add(new Użytkownik
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
                });
            }
        }


    }
}
