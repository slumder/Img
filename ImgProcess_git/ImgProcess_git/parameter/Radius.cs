using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgProcess_git
{
    public partial class Radius : Form
    {
        Form1 f1;
        public Radius(Form1 parentf)
        {
            InitializeComponent();

            f1 = parentf;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            f1.radius = Convert.ToDouble(text);
            Close();
        }
    }
}
