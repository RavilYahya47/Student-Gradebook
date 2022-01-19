using System;
using System.Data;
using System.Drawing;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Bachelory
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        
        OleDbConnection connect = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "//database.accdb");
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);
        private void btnTelebe_Click(object sender, EventArgs e)
        {
            Telebe t = new Telebe();
            t.MdiParent = this;
            t.Show();
            t.Location = new Point(0, 0);
            HomePanel.Visible = false;
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            Kollokvium klv = new Kollokvium();
            klv.MdiParent = this;
            klv.Show();
            klv.Location = new Point(0, 0);
            HomePanel.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            Referat rfr = new Referat();
            rfr.MdiParent = this;
            rfr.Show();
            rfr.Location = new Point(0, 0);
            HomePanel.Visible = false;
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            Semestr sms = new Semestr();
            sms.MdiParent = this;
            sms.Show();
            sms.Location = new Point(0, 0);
            HomePanel.Visible = false;
        }

        private void pbHome_Click(object sender, EventArgs e)
        {
            Telebe t = new Telebe();
            t.MdiParent = this;
            t.Show();
            t.Location = new Point(0, 0);
            HomePanel.Visible = false;
        }
       
      

        private void Giris_Load(object sender, EventArgs e)
        {
            Qruplar();
            Telebe tlb = new Telebe();
            tlb.MdiParent = this;
            tlb.Show();
            tlb.Location = new Point(0, 0);
            HomePanel.Visible = false;
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void btnElaveEt_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.ShowDialog();
            Telebe t = new Telebe();
            t.MdiParent = this;
            t.Show();
            t.Location = new Point(0, 0);
            //this.CenterToScreen();
            HomePanel.Visible = false;
        }
        private void Qruplar()
        {
            try
            {
                string qrup = "select  distinct(Qrup) from Telebe ";
                if (connect.State != ConnectionState.Open) connect.Open();
                OleDbCommand com = new OleDbCommand(qrup, connect);
                OleDbDataReader r = com.ExecuteReader();
                while (r.Read())
                {
                    lbQrup.Items.Add(r["Qrup"].ToString());
                }
                connect.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

        }
        private void pbHome_MouseHover(object sender, EventArgs e)
        {
            pbHome.BackColor = Color.Coral;
        }
        
        private void pbHome_MouseLeave(object sender, EventArgs e)
        {
            pbHome.BackColor = Color.Transparent;
        }

        private void lbQrup_SelectedIndexChanged(object sender, EventArgs e)
        {
            Telebe t = new Telebe(lbQrup.SelectedItem.ToString());
            t.MdiParent = this;
            t.Show();
            t.Location = new Point(0, 0);
            HomePanel.Visible = false;
        }
    }
}
