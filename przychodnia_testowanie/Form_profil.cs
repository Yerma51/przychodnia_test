﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace przychodnia_testowanie
{
    public partial class Form_profil : Form
    {
        Użytkownik użytkownik;
        //Pole przechowujące obiekt Użytkownik, który będzie edytowany.

        internal Form_profil(Użytkownik użytkownik)
        {
            InitializeComponent();
            this.użytkownik = użytkownik;
            InitializePłeć();
        }

        void InitializePłeć()
        {
            plec_comboBox.Items.Clear();
            plec_comboBox.Items.Add("Mężczyzna");
            plec_comboBox.Items.Add("Kobieta");
            plec_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            plec_comboBox.SelectedIndex = 0;
        }



        private void Form_profil_Load(object sender, EventArgs e)
        {
            ZaładujUżytkownikówZBazy();


            txb_login.Text = użytkownik.Login;
            textBox_haslo.Text = użytkownik.Password;
            imie_textBox.Text = użytkownik.Imię;
            nazwisko_textBox.Text = użytkownik.Nazwisko;
            plec_comboBox.SelectedItem = użytkownik.Płec;

            dataUrodzenia_dateTimePicker.MinDate = new DateTime(1900, 1, 1);
            dataUrodzenia_dateTimePicker.MaxDate = DateTime.Today;
            if (użytkownik.Data_urodzenia < dataUrodzenia_dateTimePicker.MinDate || użytkownik.Data_urodzenia > dataUrodzenia_dateTimePicker.MaxDate)
            {
                dataUrodzenia_dateTimePicker.Value = DateTime.Today;
            }
            else
            {
                dataUrodzenia_dateTimePicker.Value = użytkownik.Data_urodzenia;
            }

            pesel_textBox.Text = użytkownik.Pesel;
            mail_textBox.Text = użytkownik.Adres_email;
            miejcowosc_textBox.Text = użytkownik.Miejscowość;
            ulica_textBox.Text = użytkownik.Ulica;
            numerPosesji_textBox.Text = użytkownik.Numer_pos;
            numerLokalu_textBox.Text = użytkownik.Numer_lokalu;
            kodPocztowy_textBox.Text = użytkownik.Kod_pocztowy;
            numerTelefonu_textBox.Text = użytkownik.Numer_telefonu;

        }
        private void button1_zapisz_Click(object sender, EventArgs e)
        {
            List<Użytkownik> usersList = Użytkownik.Użytkownicy;

            // Sprawdzenie wymaganych pól
            if (string.IsNullOrWhiteSpace(txb_login.Text) ||
                string.IsNullOrWhiteSpace(textBox_haslo.Text) ||
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
                return; // Nie zamykamy formularza
            }

            // Sprawdzenie poprawności adresu e-mail
            if (!Validator.IsValidEmail(mail_textBox.Text))
            {
                MessageBox.Show("Nieprawidłowy adres e-mail!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Sprawdzenie unikalności loginu
            if (!Validator.IsValidLogin(txb_login.Text, usersList, null)) // null, bo это новый użytkownik
            {
                MessageBox.Show("Podany login już istnieje!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Validator.IsValidPassword(textBox_haslo.Text))
            {
                MessageBox.Show("Hasło musi mieć od 8 do 15 znaków i zawierać co najmniej jedną wielką literę, małą literę, cyfrę oraz znak specjalny (-, _, !, *, #, $, &)", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Sprawdzenie unikalności email
            if (!Validator.IsUniqueEmail(mail_textBox.Text, usersList, null))
            {
                MessageBox.Show("Podany adres e-mail już istnieje!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Sprawdzenie unikalności PESEL
            if (!Validator.CzyUnikalnyPesel(pesel_textBox.Text, usersList, null))
            {
                MessageBox.Show("Podany numer PESEL już istnieje!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }




            // Sprawdzenie poprawności numeru kodu pocztowege
            if (!Validator.IsValidPostalCode(kodPocztowy_textBox.Text))
            {
                MessageBox.Show("Proszę wpisac kod pocztowy w postaci 00-000", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Sprawdzenie poprawności numeru telefonu
            if (!Validator.IsValidPhoneNumber(numerTelefonu_textBox.Text))
            {
                MessageBox.Show("Numer telefonu musi zawierać dokładnie 9 cyfr!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Sprawdzenie poprawności numeru PESEL
            if (!Validator.IsValidPESEL(pesel_textBox.Text, plec_comboBox.SelectedItem.ToString()))
            {
                MessageBox.Show("Numer PESEL jest nieprawidłowy!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Validator.DoesBirthDateMatchPESEL(pesel_textBox.Text, dataUrodzenia_dateTimePicker.Value))
            {
                MessageBox.Show("Data urodzenia nie zgadza się z numerem PESEL!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Jeśli wszystkie walidacje zostały zaliczone, zapisujemy dane i zamykamy formularz
            użytkownik.Login = txb_login.Text.Trim();
            użytkownik.Password = textBox_haslo.Text.Trim();
            użytkownik.Imię = imie_textBox.Text.Trim();
            użytkownik.Nazwisko = nazwisko_textBox.Text.Trim();
            użytkownik.Płec = plec_comboBox.SelectedItem.ToString();
            użytkownik.PlecInt = użytkownik.Płec == "Mężczyzna" ? 1 : 0;
            użytkownik.Data_urodzenia = dataUrodzenia_dateTimePicker.Value;
            użytkownik.Pesel = pesel_textBox.Text.Trim();
            użytkownik.Adres_email = mail_textBox.Text.Trim();
            użytkownik.Miejscowość = miejcowosc_textBox.Text.Trim();
            użytkownik.Ulica = ulica_textBox.Text.Trim();
            użytkownik.Numer_pos = numerPosesji_textBox.Text.Trim();
            użytkownik.Numer_lokalu = numerLokalu_textBox.Text.Trim();
            użytkownik.Kod_pocztowy = kodPocztowy_textBox.Text.Trim();
            użytkownik.Numer_telefonu = numerTelefonu_textBox.Text.Trim();





            // Zamykamy formularz po zapisaniu danych
            this.DialogResult = DialogResult.OK;
            this.Close();




        }
        private void ZaładujUżytkownikówZBazy()
        {
            DataTable dt = new Laczenie_z_baza_danych().ExecuteQuery(
                "SELECT u.id, u.login, u.password, u.email, u.phonenumber, p.name, p.lastname, p.pesel, p.city, p.postcode, p.street, p.house_number, p.apartment_number, p.gender, p.birth_date FROM users u JOIN patients p ON u.id = p.user_id"
            );

            Użytkownik.Użytkownicy.Clear();

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
                    Data_urodzenia = dataUrodzenia
                });
            }
        }


        private void btn_lista_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_anuluj_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dane nie zostały zapisane", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }


    }
}
