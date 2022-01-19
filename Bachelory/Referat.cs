using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Bachelory
{
    public partial class Referat : Form
    {
        public Referat()
        {
            InitializeComponent();
        }
        OleDbConnection connect = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "//database.accdb");
        TextBox[] txt = new TextBox[10];
        //TextBox[] txtQeyd = new TextBox[10];
        Label[] lbl = new Label[10];
        private string Ad()
        {
            int i = 0, q = 0;
            string ad = "";
            string tmp = lbSiyahi.SelectedItem.ToString();
            foreach (char item in tmp)
            {
                q++;
                if (item == ' ') i++;
                if (i == 2)
                {
                    break;
                }
            }
            ad = tmp.Substring(0, q);

            return ad;
        }
        private void ClearTextBox()
        {
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                txt[i].Clear();
                //txtQeyd[i].Clear();
            }
        }
        private string Bal()
        {
            double cem = 0;
            try
            {

                for (int i = 0; i < numericUpDown1.Value; i++)
                {
                    cem += Convert.ToDouble(txt[i].Text);
                }
                
            }
            catch (Exception)
            {

                throw new Exception("Qiymetlendirme zamani sehf bas verdi!");
            }
            return Math.Ceiling(cem /= Convert.ToDouble(numericUpDown1.Value)).ToString();
        }
        private void CreateTextBox()
        {
            panel1.Controls.Clear();
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                lbl[i] = new Label();
                lbl[i].Size = new System.Drawing.Size(50, 30);
                lbl[i].Location = new System.Drawing.Point(20, 20 + 30 * i);
                lbl[i].Text = "Sual " + (i + 1) + ":";

                txt[i] = new TextBox();
                txt[i].Size = new System.Drawing.Size(60, 30);
                txt[i].Location = new System.Drawing.Point(70, 15 + 30 * i);
                txt[i].Font = new System.Drawing.Font("Times new roman", 10);
                /*
                txtQeyd[i] = new TextBox();
                txtQeyd[i].Size = new System.Drawing.Size(220, 30);
                txtQeyd[i].Location = new System.Drawing.Point(140, 15 + 30 * i);
                txtQeyd[i].Font = new System.Drawing.Font("Times new roman", 10);
                */
                panel1.Controls.Add(lbl[i]);
                panel1.Controls.Add(txt[i]);
                //panel1.Controls.Add(txtQeyd[i]);
            }
        }
        private void Qruplar()
        {
            try
            {
                string qrup = "select  distinct Qrup from Telebe";
                if (connect.State != ConnectionState.Open) connect.Open();
                OleDbCommand com = new OleDbCommand(qrup, connect);
                OleDbDataReader r = com.ExecuteReader();
                while (r.Read())
                {
                    cmbQrup.Items.Add(r["Qrup"].ToString());
                }
                connect.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

        }
        private void QrupSiyahisi()
        {
            try
            {
                lbSiyahi.Items.Clear();
                string qrup = "select  * from Telebe where Qrup='" + cmbQrup.Text + "'";
                if (connect.State != ConnectionState.Open) connect.Open();
                OleDbCommand com = new OleDbCommand(qrup, connect);
                OleDbDataReader r = com.ExecuteReader();
                while (r.Read())
                {
                    lbSiyahi.Items.Add(r["Ad"].ToString() + " " + r["Soyad"].ToString() + "                                %" + r["ID"].ToString());

                }
                connect.Close();
            }

            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

        }
        private void UpdateR()
        {
            try
            {
                string update = "";
                string id = lbSiyahi.SelectedItem.ToString();
                id = id.Substring(id.IndexOf("%") + 1, id.Length - id.IndexOf("%") - 1);
                DataSet ds = new DataSet();
                update = "Update Telebe set Referat='" + Bal() + "' where ID='" + id + "'";

                if (connect.State != ConnectionState.Open) connect.Open();
                OleDbDataAdapter adp = new OleDbDataAdapter(update, connect);
                adp.Fill(ds);
                connect.Close();
                lblAd.Text = "Yadda saxlanıldı!";

            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void cmbQrup_SelectedIndexChanged(object sender, EventArgs e)
        {
            QrupSiyahisi();
        }

        private void lbSiyahi_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearTextBox();
            lblAd.Text = Ad() + ": ";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            CreateTextBox();
        }

        private void Referat_Load(object sender, EventArgs e)
        {
            Qruplar();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateR();
        }

        private void btnHesabla_Click(object sender, EventArgs e)
        {
            lblAd.Text=Ad()+":"+ Bal();
        }
    }
}
