using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R1_201801757_김정훈
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        public delegate void Sen(string tmp);
        public event Sen Cm;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Cm(textBox1.Text);
        }
    }
}
