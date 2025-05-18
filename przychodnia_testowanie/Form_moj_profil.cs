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
    public partial class Form_moj_profil : Form
    {
        public Form_moj_profil()
        {
            InitializeComponent();
        }


        private void Form_moj_profil_Load(object sender, EventArgs e)
        {
            var user = Session.CurrentUser;
            if (user != null)
            {
                imie_textBox.Text = user.Imię;
                nazwisko_textBox.Text = user.Nazwisko;
                txb_login.Text = user.Login;
                textBox_haslo.Text = user.Password;
                mail_textBox.Text = user.Adres_email;
                numerTelefonu_textBox.Text = user.Numer_telefonu;
                miejcowosc_textBox.Text = user.Miejscowość;
                ulica_textBox.Text = user.Ulica;
                numerPosesji_textBox.Text = user.Numer_pos;
                numerLokalu_textBox.Text = user.Numer_lokalu;
                kodPocztowy_textBox.Text = user.Kod_pocztowy;
                pesel_textBox.Text = user.Pesel;

                plec_comboBox.Items.Add("Kobieta");
                plec_comboBox.Items.Add("Mężczyzna");

                string plecTekstowa = user.Płec == "1" ? "Mężczyzna" : "Kobieta";
                plec_comboBox.SelectedItem = plecTekstowa;

                dataUrodzenia_dateTimePicker.MinDate = new DateTime(1900, 1, 1);
                dataUrodzenia_dateTimePicker.MaxDate = DateTime.Today;

                if (user.Data_urodzenia >= dataUrodzenia_dateTimePicker.MinDate &&
                    user.Data_urodzenia <= dataUrodzenia_dateTimePicker.MaxDate)
                {
                    dataUrodzenia_dateTimePicker.Value = user.Data_urodzenia;
                }
                else
                {
                    dataUrodzenia_dateTimePicker.Value = DateTime.Today;
                }
                imie_textBox.ReadOnly = true;
                nazwisko_textBox.ReadOnly = true;
                txb_login.ReadOnly = true;
                textBox_haslo.ReadOnly = true;
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
        }

        private void button_wylog_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Czy na pewno chcesz się wylogować?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Session.CurrentUser = null;

                this.Hide();
                new Logowanie_fromcs().Show();
            }
        }

        private void button_pow_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form_strona_glowna().Show();
        }
    }
}
