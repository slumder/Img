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
    public partial class Brightness : Form
    {
        Form1 f1;
        public Brightness(Form1 parentf)
        {
            InitializeComponent();

            f1 = parentf;
        }
    }
}
