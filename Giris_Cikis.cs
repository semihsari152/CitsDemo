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
    public partial class Giris_Cikis : Form
    {
        int id = Login.id;
        string name = Hub.name;
        int primarykey;
        DateTime dob = DateTime.Now;

        

        public Giris_Cikis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // giris saati ekle
        {
            var con = conControl.getConnection();
            var cmd = new SqlCommand($"insert into GirisCikis (GC_Username,GC_GirisSaati,GC_Tarih) values ('" + name + "',@Time,@Date) ", con);

            cmd.Parameters.AddWithValue("@Date", dob.ToShortDateString());
            cmd.Parameters.AddWithValue("@Time", dob.ToShortTimeString());

            print();
            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e) // çıkış saati ekle
        {
            var con = conControl.getConnection();

            getLastID();
            
            var cmd = new SqlCommand($"Update GirisCikis Set GC_CikisSaati=@Time where GC_ID='" + primarykey + "' ", con);
           

            cmd.Parameters.AddWithValue("@Time", dob.ToShortTimeString());

            print();


            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void print()
        {
            tbxUser.Text = name;
            tbxDate.Text = dob.ToShortDateString();
            tbxTime.Text = dob.ToShortTimeString();
        }
        public void getLastID()
        {
            var con = conControl.getConnection();
            var cmd = new SqlCommand("Select max(GC_ID) from GirisCikis", con);

            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            primarykey = reader.GetInt32(0);
            reader.Close();
        }
    }
}
