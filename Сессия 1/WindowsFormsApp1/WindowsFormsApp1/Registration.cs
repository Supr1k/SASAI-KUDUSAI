using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        public void Cl_FormClosed(object sender, FormClosedEventArgs e)
        {

            this.Show();
        }
        public void Close()
        {
            Authentification closeform = new Authentification();
            closeform.FormClosed += Cl_FormClosed;
            this.Hide();

        }
        private void button1_Click(object sender, EventArgs e)
        {


            string connStr = "server=localhost;user=root;password=;database=mydb;port=3306;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {

                conn.Open();
                string sql = "SELECT username FROM users WHERE username=\"" + textBox1.Text + "\";";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                int chek = 0;
                while (rdr.Read())
                {
                    string name = "";
                    name = Convert.ToString(rdr[0]);
                    if (name != "")
                    {
                        MessageBox.Show("Пользователь " + name + " уже зарегестрирован");
                        chek = 1;
                    }
                }
                rdr.Close();

                if (chek == 0)
                {

                 
                    string regis = "INSERT INTO `mydb`.`users`(`username`,`password`)VALUES(\"" + textBox1.Text + "\",\"" + textBox2.Text + "\");";
                    MySqlCommand regiscmd = new MySqlCommand(regis, conn);
                    regiscmd.ExecuteNonQuery();
                    MessageBox.Show(" Регистрация прошла успешно \n\tВаш логин:\"" + textBox1.Text + "\"\n\tВаш пароль: \"" + textBox2.Text + "\"");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());


            }
            conn.Close();

            Registration reg2 = new Registration();
            reg2.FormClosed += Reg2_FormClosed;
            this.Hide();
            Authentification adm = new Authentification();

            adm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registration reg2 = new Registration();
            reg2.FormClosed += Reg2_FormClosed;
            this.Hide();
            Authentification adm = new Authentification();
            
            adm.Show();
        }

        private void Reg2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ты охуел сюда нажимать пидр баба");
        }

        private void enter_password_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы сказочный далбоеб");
        }
    }
}
