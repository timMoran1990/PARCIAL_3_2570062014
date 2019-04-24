using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parc
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario, clave;
            usuario=textBox1.Text.TrimEnd();
            clave=textBox2.Text.TrimEnd();

            if (usuario == "admin" | clave == "utec")
            {
                
                MDIParent1 mostrar = new MDIParent1();
                mostrar.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        public TextBox admin { get; set; }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
