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
    public partial class Form_strona_glowna : Form
    {
        public Form_strona_glowna()
        {
            InitializeComponent();
        }

        private void btn_zarzad_Click(object sender, EventArgs e)
        {
            Form_lista_uzytkownikow form = new Form_lista_uzytkownikow();
            form.Show();
            this.Hide();
        }

        private void btn_zapom_Click(object sender, EventArgs e)
        {
            Form_lista_zapomnianych zapForm = new Form_lista_zapomnianych();
            zapForm.Show();
            this.Hide();
        }
    }
}
