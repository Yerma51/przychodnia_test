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
            this.Activated += Form_strona_glowna_Activated;

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

        private void btn_uprawn_Click_Click(object sender, EventArgs e)
        {
            Form_lista_uprawnien form = new Form_lista_uprawnien();
            form.Show();
            this.Hide();
        }

        private void Form_strona_glowna_Load(object sender, EventArgs e)
        {
            var user = Session.CurrentUser;

            if (user != null)
            {
                btn_zarzad.Enabled = user.MaUprawnienie("1") || user.MaUprawnienie("2") || user.MaUprawnienie("4");
                btn_uprawn.Enabled = user.MaUprawnienie("3");
                btn_zapom.Enabled = true; // доступна всегда
            }

        }

        public void OdswiezUprawnienia()
        {
            var user = Session.CurrentUser;

            if (user != null)
            {
                btn_zarzad.Enabled = user.MaUprawnienie("1") || user.MaUprawnienie("2") || user.MaUprawnienie("4");
                btn_uprawn.Enabled = user.MaUprawnienie("3");
                btn_zapom.Enabled = true;
            }
        }
        private void Form_strona_glowna_Activated(object sender, EventArgs e)
        {
            OdswiezUprawnienia(); // odświeża przy każdym powrocie
        }

        private void button_mojProfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form_moj_profil().Show();
        }
    }
}
