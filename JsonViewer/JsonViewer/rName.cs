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
    public partial class rName : Form
    {
        bool b = false;
        string temp;

        public rName()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            b = true;
            temp = textBox1.Text;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            b = false;
            this.Close();
        }
        public static bool Get(string header,string mes,out string s)
        {
            var rn= new rName();
            rn.Text = header;
            rn.textBox1.Text = mes;
            rn.ShowDialog();
            s = rn.temp;
            return rn.b;
        }



        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                b = true;
                temp = textBox1.Text;
                this.Close();
            }
            if (e.KeyCode == Keys.Escape)
            {
                b = false;
                this.Close();
            }
        }
    }
}
