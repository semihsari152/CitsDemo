using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitsDemo
{
    public partial class GirisCikisTable : Form
    {
        int ID;

        public GirisCikisTable()
        {
            InitializeComponent();
            display();

            Hub hub = new Hub();
            if (hub.tbxSicil.Text == "0")       //veri değiştirmek için admin girişi
            {
                gbxAdminPanel.Visible = true;
            }
        }
        public void display()
        {
            try
            {
                var dt = new DataTable();
                var con = conControl.getConnection();
                var adp = new SqlDataAdapter("Select * from GirisCikis", con);
                adp.Fill(dt);
                dtGirisCikis.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void dtGirisCikis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = int.Parse(dtGirisCikis.Rows[e.RowIndex].Cells[0].Value.ToString());
            tbxGiris.Text = dtGirisCikis.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbxCikis.Text = dtGirisCikis.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            var con = conControl.getConnection();
            var cmd = new SqlCommand("UPDATE GirisCikis SET GC_GirisSaati = '" + tbxGiris.Text + "',GC_CikisSaati = '" + tbxCikis.Text + "' Where GC_ID = '" + ID + "'  ", con);
            cmd.ExecuteNonQuery();
            con.Close();

            tbxCikis.Text = "";
            tbxGiris.Text = "";

            MessageBox.Show("Değiştirildi.");
            display();
        }//update
        private void btnDelete_Click_1(object sender, EventArgs e) //delete
        {
            var con = conControl.getConnection();
            var cmd = new SqlCommand("Delete from GirisCikis Where GC_ID = '" + ID + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Veri Silindi.");
            display();
        }
    }
}