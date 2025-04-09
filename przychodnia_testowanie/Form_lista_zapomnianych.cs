using MySql.Data.MySqlClient;
using przychodnia_testowanie;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

public partial class Form_lista_zapomnianych : Form
{
    Laczenie_z_baza_danych DBconn = new Laczenie_z_baza_danych();

    public Form_lista_zapomnianych()
    {
        InitializeComponent();
        WczytajZapomnianych();
        UstawPodpowiedz();
    }

    private void WczytajZapomnianych(string loginOrDate = "")
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
        WHERE 1=1";

        List<MySqlParameter> parameters = new List<MySqlParameter>();

        DateTime parsedDate;
        if (DateTime.TryParseExact(loginOrDate, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out parsedDate))
        {
            query += " AND DATE(forget_date) = @date";
            parameters.Add(new MySqlParameter("@date", parsedDate.Date));
        }
        else if (!string.IsNullOrWhiteSpace(loginOrDate))
        {
            query += " AND login LIKE @login";
            parameters.Add(new MySqlParameter("@login", "%" + loginOrDate + "%"));
        }

        query += " ORDER BY forget_date DESC";

        DataTable result = DBconn.ExecuteQuery(query, parameters.ToArray());
        dtGrdVw_lista_uż.DataSource = result;
    }



    private void btn_wyszukiwarka_Click(object sender, EventArgs e)
    {
        string tekst = txb_search.Text.Trim();

        if (tekst == "Podaj login lub datę zapomnienia (dd.MM.yyyy)")
            tekst = "";

        WczytajZapomnianych(tekst);
    }


    private void anuluj_wyszukiwarka_Click(object sender, EventArgs e)
    {
        txb_search.Text = "Podaj login lub datę zapomnienia (dd.MM.yyyy)";
        txb_search.ForeColor = Color.Silver;
        WczytajZapomnianych();
    }


    private void btn_strona_glowna_Click_1(object sender, EventArgs e)
    {
        Form_strona_glowna strona = new Form_strona_glowna();
        strona.Show();
        this.Hide();
    }

    bool isPlaceholderActive = true;

    private void txb_search_Enter(object sender, EventArgs e)
    {
        if (txb_search.Text == "Podaj login lub datę zapomnienia (dd.MM.yyyy)")
        {
            txb_search.Text = "";
            txb_search.ForeColor = Color.Black;
        }
    }


    private void UstawPodpowiedz()
    {
        if (string.IsNullOrWhiteSpace(txb_search.Text))
        {
            txb_search.Text = "Podaj login lub datę zapomnienia (dd.MM.yyyy)";
            txb_search.ForeColor = Color.Gray;
        }
    }

    private void txb_search_Leave(object sender, EventArgs e)
    {
        UstawPodpowiedz();
    }


    private void dtGrdVw_lista_uzytkownikow_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        
    }

    private void label1_Click(object sender, EventArgs e)
    {
       
    }

    private void txb_search_TextChanged(object sender, EventArgs e)
    {
        if (isPlaceholderActive || string.IsNullOrWhiteSpace(txb_search.Text))
            return;

        string input = txb_search.Text.Trim();
        DateTime parsedDate;

        if (DateTime.TryParseExact(input, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out parsedDate))
        {
            txb_search.BackColor = Color.White;

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
        WHERE DATE(forget_date) = @data
        ORDER BY forget_date DESC";

            DataTable result = DBconn.ExecuteQuery(query, new MySqlParameter("@data", parsedDate.ToString("yyyy-MM-dd")));
            dtGrdVw_lista_uż.DataSource = result;
        }
        else
        {
            if (input.Any(char.IsDigit) && input.Length >= 6)
            {
                txb_search.BackColor = Color.MistyRose;
                ToolTip tooltip = new ToolTip();
                tooltip.ToolTipTitle = "Błędny format daty";
                tooltip.Show("Użyj formatu dd.MM.yyyy (np. 01.03.2024)", txb_search, 0, -20, 3000);
            }
            else
            {
                txb_search.BackColor = Color.White;
            }

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

            DataTable result = DBconn.ExecuteQuery(query, new MySqlParameter("@login", "%" + input + "%"));
            dtGrdVw_lista_uż.DataSource = result;
        }
    }
}