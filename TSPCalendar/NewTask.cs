﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSPCalendar
{
    public partial class NewTask : Form
    {
        private Form1 main;

        public NewTask( Form1 f )
        {
            InitializeComponent();

            main = f;
        
        }

        private void NewTask_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();

            main.makeTask(textBox1.Text, textBox2.Text, textBox3.Text,0,0);

            main.Show();

        }
    }
}
