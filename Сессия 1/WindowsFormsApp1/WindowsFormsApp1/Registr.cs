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
    public partial class Registr : Form
    {
        public Registr()
        {
            InitializeComponent();
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
                while (rdr.Read())
                {
                    string name = "";
                    name = Convert.ToString(rdr[0]);
                    if (name != "")
                    {
                        MessageBox.Show("Пользователь " + name + " уже зарегестрирован");
                    }
                    else
                    {
                        MessageBox.Show("Пользователь ");

                        string regis = "INSERT INTO `mydb`.`users`(`username`,`password`)VALUES(\"" + textBox1.Text + "\",\"" + textBox2.Text + "\");";
                        MySqlCommand regiscmd = new MySqlCommand(regis, conn);
                        regiscmd.ExecuteNonQuery();
                    }
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());


            }
            conn.Close();
        }
    }
}
