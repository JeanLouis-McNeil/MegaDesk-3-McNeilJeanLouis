using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_McNeilJeanLouis
{
    public partial class MainMenuView : Form
    {
        public MainMenuView()
        {
            InitializeComponent();
        }

        private void button1_click(object sender, EventArgs e)
        {
            this.Hide();
            AddQuotes frame = new AddQuotes();
            frame.Show();
        }

        private void button4_click(object sender, EventArgs e)
        {
            this.Hide();
            ShowQuotes frame2 = new ShowQuotes();
            frame2.Show();
        }
    }
    
}
