using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÖĞRENCİ_BİLGİ_SİSTEMİ_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "2020717050" && textBox2.Text == "12831283")
            {
                Form3 yeni1 = new Form3();
                yeni1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(" NUMARANIZ VEYA ŞİFRENİZ HATALI ");
            }

        }
    }
}
