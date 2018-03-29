using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AdminForm : Form
    {
        public AdminForm()
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
        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Authentification adm = new Authentification();
            adm.Show();
            Close();
        }
        
    }
}
