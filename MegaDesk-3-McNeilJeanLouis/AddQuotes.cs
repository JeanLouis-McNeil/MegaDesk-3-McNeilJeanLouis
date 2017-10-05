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


namespace MegaDesk_3_McNeilJeanLouis
{
    public partial class AddQuotes : Form
    {
        public AddQuotes()
        {
            InitializeComponent();
        }

        private void button1_click(object sender, EventArgs e)
        {
            string text1 = textBox1.Text;
            string text2 = textBox2.Text;
            string size = numericUpDown1.Text;
            string drawer = numericUpDown2.Text;
            string rush = numericUpDown3.Text;

            StreamWriter quote = new StreamWriter("quote.txt");
            quote.WriteLine("Full Name: " + text1 + Environment.NewLine
                + "E-Mail: " + text2 + Environment.NewLine
                + "Size :" + size + Environment.NewLine
                + "Drawer Number: " + drawer + Environment.NewLine
                + "Rush Order Days: " + rush + Environment.NewLine
                + "Welcome and have a good Day with us!!!" + Environment.NewLine);
            quote.Close();
        }
    }
}
