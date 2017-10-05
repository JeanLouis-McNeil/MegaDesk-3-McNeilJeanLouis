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
    public partial class ShowQuotes : Form
    {
        public ShowQuotes()
        {
            InitializeComponent();
            
        

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_click(object sender, EventArgs e)
        {
            StreamReader quoteReader = new StreamReader("quote.txt");
            richTextBox1.Text = quoteReader.ReadToEnd();
            Console.WriteLine(Text);
            quoteReader.Close();
        }
    }
}
