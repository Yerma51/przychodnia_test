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
    public partial class Form_lista_uzytkownikow : Form
    {
        public Form_lista_uzytkownikow()
        {
            InitializeComponent();
            refresh();
        }

        
        void refresh()
        {
            dtGrdVw_lista_uż.Rows.Clear();
            foreach (Użytkownik u in Użytkownik.Użytkownicy)
            {
                int index = dtGrdVw_lista_uż.Rows.Add(u.infoUżytkownik);
                //zmienna index przechowuje indeks nowo dodanego wiersza.
                dtGrdVw_lista_uż.Rows[index].Tag = u;
            }
        }
        private void btn_nowy_użytkow_Click(object sender, EventArgs e)
        {
            Użytkownik nowy_uzytkownik = new Użytkownik();
            Form_profil form = new Form_profil(nowy_uzytkownik);
            DialogResult result = form.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;//Sprawdzenie, czy wynik dialogu jest różny od DialogResult.OK. Jeśli tak, metoda kończy działanie (
            }

            Użytkownik.Użytkownicy.Add(nowy_uzytkownik);
            refresh();

            MessageBox.Show("Użytkownik został dodany pomyślnie!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }



    }
}
