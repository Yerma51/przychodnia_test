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
    public partial class Form_lista_uprawnien : Form
    {

        Laczenie_z_baza_danych DBconn = new Laczenie_z_baza_danych();

        public Form_lista_uprawnien()
        {
            InitializeComponent();
            LoadPermissions();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btn_strona_glowna_Click(object sender, EventArgs e)
        {
            Form_strona_glowna strona = new Form_strona_glowna();
            strona.Show();
            this.Hide();
        }
        private void LoadPermissions()
        {
            string query = @"SELECT id, name AS 'Nazwa', description AS 'Opis' FROM permissions";
            DataTable permissions = DBconn.ExecuteQuery(query);
            dtGrdVw_lista_uprawnien.DataSource = permissions;
        }

        private void dgvListaUprawnien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
