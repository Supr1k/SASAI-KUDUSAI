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
    public partial class Authentification : Form
    {
        public Authentification()
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
        int role = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;password=;database=mydb;port=3306;";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
                string sql = "SELECT role_idrole FROM users WHERE username=\"" + Login.Text + "\" AND password=\"" + Password.Text + "\";"; 
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

                    MessageBox.Show("\t Ошибка авторизации \n    Введен неверный логин или пароль");
                    break;
                case 1:
                    AdminForm Admin = new AdminForm();
                    Admin.Show();
                     role = 0;
                    Close();
                    break;
                case 2:
                    Manager Manager = new Manager();
                    Manager.Show();
                     role = 0;
                    Close();
                    break;
                case 3:
                    Storekeeper Storekeeper = new Storekeeper();
                    Storekeeper.Show();
                     role = 0;
                    Close();
                    break;
                case 4:
                    Customer Customer = new Customer();
                    Customer.Show();
                    role = 0;
                    Close();
                    break;
                default:
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
            Close();
           
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void Password_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                
                button1_Click(sender, e);
            }
        }
    }

      
}
