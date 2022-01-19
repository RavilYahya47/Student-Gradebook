using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Drawing;

namespace Bachelory
{
    public partial class Telebe : Form
    {
        public Telebe()
        {
            InitializeComponent();
        }
        public Telebe(string qrup)
        {
            InitializeComponent();
            Qrup = qrup;
        }
        OleDbConnection connect = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "//database.accdb");
        string Qrup="#";
        private void Telebe_Load(object sender, EventArgs e)
        {
            if (Qrup == "#")
                FillDataGridTelebe();
            else
                FillDataGridTelebeQrup(Qrup);
        }
        private void FillDataGridTelebe()
        {
            try
            {
                string query = "select ID,Ad,Soyad,Qrup,K1,K2,K3,Referat,Semestr from Telebe";
                DataSet ds = new DataSet(); ds.Clear();
                OleDbDataAdapter adp = new OleDbDataAdapter();
                OleDbCommand commad = new OleDbCommand();
                if (connect.State != ConnectionState.Open) connect.Open();
                adp.SelectCommand = new OleDbCommand(query, connect);
                adp.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].Visible = false;

            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }
        }
        private void FillDataGridTelebeQrup(string qrup)
        {
            try
            {
                string query = "select ID,Ad,Soyad,Qrup,K1,K2,K3,Referat,Semestr from Telebe where Qrup='"+qrup+"'";
                DataSet ds = new DataSet(); ds.Clear();
                OleDbDataAdapter adp = new OleDbDataAdapter();
                OleDbCommand commad = new OleDbCommand();
                if (connect.State != ConnectionState.Open) connect.Open();
                adp.SelectCommand = new OleDbCommand(query, connect);
                adp.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].Visible = false;

            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }
        }

        private void txtAxtar_TextChanged(object sender, EventArgs e)
        {
            List<string> Names = ReturnNames(txtAxtar.Text);
            lbAxtar.Items.Clear();
            for (int i = 0; i < Names.Count; i++)
            {

                lbAxtar.Visible = true;
                lbAxtar.Size = new Size(238, 25 + i * 15);
                lbAxtar.Items.Add(Names[i]);
            }
            if (txtAxtar.Text == "")
                lbAxtar.Size = new Size(0, 0);
        }
        private List<string> ReturnNames(string text)
        {
            List<string> names = new List<string>();
            try
            {


                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }
                OleDbCommand command = new OleDbCommand("select distinct ad,soyad,qrup,ID from Telebe where ad like '%" + text + "%' or soyad like '%" + text + "%'", connect);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                    names.Add(reader["Ad"].ToString() + " " + reader["Soyad"].ToString() + " " + reader["Qrup"].ToString() + "  %" + reader["ID"].ToString());
                connect.Close();
            }
            catch { connect.Close(); }
            return names;
        }

        private void lbAxtar_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilldatagridSearch();
            txtAxtar.Text = lbAxtar.SelectedItem.ToString();
            lbAxtar.Visible = false;
        }
        private void FilldatagridSearch()
        {
            try
            {
                string id = lbAxtar.SelectedItem.ToString().Substring(lbAxtar.SelectedItem.ToString().IndexOf("%")+1, lbAxtar.SelectedItem.ToString().Length- lbAxtar.SelectedItem.ToString().IndexOf("%")-1);
                string query = "select ID,Ad,Soyad,Qrup,K1,K2,K3,Referat,Semestr from Telebe  where ID='" +  id + "'";
                DataSet ds = new DataSet(); ds.Clear();
                OleDbDataAdapter adp = new OleDbDataAdapter();
                OleDbCommand commad = new OleDbCommand();
                if (connect.State != ConnectionState.Open) connect.Open();
                adp.SelectCommand = new OleDbCommand(query, connect);
                adp.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].Visible = false;

            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }
        }

        private void txtAxtar_MouseDown(object sender, MouseEventArgs e)
        {
            txtAxtar.SelectAll();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TextboxlarayazQiymetleri();
        }
        private void TextboxlarayazQiymetleri()
        {
            txtK1.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtK2.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtK3.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            txtReferat.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            txtSemestr.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();

        }
        private void UpdateQiymetler()
        {
            try
            {
                string update = "";
                string id =dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                DataSet ds = new DataSet();
                    update = "Update Telebe set K1='" + txtK1.Text + "',K2='" + txtK2.Text + "',K3='" + txtK3.Text + "',Referat='" + txtReferat.Text + "',Semestr='" + txtSemestr.Text + "' where ID='" + id + "'";
                if (connect.State != ConnectionState.Open) connect.Open();
                OleDbDataAdapter adp = new OleDbDataAdapter(update, connect);
                adp.Fill(ds);
                connect.Close();
                MessageBox.Show("Yadda saxlanıldı!");
                FillDataGridTelebe();

            }
            catch
            {
                MessageBox.Show("Error");
            }

        }

        private void btnYaddaSaxla_Click(object sender, EventArgs e)
        {
            UpdateQiymetler();
        }
    }
}
