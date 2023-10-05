using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(messageTxtb.Text);
        }

        private void messageTxtb_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text=messageTxtb.Text;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Your username and pass are : {usernameTxtb.Text} {passwordTxtb.Text}");
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            this.pictureBox2.Image = Properties.Resources.open;
            this.passwordTxtb.PasswordChar = '\0';
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            this.pictureBox2.Image = Properties.Resources.close;
            this.passwordTxtb.PasswordChar = '*';
        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font("Comic Sans MS", 14, FontStyle.Bold);
            richTextBox1.Copy();
            richTextBox1.SelectionColor = Color.DeepSkyBlue;
        }

        private void pasteBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void cutBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void undoBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(maskedTextBox1.Text);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                radioButton1.Text = radioButton1.Text + " selected";
            }
            else
            {
                radioButton1.Text = "Debit Card";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                radioButton2.Text = radioButton2.Text + " selected";
            }
            else
            {
                radioButton2.Text = "Credit Card";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.ForeColor = Color.DeepSkyBlue;
            checkBox2.ForeColor = Color.Black;
            checkBox3.ForeColor = Color.Black;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.ForeColor = Color.DeepSkyBlue;
            checkBox1.ForeColor = Color.Black;
            checkBox3.ForeColor = Color.Black;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox3.ForeColor = Color.DeepSkyBlue;
            checkBox2.ForeColor = Color.Black;
            checkBox1.ForeColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                if(item is Button bt)
                {
                    bt.ForeColor = Color.Red;
                }
                else if(item is CheckBox cb)
                {
                    cb.ForeColor = Color.Red;   
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = dateTimePicker1.Text;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            label1.Text = monthCalendar1.SelectionStart.ToLongDateString();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox4.Checked)
            {
                checkBox4.Text = "Hide";
                groupBox3.Visible = false;
            }
            else
            {
                groupBox3.Visible = true;
                checkBox4.Text = "Show";
            }
        }
    }
}
