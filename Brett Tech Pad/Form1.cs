using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brett_Tech_Pad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Bold_Click(object sender, EventArgs e)
        {
            Font oldFont = richTextBox1.SelectionFont;
            richTextBox1.SelectionFont = new Font(oldFont, oldFont.Bold ? FontStyle.Regular :

                                         FontStyle.Bold);
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Font oldFont1 = richTextBox1.SelectionFont;
            richTextBox1.SelectionFont = new Font(oldFont1, oldFont1.Italic ? FontStyle.Regular :

                                         FontStyle.Italic);

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Font oldFont2 = richTextBox1.SelectionFont;
            richTextBox1.SelectionFont = new Font(oldFont2, oldFont2.Underline ? FontStyle.Regular :

                                         FontStyle.Underline);
        }
    }
}

