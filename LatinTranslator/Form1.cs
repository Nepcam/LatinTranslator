using System;
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
            labelOutput.Left = 50;
        }

        private void buttonLatinMedium_Click(object sender, EventArgs e)
        {
            labelOutput.Text = "Center";
            labelOutput.Left = (this.ClientSize.Width - labelOutput.Width) / 2;
        }

        private void buttonLatinDexter_Click(object sender, EventArgs e)
        {
            labelOutput.Text = "Right";
            labelOutput.Left = 400;
        }
    }
}
