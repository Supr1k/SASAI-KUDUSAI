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
using MySql.Web;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int role = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;password=;database=mydb;port=3306;"; 
            MySqlConnection conn = new MySqlConnection(connStr);
           
            try
            {
                 conn.Open();
                string sql = "SELECT role_idrole FROM users WHERE username=\"" + textBox1.Text + "\" AND password=\"" + textBox2.Text + "\";";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                
                while (rdr.Read())
                {
                    
                    role = Convert.ToInt32(rdr[0].ToString());
                    
                }
                rdr.Close();

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                 
            }
            conn.Close();
            switch (role)
            {
              
                case 0:
            
                    MessageBox.Show("error");
                    break;
                case 1:
                    AdminForm frm = new AdminForm();
                    frm.Show();

                    break;
                case 2:
                    AdminForm frm1 = new AdminForm();
                    frm1.Show();

                    break;
                default:
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registr reg = new Registr();
            reg.Show();
        }
    }
}
