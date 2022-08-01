using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitsDemo
{
    public partial class Learnings : Form
    {
        DateTime date = DateTime.Now;
        string name = Hub.name;

        public Learnings()
        {
            InitializeComponent();
        }
        private void btnAddTxt_Click(object sender, EventArgs e)
        {
            string fname = tbxFName.Text;

            string path = $"C:\\Users\\Semih\\OneDrive\\Masaüstü\\Learnings\\{fname}.txt";

            try
            {
                if (tbxContent.Text == "" || tbxFName.Text == "" || tbxSubject.Text == "")
                {
                    MessageBox.Show("Lütfen tüm alanları eksiksiz doldurunuz.");
                }
                else
                {
                    if (!File.Exists($"{fname}.txt"))
                    {
                        using (StreamWriter sw = new StreamWriter(path))
                        {
                            sw.WriteLine("Tarih ----> {0}\n", date);
                            sw.WriteLine("İsim -----> {0}\n", name);
                            sw.WriteLine("Konu -----> " + tbxSubject.Text + "\n");
                            sw.WriteLine(tbxContent.Text);
                            MessageBox.Show("Kayıt eklendi");
                            clear();
                        }
                    }
                    else
                    {
                        StreamWriter sw = File.AppendText(path);

                        sw.WriteLine("Tarih ----> {0}\n", date);
                        sw.WriteLine("İsim -----> {0}\n", name);
                        sw.WriteLine("Konu -----> " + tbxSubject.Text + "\n");
                        sw.WriteLine(tbxContent.Text);
                        MessageBox.Show("Kayıt eklendi");
                        sw.Close();
                        clear();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            } 
        }
        public void clear()
        {
            tbxSubject.Text = "";
            tbxFName.Text = "";
            tbxContent.Text = "";
        }
    }
}
