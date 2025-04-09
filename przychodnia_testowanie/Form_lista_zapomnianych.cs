using MySql.Data.MySqlClient;
using przychodnia_testowanie;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

public partial class Form_lista_zapomnianych : Form
{
    Laczenie_z_baza_danych DBconn = new Laczenie_z_baza_danych();

    public Form_lista_zapomnianych()
    {
        InitializeComponent();
        WczytajZapomnianych();
    }

    private void WczytajZapomnianych(string login = "")
    {
        string query = @"
        SELECT 
            login AS 'Login pierwotny', 
            random_name AS 'Imię', 
            random_lastname AS 'Nazwisko', 
            random_pesel AS 'PESEL', 
            birth_date AS 'Data urodzenia', 
            CASE gender 
                WHEN 0 THEN 'M' 
                WHEN 1 THEN 'K' 
                ELSE 'Nieznana' 
            END AS 'Płeć', 
            forget_date AS 'Data zapomnienia' 
        FROM forgotten_users 
        WHERE login LIKE @login 
        ORDER BY forget_date DESC";

        DataTable result = DBconn.ExecuteQuery(query, new MySqlParameter("@login", "%" + login + "%"));
        dtGrdVw_lista_uż.DataSource = result;
    }


    private void btn_wyszukiwarka_Click(object sender, EventArgs e)
    {
        string tekst = txb_search.Text.Trim();
        if (tekst == "Podaj login") tekst = "";
        WczytajZapomnianych(tekst);
    }

    private void anuluj_wyszukiwarka_Click(object sender, EventArgs e)
    {
        txb_search.Text = "Podaj login";
        txb_search.ForeColor = Color.Silver;
        WczytajZapomnianych();
    }

    private void btn_strona_glowna_Click_1(object sender, EventArgs e)
    {
        Form_strona_glowna strona = new Form_strona_glowna();
        strona.Show();
        this.Hide();
    }

    private void txb_search_Enter(object sender, EventArgs e)
    {
        if (txb_search.Text == "Podaj login")
        {
            txb_search.Text = "";
            txb_search.ForeColor = Color.Black;
        }
    }

    private void txb_search_Leave(object sender, EventArgs e)
    {
        if (txb_search.Text == "")
        {
            txb_search.Text = "Podaj login";
            txb_search.ForeColor = Color.Silver;
        }
    }

    private void dtGrdVw_lista_uzytkownikow_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        
    }

    private void label1_Click(object sender, EventArgs e)
    {
       
    }

    private void txb_search_TextChanged(object sender, EventArgs e)
    {
       
    }
}