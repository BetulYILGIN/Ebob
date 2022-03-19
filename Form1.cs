using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ebobdeneme2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int ebob(int sayı1, int sayı2)
        {
            if (sayı1 == sayı2) 
            {
                return sayı2;
            }

            if(sayı1>sayı2)
            {
                return ebob(sayı1 - sayı2, sayı2);
            }
            return ebob(sayı1, sayı2 - sayı1);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int sayı1 = Convert.ToInt32(textBox1.Text);
            int sayı2 = Convert.ToInt32(textBox2.Text);
            label4.Text = ebob(sayı1, sayı2).ToString();
            
        }
    }
}
