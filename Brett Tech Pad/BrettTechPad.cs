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
    public partial class BrettTechPad : Form
    {
        //define variable 
        int size = 12;
        public BrettTechPad()
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

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            size = size + 2;
            try
            {
                richTextBox1.SelectionFont = new Font("Arial Rounded MT", size);
            }
            catch
            {
                /*
                I actually don't know why this is happening. Just a catch.
                For some reason when I fixed the shrink exception, it caused a growth exception.
                This shall fix the exception.
                */
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            size = size - 2;
            try
            {
                richTextBox1.SelectionFont = new Font("Arial Rounded MT", size);
                }
            catch 
            {
                /*
                 * If this  dont work well then Hello
                 */
            }
            }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About frm = new About();
            frm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }
        private void pateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Clipboard.GetText();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                // Create a SaveFileDialog to request a path and file name to save to.
                SaveFileDialog saveFile1 = new SaveFileDialog();

                // Initialize the SaveFileDialog to specify the RTF extension for the file.
                saveFile1.DefaultExt = "*.rtf";
                saveFile1.Filter = "RTF Files|*.rtf";

                // Determine if the user selected a file name from the saveFileDialog.
                if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                   saveFile1.FileName.Length > 0)
                {
                    // Save the contents of the RichTextBox into the file.
                    richTextBox1.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
                }
            }

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                // Create an OpenFileDialog to request a file to open.
                OpenFileDialog openFile1 = new OpenFileDialog();

                // Initialize the OpenFileDialog to look for RTF files.
                openFile1.DefaultExt = "*.rtf";
                openFile1.Filter = "RTF Files|*.rtf";

                // Determine whether the user selected a file from the OpenFileDialog.
                if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                   openFile1.FileName.Length > 0)
                {
                    // Load the contents of the file into the RichTextBox.
                    richTextBox1.LoadFile(openFile1.FileName);
                }
              
            }

        }
    }
    }


