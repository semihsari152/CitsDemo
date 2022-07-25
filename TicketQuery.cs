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
    public partial class TicketQuery : Form
    {
        int ID = Login.id;
        double money;
        double toplamHarcama;

        public TicketQuery()
        {
            InitializeComponent();
            displayDt();

            var con = conControl.getConnection();
            var cmd = new SqlCommand("Select U_Money from LoginUser where U_ID = '" + ID + "'  ", con);
            var reader = cmd.ExecuteReader();
            reader.Read();
            money = reader.GetDouble(0);
            con.Close();

            updateHarcama();
            display();

        }
        private void btnAddT_Click(object sender, EventArgs e) // harcama ekle
        {
            try
            {
                if (tbxTutarT.Text == "" || tbxMekanT.Text == "")
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                }
                else
                {
                    double value = double.Parse(tbxTutarT.Text, System.Globalization.CultureInfo.InvariantCulture);

                    if (value > money)
                    {
                        MessageBox.Show("PARA YETERSİZ.");
                    }
                    else
                    {
                        var con = conControl.getConnection();
                        var cmd = new SqlCommand("insert into Ticket (T_Tarih,T_Tutar,T_Mekan) values (@Tarih,@Tutar,@Mekan) ", con);

                        cmd.Parameters.AddWithValue("@Tarih", dtpTarih.Text);
                        cmd.Parameters.AddWithValue("@Mekan", tbxMekanT.Text);
                        cmd.Parameters.AddWithValue("@Tutar", tbxTutarT.Text);

                        cmd.ExecuteNonQuery();


                        MessageBox.Show("Eklendi.");

                        updateMoney();

                        displayDt();
                        clear();

                        updateHarcama();
                        display();

                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void display()
        {
            DateTime now = DateTime.Now;
            DateTime finish = new DateTime(2022, 7, 28); 
            TimeSpan ts = finish - now ;
            

            tbxKalanBakiyeT.Text = money.ToString();
            tbxKalanGünT.Text = ts.Days.ToString();
            tbxGünlükBakiyeT.Text = hesapla(ts).ToString();
            tbxHarcananBakiyeT.Text = toplamHarcama.ToString();
        }
        public double hesapla(TimeSpan ts)
        {

            double result = (money / ts.Days);
            result = Math.Round(result, 2);


            return result;
        }
        public void displayDt()
        {
            try
            {
                var dt = new DataTable();
                var con = conControl.getConnection();
                var adp = new SqlDataAdapter("Select * from Ticket", con);
                adp.Fill(dt);
                dtTicket.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void clear()
        {
            dtpTarih.Text = "";
            tbxTutarT.Text = "";
            tbxMekanT.Text = "";
        }
        public void updateHarcama()
        {
            toplamHarcama = 0.00;
            var con = conControl.getConnection();
            var cmd = new SqlCommand("Select T_Tutar from Ticket", con);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                toplamHarcama = toplamHarcama + reader.GetDouble(0);
            }
            con.Close();
        }
        public void updateMoney()
        {
            var con = conControl.getConnection();

            var cmd = new SqlCommand("Select T_Tutar from Ticket order by T_ID desc", con);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            double sonHarcanan = reader.GetDouble(0);
            money = money - sonHarcanan;
            reader.Close();



            cmd = new SqlCommand("Update LoginUser Set U_Money= @Money Where U_ID ='" + ID + "' ", con);
            cmd.Parameters.AddWithValue("@Money", money);
            cmd.ExecuteNonQuery();

            con.Close();

        }
    }
}
