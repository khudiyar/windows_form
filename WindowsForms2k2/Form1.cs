﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms2k2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string data = txtMain.Text;
            ContactForm form = new ContactForm(data);
            form.Show();
        }
    }
}
