﻿using System;
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
        string path = Application.StartupPath + @"\idList\";
        private void Form1_Load(object sender, EventArgs e)
        {
            ;
            if (File.Exists(path+ "remember.txt"))
            {
                StreamReader sr = new StreamReader(path+ "remember.txt");
                string ID = sr.ReadLine();
                tbID.Text = ID;
                cbRemember.Checked = true;
                sr.Close();
            }
            //Form3 frm3 = new Form3();
            //frm3.ShowDialog();
            //this.Close();
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
            if (cbRemember.Checked)
            {
                if(tbID.Text != "" || tbID.Text != "아이디")
                {
                    //빈 문자열, default 값인 경우 저장하지 않게 함.
                    StreamWriter sw = new StreamWriter(path+"remember.txt");
                    sw.Write(tbID.Text);
                    sw.Close();
                }
            }
            else
            {
                File.Delete(path+"remember.txt");
            }
            if (!File.Exists(path + tbID.Text + ".txt"))
            {
                MessageBox.Show(path + "remember.txt");
                MessageBox.Show("아이디가 존재하지 않습니다.");
                tbID.Focus();
                return;
            }
            else
            {
                StreamReader sr = new StreamReader(path + tbID.Text + ".txt");
                if(tbPW.Text == sr.ReadLine()) // txt 파일의 첫번째 라인에 비밀번호가 위치하고 있음.
                {
                    sr.Close();
                    //비밀번호 일치함.
                    // form 3 으로 넘어감. 넘어갈 때 로그인정보 : id 넘겨줘야 함.
                    this.Visible = false; // Form3 을 사용할 때 Form1을 보이지 않게한다.
                    Form3 frm3 = new Form3();
                    frm3.Text = tbID.Text;
                    frm3.ShowDialog();
                    this.Close(); // form3 종료시 form1도 같이 종료됨.
                }
                else
                {
                    sr.Close();
                    MessageBox.Show("비밀번호가 일치하지 않습니다.");
                    tbPW.Focus();
                }
            }
        }

        private void tbID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //아이디 텍스트박스에서 엔터키 입력시 Login btn click 메소드 호출
            if (e.KeyChar == (char)13)
                btnLogin_Click(sender, e);
        }

        private void tbPW_Leave(object sender, EventArgs e)
        {
            if (tbPW.Text == "")
            {
                tbPW.Text = "비밀번호";
                tbPW.PasswordChar= default(char); //password char 를 지운다.
                                                  //'비밀번호' 문구를 보여주고 싶기 때문
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }

        private void lblFindID_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.ShowDialog();
        }

        private void lblFindPW_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.ShowDialog();
        }

        private void tbPW_Enter(object sender, EventArgs e)
        {
            if (tbPW.Text == "비밀번호")
            {
                tbPW.Text = "";
                tbPW.PasswordChar = '*';
            }
        }
    }
}
