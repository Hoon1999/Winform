using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace R1_201801757_김정훈
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        public delegate void Sen(string tmp);
        public event Sen Cm;
        private void Form7_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Cm("InformationEdit");
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (tbPW.Text == "")
            {
                MessageBox.Show("비밀번호를 입력해주세요.");
                tbPW.Focus();
                return;
            }
            if (maskedTextBox1.Text.Length != 14)
            {
                MessageBox.Show("전화번호 11자리를 모두 입력해주세요.");
                maskedTextBox1.Focus();
                return;
            }

            string path = Application.StartupPath + @"\idList\"+this.Text+".txt";
            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine(tbPW.Text);
            sw.WriteLine(comboBox1.SelectedIndex.ToString());
            sw.WriteLine(maskedTextBox1.Text);
            if (rdbM.Checked)
            {
                sw.WriteLine(rdbM.Text);
            }else
            {
                sw.WriteLine(rdbW.Text);
            }
            sw.Close();
        }

        private void maskedTextBox1_Enter(object sender, EventArgs e)
        {
            maskedTextBox1.SelectionStart = 0; // 왜 작동이 안되지??
        }
    }
}
