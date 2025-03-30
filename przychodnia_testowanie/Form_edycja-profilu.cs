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
            użytkownik1 = użytkownik;

            txb_login.Text = użytkownik1.Login;
            imie_textBox.Text = użytkownik1.Imię;
            nazwisko_textBox.Text = użytkownik1.Nazwisko;
            plec_comboBox.SelectedItem = użytkownik1.Płec;
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
            // Sprawdzamy, czy wszystkie wymagane pola są wypełnione
            if (string.IsNullOrWhiteSpace(txb_login.Text) ||
                string.IsNullOrWhiteSpace(imie_textBox.Text) ||
                string.IsNullOrWhiteSpace(nazwisko_textBox.Text) ||
                string.IsNullOrWhiteSpace(mail_textBox.Text) ||
                string.IsNullOrWhiteSpace(numerTelefonu_textBox.Text) ||
                string.IsNullOrWhiteSpace(pesel_textBox.Text) ||
                string.IsNullOrWhiteSpace(kodPocztowy_textBox.Text))
            {
                MessageBox.Show("Wszystkie pola muszą być wypełnione.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Walidacja numeru telefonu (9 cyfr)
            string phoneNumber = numerTelefonu_textBox.Text.Trim();
            if (!Regex.IsMatch(phoneNumber, @"^\d{9}$"))
            {
                MessageBox.Show("Numer telefonu musi zawierać dokładnie 9 cyfr.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Walidacja e-maila (musi zawierać znak "@" i kropkę)
            string email = mail_textBox.Text.Trim();
            if (!Regex.IsMatch(email, @"^[^@]+@[^@]+\.[^@]+$"))
            {
                MessageBox.Show("Adres e-mail jest niepoprawny.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Walidacja PESEL (11 cyfr)
            string pesel = pesel_textBox.Text.Trim();
            if (!Regex.IsMatch(pesel, @"^\d{11}$"))
            {
                MessageBox.Show("PESEL musi zawierać dokładnie 11 cyfr.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Walidacja kodu pocztowego (format "**-***")
            string postcode = kodPocztowy_textBox.Text.Trim();
            if (!Regex.IsMatch(postcode, @"^\d{2}-\d{3}$"))
            {
                MessageBox.Show("Kod pocztowy musi być w formacie **-***.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (ValidateForm())
            {
                użytkownik1.Login = txb_login.Text;
                użytkownik1.Imię = imie_textBox.Text;
                użytkownik1.Nazwisko = nazwisko_textBox.Text;
                użytkownik1.Płec = plec_comboBox.SelectedItem.ToString();
                użytkownik1 .Data_urodzenia = dataUrodzenia_dateTimePicker.Value;
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
    }
}
