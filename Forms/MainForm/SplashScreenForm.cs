﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class SplashScreenForm : Form
    {
        public SplashScreenForm()
        {
            InitializeComponent();

            comboBoxOperation.Items.Add("+");
            comboBoxOperation.Items.Add("-");
            comboBoxOperation.Items.Add("*");
            comboBoxOperation.Items.Add("/");

            comboBoxOperation.SelectedIndex = 0;


        }

        private void SplashScreenForm_Load(object sender, EventArgs e)
        {

        }
    }
}
