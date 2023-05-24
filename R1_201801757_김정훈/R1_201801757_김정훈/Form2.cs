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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        bool check = false; // ID 중복검사 여부
        private void Form2_Load(object sender, EventArgs e)
        {
            this.comboBox1.SelectedIndex = 0;
        }

        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            maskedTextBox1.SelectionStart = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //아이디 중복검사
            if (!check)
            {
                MessageBox.Show("아이디 중복검사를 해주세요.");
                return;
            }
            //비밀번호 입력여부 검사
            if(tbPW.Text == "")
            {
                MessageBox.Show("비밀번호를 입력해주세요.");
                tbPW.Focus();
                return;
            }
            //전화번호 검사
            if(maskedTextBox1.Text.Length != 14)
            {
                MessageBox.Show("전화번호 11자리를 모두 입력해주세요.");
                maskedTextBox1.Focus();
                return;
            }
            //성별 검사
            if (rdbM.Checked || rdbW.Checked)
                ;
            else
            {
                MessageBox.Show("성별을 선택해주세요");
                return;
            }
            //id.txt 생성
            //path : D:\HoonGit\Winform\R1_201801757_김정훈\R1_201801757_김정훈\idList
            string path = @"D:\HoonGit\Winform\R1_201801757_김정훈\R1_201801757_김정훈\idList\";
            string id = tbID.Text;
            try
            {
                using(StreamWriter sw = new StreamWriter(path + id + ".txt"))
                {
                    sw.WriteLine(tbPW.Text);
                    sw.WriteLine(comboBox1.SelectedIndex);
                    sw.WriteLine(maskedTextBox1.Text);
                    if (rdbM.Checked)
                        sw.WriteLine("남자");
                    else
                        sw.WriteLine("여자");
                }
            }
            catch { return; }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //path : D:\HoonGit\Winform\R1_201801757_김정훈\R1_201801757_김정훈\idList
            string id = tbID.Text;
            string path = @"D:\HoonGit\Winform\R1_201801757_김정훈\R1_201801757_김정훈\idList\"+id+".txt";
            if (File.Exists(path))
            {
                MessageBox.Show("중복된 아이디 입니다.");
                return;
            }
            else
            {
                MessageBox.Show("생성가능한 아이디 입니다.");
                check = true;
                return;
            }
        }
    }
}
