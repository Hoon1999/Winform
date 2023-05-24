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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 폼이 정 중앙에 등장했으면 좋겠다.
        }

        private void tbID_Click(object sender, EventArgs e)
        {
            tbID.Text = ""; ;
        }

        private void tbID_Leave(object sender, EventArgs e)
        {
            if (tbID.Text == "")
                tbID.Text = "아이디";
        }
    }
}
