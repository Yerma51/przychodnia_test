using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace przychodnia_testowanie
{
    public partial class Form_podglad_danych : Form
    {
        Użytkownik użytkownik1;

        public Form_podglad_danych(Użytkownik użytkownik)
        {
            InitializeComponent();
            użytkownik1 = użytkownik;
            plec_comboBox.Items.Add("Kobieta");
            plec_comboBox.Items.Add("Mężczyzna");

            if (użytkownik1.Płec == "1" || użytkownik1.Płec == "Mężczyzna")
            {
                plec_comboBox.SelectedItem = "Mężczyzna";
            }
            else
            {
                plec_comboBox.SelectedItem = "Kobieta";
            }

            login_textBox.Text = użytkownik1.Login;
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

            imie_textBox.ReadOnly = true;
            nazwisko_textBox.ReadOnly = true;
            login_textBox.ReadOnly = true;
            mail_textBox.ReadOnly = true;
            numerTelefonu_textBox.ReadOnly = true;
            pesel_textBox.ReadOnly = true;
            miejcowosc_textBox.ReadOnly = true;
            kodPocztowy_textBox.ReadOnly = true;
            ulica_textBox.ReadOnly = true;
            numerPosesji_textBox.ReadOnly = true;
            numerLokalu_textBox.ReadOnly = true;
            plec_comboBox.Enabled = false;
            dataUrodzenia_dateTimePicker.Enabled = false;

        }

        private void btn_lista_uzytkownikow_Click(object sender, EventArgs e)
        {
            Form_lista_uzytkownikow form = new Form_lista_uzytkownikow();
            form.Show();
            this.Close();
        }
    }
}
