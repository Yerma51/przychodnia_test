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
            plec_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;


            plec_comboBox.SelectedIndex = 2;
        }

       

        private void Form_profil_Load(object sender, EventArgs e)
        {
            {
                txb_login.Text = użytkownik.Login;
                imie_textBox.Text = użytkownik.Imię;
                nazwisko_textBox.Text = użytkownik.Nazwisko;
                plec_comboBox.SelectedItem = użytkownik.Płec;
                dataUrodzenia_dateTimePicker.MinDate = new DateTime(1900, 1, 1);
                dataUrodzenia_dateTimePicker.MaxDate = DateTime.Today;
                // Sprawdzenie, czy data naprawy mieści się w zakresie
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
        } 
        private void button1_zapisz_Click(object sender, EventArgs e)
        {
            użytkownik.Login = txb_login.Text;
            użytkownik.Imię = imie_textBox.Text;
            użytkownik.Nazwisko = nazwisko_textBox.Text;
            użytkownik.Płec = plec_comboBox.SelectedItem.ToString();
            użytkownik.Data_urodzenia = dataUrodzenia_dateTimePicker.Value;
            użytkownik.Pesel = pesel_textBox.Text;
            użytkownik.Adres_email = mail_textBox.Text;
            użytkownik.Miejscowość = miejcowosc_textBox.Text;
            użytkownik.Ulica = ulica_textBox.Text;
            użytkownik.Numer_pos = numerPosesji_textBox.Text;
            użytkownik.Numer_lokalu = numerLokalu_textBox.Text;
            użytkownik.Kod_pocztowy = kodPocztowy_textBox.Text;
            użytkownik.Numer_telefonu = numerTelefonu_textBox.Text;

        }

        private void btn_lista_Click(object sender, EventArgs e)
        {
            (new Form_lista_uzytkownikow()).ShowDialog();
            //wyświetlić ten formularz w trybie modalnym.
        }
    }
}
