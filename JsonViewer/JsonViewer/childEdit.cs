using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JsonViewer
{
    public partial class childEdit : Form
    {
        bool b = false;
        string temp1,temp2;

        public childEdit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            b = true;
            temp1 = textBox1.Text;
            temp2 = textBox2.Text;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            b = false;
            this.Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                b = true;
                temp1 = textBox1.Text;
                temp2 = textBox2.Text;
                this.Close();
            }
            if (e.KeyCode == Keys.Escape)
            {
                b = false;
                this.Close();
            }
        }



        public static bool Get(string key, out string skey)
        {
            var rn = new childEdit();
            rn.textBox1.Text = key.Split(':')[0];
            rn.textBox2.Text = key.Split(':')[1].TrimStart();
            rn.ShowDialog();
            skey = rn.temp1+": "+rn.temp2;
            return rn.b;
        }


    }
}
