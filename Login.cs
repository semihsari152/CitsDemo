using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CitsDemo
{
    public partial class Login : Form
    {
        public static int id;

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxUsername.Text == "" || tbxPassword.Text == "")
                {
                    MessageBox.Show("Tüm alanları doldur.");
                }
                else
                {
                    var con = conControl.getConnection();
                    SqlCommand cmd = new SqlCommand("Select * from LoginUser where U_Username=@Username and U_Password = @Password", con);
                   

                    cmd.Parameters.Add("@Username", tbxUsername.Text);
                    cmd.Parameters.Add("@Password", tbxPassword.Text);


                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adp.Fill(ds);

                    int count = ds.Tables[0].Rows.Count;

                    if (count == 1)//veritabanındaki bir kullanıcıyla eşleştiyse
                    {
                        MessageBox.Show("Giriş Yapıldı.Ana Sayfaya Yönlendiriliyor...");

                        var reader = cmd.ExecuteReader();
                        reader.Read();
                        id = (int)reader["U_ID"];


                        Hub hub = new Hub();
                        hub.Show();
                        
                        
                    }
                    else//eşleşmediyse
                    {
                        MessageBox.Show("Yanlış username şifre");
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
