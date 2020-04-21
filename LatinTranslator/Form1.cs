﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatinTranslator
{
    public partial class FormLatinTranslator : Form
    {
        public FormLatinTranslator()
        {
            InitializeComponent();
        }

        private void buttonLatinSinister_Click(object sender, EventArgs e)
        {
            labelOutput.Text = "Left";
        }

        private void buttonLatinMedium_Click(object sender, EventArgs e)
        {
            labelOutput.Text = "Center";
        }

        private void buttonLatinDexter_Click(object sender, EventArgs e)
        {
            labelOutput.Text = "Right";
        }
    }
}
