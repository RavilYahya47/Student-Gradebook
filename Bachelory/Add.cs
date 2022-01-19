using System;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace Bachelory
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }
        OleDbConnection connect = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "//database.accdb");
        static int id=0;
        private void btnSave_Click(object sender, EventArgs e)
        {
            id = ID();
            InsertTelebe();
        }
       
        private void InsertTelebe()
        {
            try
            {
                DataSet ds = new DataSet();
                string insert = "Insert into Telebe (ID,Ad,Soyad,Qrup,Kurs,K1,K2,K3,Referat,Semestr) values ('"+ID()+"','"+txtFn.Text+"','"+txtLn.Text+"','"+cmbGroup.Text+"','"+cmbCourse.Text+ "','-','-','-','-','-')";
                if (connect.State != ConnectionState.Open) connect.Open();
                OleDbDataAdapter adp = new OleDbDataAdapter(insert, connect);
                adp.Fill(ds);
                connect.Close();
                MessageBox.Show("Yadda saxlanıldı");
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        private int ID()
        {
            string count = "select count(ad) from telebe";
            OleDbCommand c = new OleDbCommand(count, connect);
            if (connect.State != ConnectionState.Open) connect.Open();
            int co = int.Parse(c.ExecuteScalar().ToString()) + 1;
            connect.Close();
            return co ;
           
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
                    cmbGroup.Items.Add(r["Qrup"].ToString());
                }
                connect.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
           
        }

        private void Add_Load(object sender, EventArgs e)
        {
            Qruplar();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            txtFn.Text = "";
            txtLn.Text = "";
            
        }
    }
}
