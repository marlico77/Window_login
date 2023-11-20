using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bt_acesse_Click(object sender, EventArgs e)
        {
            string User = "admin";
            string Password = "admin";

            if(textBox1.Text == User && textBox2.Text == Password)
            {
                MessageBox.Show("Acesso autorizado");
                Form1 frMain = new Form1();
                frMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Senha incorreta");
            }
        }
    }
}
