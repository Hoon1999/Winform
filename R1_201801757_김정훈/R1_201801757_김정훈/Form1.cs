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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = @"D:\HoonGit\Winform\R1_201801757_김정훈\R1_201801757_김정훈\idList\remember.txt";
            if (File.Exists(path))
            {
                StreamReader sr = new StreamReader(path);
                string ID = sr.ReadLine();
                tbID.Text = ID;
                cbRemember.Checked = true;
                sr.Close();
            }
        }

        private void tbID_Click(object sender, EventArgs e)
        {
            if (tbID.Text == "아이디")
                tbID.Text = "";
        }

        private void tbID_Leave(object sender, EventArgs e)
        {
            if (tbID.Text == "")
                tbID.Text = "아이디";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string path = @"D:\HoonGit\Winform\R1_201801757_김정훈\R1_201801757_김정훈\idList\remember.txt";
            
            //아이디가 틀리면 아이디로 포커스 이동

            //비밀번호가 틀렸으면 비밀번호로 포커스 이동
            if (cbRemember.Checked)
            {
                if(tbID.Text != "" || tbID.Text != "아이디")
                {
                    //빈 문자열, default 값인 경우 저장하지 않게 함.
                    StreamWriter sw = new StreamWriter(path);
                    sw.Write(tbID.Text);
                    sw.Close();
                }
            }
            else
            {
                File.Delete(path);
            }
            
        }

        private void tbID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //아이디 텍스트박스에서 엔터키 입력시 Login btn click 메소드 호출
            if (e.KeyChar == (char)13)
                btnLogin_Click(sender, e);
        }

        private void tbPW_Click(object sender, EventArgs e)
        {
            if(tbPW.Text == "비밀번호")
                tbPW.Text = "";
        }

        private void tbPW_Leave(object sender, EventArgs e)
        {
            if (tbPW.Text == "")
                tbPW.Text = "비밀번호";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }
    }
}
