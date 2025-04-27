using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace przychodnia_testowanie
{

    public partial class Form_nadawanie_uprawnien : Form
    {
        private int _userId;
        Laczenie_z_baza_danych DBconn = new Laczenie_z_baza_danych();
        public Form_nadawanie_uprawnien(int userId)
        {
            InitializeComponent();
            _userId = userId;
            WczytajUprawnienia();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_anuluj_uprawnienia_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_nadawanie_uprawnien_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable permissions = DBconn.ExecuteQuery("SELECT id, name FROM permissions;");

                clb_uprawnienia.Items.Clear();

                foreach (DataRow row in permissions.Rows)
                {
                    string permissionName = row["name"].ToString();
                    int permissionId = Convert.ToInt32(row["id"]);

                    clb_uprawnienia.Items.Add(new PermissionItem(permissionId, permissionName));
                }

                clb_uprawnienia.DisplayMember = "Name";
                clb_uprawnienia.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas ładowania uprawnień: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private class PermissionItem
        {
            public int Id { get; }
            public string Name { get; }

            public PermissionItem(int id, string name)
            {
                Id = id;
                Name = name;
            }

            public override string ToString()
            {
                return Name;
            }
        }

        private void btn_zapisz_uprawnienia_Click(object sender, EventArgs e)
        {
           
        }

        private void WczytajUprawnienia()
        {
            clb_uprawnienia.Items.Clear();

            DataTable permissions = DBconn.ExecuteQuery("SELECT id, name FROM permissions");

            DataTable userPermissions = DBconn.ExecuteQuery(
                @"SELECT permission_id FROM user_permissions WHERE user_id = @user_id",
                new MySqlParameter("@user_id", _userId)
            );

            HashSet<int> userPermissionIds = new HashSet<int>();
            foreach (DataRow row in userPermissions.Rows)
            {
                userPermissionIds.Add(Convert.ToInt32(row["permission_id"]));
            }

            foreach (DataRow row in permissions.Rows)
            {
                int permissionId = Convert.ToInt32(row["id"]);
                string permissionName = row["name"].ToString();

                int index = clb_uprawnienia.Items.Add(new PermissionItem(permissionId, permissionName));
                if (userPermissionIds.Contains(permissionId))
                {
                    clb_uprawnienia.SetItemChecked(index, true);
                }
            }
        }

        private void btn_zapisz_uprawnienia_Click_1(object sender, EventArgs e)
        {
            if (clb_uprawnienia.CheckedItems.Count == 0)
            {
                MessageBox.Show("Wybierz przynajmniej jedno uprawnienie!", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable currentUserPermissions = DBconn.ExecuteQuery(
                @"SELECT permission_id FROM user_permissions WHERE user_id = @userId",
                new MySqlParameter("@userId", _userId)
            );

            HashSet<int> currentPermissions = new HashSet<int>();
            foreach (DataRow row in currentUserPermissions.Rows)
            {
                currentPermissions.Add(Convert.ToInt32(row["permission_id"]));
            }

            HashSet<int> selectedPermissions = new HashSet<int>();
            foreach (var item in clb_uprawnienia.CheckedItems)
            {
                if (item is PermissionItem permission)
                {
                    selectedPermissions.Add(permission.Id);
                }
            }

            if (currentPermissions.SetEquals(selectedPermissions))
            {
                MessageBox.Show("Brak zmian, nic nie zapisano.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult confirmation = MessageBox.Show(
                "Czy na pewno chcesz nadać te uprawnienia użytkownikowi?",
                "Potwierdzenie",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmation != DialogResult.Yes)
                return;

            try
            {
                // Usuwamy stare uprawnienia
                DBconn.ExecuteQuery(
                    "DELETE FROM user_permissions WHERE user_id = @userId;",
                    new MySqlParameter("@userId", _userId)
                );

                // Dodajemy nowe uprawnienia
                foreach (var item in clb_uprawnienia.CheckedItems)
                {
                    if (item is PermissionItem permission)
                    {
                        DBconn.ExecuteQuery(
                            @"INSERT INTO user_permissions (user_id, permission_id) 
                      VALUES (@userId, @permissionId);",
                            new MySqlParameter("@userId", _userId),
                            new MySqlParameter("@permissionId", permission.Id)
                        );
                    }
                }

                MessageBox.Show("Uprawnienia zostały nadane pomyślnie!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas nadawania uprawnień: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
