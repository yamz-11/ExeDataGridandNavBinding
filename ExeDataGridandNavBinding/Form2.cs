﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeDataGridandNavBinding
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 yamzed3 = new Form3();
            yamzed3.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form4 yamzed4 = new Form4();
            yamzed4.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
