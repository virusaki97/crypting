using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool boxes_valid()
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("You must enter an input text first!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("You must enter a valid password!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (boxes_valid())
                 textBox1.Text = Program.encrypt(textBox1.Text, textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (boxes_valid())
                textBox1.Text = Program.decrypt(textBox1.Text, textBox2.Text);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
                Clipboard.SetText(textBox1.Text);
            else
                textBox1.Text = Clipboard.GetText();
        }
    }
}
