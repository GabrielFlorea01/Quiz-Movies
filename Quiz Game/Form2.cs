using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Joc_Quiz_BUN
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text =="")
            {
                MessageBox.Show("Nu ai introdus user!");
            }
            else
            {
                File.AppendAllText("Useri.txt", textBox1.Text + Environment.NewLine);
                this.Close();
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

       
        private void Form2_Load(object sender, EventArgs e)
        {
           
        }
    }
}
