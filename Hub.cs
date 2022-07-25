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
    public partial class Hub : Form 
    {

        int id = Login.id;
        public static string name;

        public Hub()
        {
            InitializeComponent();
            getDatas();
            MessageBox.Show("VS'den ekledim");
        }
        public void getDatas()
        {
            var con = conControl.getConnection();

            var cmd = new SqlCommand($"Select * from LoginUser where U_ID = {id}", con);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                tbxName.Text = reader["U_Username"].ToString();
                name = tbxName.Text;
                tbxSicil.Text = reader["U_Sicil"].ToString();
                tbxRol.Text = reader["U_Rol"].ToString();
            }

            tbxTarih.Text = DateTime.Now.ToString("dd-MM-yyyy");

            con.Close();
        }
       
        private void button1_Click(object sender, EventArgs e) //giriş çıkış kaydı
        {
            Giris_Cikis giriscikis = new Giris_Cikis();

            giriscikis.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GirisCikisTable giriscikisTable = new GirisCikisTable();
            giriscikisTable.Show();
        }//giris çıkış table

        private void button4_Click(object sender, EventArgs e) //ticket ekranı
        {
            TicketQuery ticketQuery = new TicketQuery();
            ticketQuery.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Learnings learnings = new Learnings();
            learnings.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LearningsTable learningsTable = new LearningsTable();
            learningsTable.Show();
        }
    }
}
