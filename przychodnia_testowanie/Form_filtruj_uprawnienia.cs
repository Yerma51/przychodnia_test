﻿using System;
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
    public partial class Form_filtruj_uprawnienia : Form
    {
        public int WybraneUprawnienieId { get; private set; } = -1;
        private Laczenie_z_baza_danych DBconn = new Laczenie_z_baza_danych();

        public Form_filtruj_uprawnienia()
        {
            InitializeComponent();
            WczytajUprawnienia();
        }

        private void WczytajUprawnienia()
        {
            try
            {
                DataTable permissions = DBconn.ExecuteQuery("SELECT id, name FROM permissions;");

                DataTable permissionsWithEmpty = new DataTable();
                permissionsWithEmpty.Columns.Add("id", typeof(int));
                permissionsWithEmpty.Columns.Add("name", typeof(string));

                permissionsWithEmpty.Rows.Add(-1, "Brak");

                
                foreach (DataRow row in permissions.Rows)
                {
                    permissionsWithEmpty.ImportRow(row);
                }

                cmb_uprawnienia.DataSource = permissionsWithEmpty;
                cmb_uprawnienia.DisplayMember = "name";
                cmb_uprawnienia.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas ładowania uprawnień: " + ex.Message);
            }
        }


        private void btn_filtruj_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_anuluj_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_filtruj_Click_1(object sender, EventArgs e)
        {
            if (cmb_uprawnienia.SelectedItem != null)
            {
                int selectedId = Convert.ToInt32(cmb_uprawnienia.SelectedValue);

                if (selectedId == -1)
                {
                    WybraneUprawnienieId = -1;
                }
                else
                {
                    WybraneUprawnienieId = selectedId;
                }

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Wybierz uprawnienie!");
            }
        }

    }
}
