﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiDuck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
       
        private void btnadd_Click(object sender, EventArgs e)
        {

            AddDuck d = new AddDuck();
            d.Show();
            this.Hide();
        }

        private void cmdmod_Click(object sender, EventArgs e)
        {
            Modificar d = new Modificar();
            d.Show();
        }
    }
}
