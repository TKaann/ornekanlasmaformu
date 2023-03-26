using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gorselodevi2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.google.com");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox3.Text == "" || maskedTextBox1.TextLength != 11)
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                MessageBox.Show("Silmek İstediğinize Emin Misiniz?");

                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        (item as TextBox).Clear();
                    }

                    else if (item is MaskedTextBox)
                    {
                        (item as MaskedTextBox).Clear();
                    }
                }

            }
        }
    }
}
