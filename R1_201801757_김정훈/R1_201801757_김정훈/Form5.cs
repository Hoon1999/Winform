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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        string path = Application.StartupPath + @"\idList\";
        private void Form5_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            rdbM.Checked = true;
        }

        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            maskedTextBox1.SelectionStart = 0;
        }

        private void btnIDSearch_Click(object sender, EventArgs e)
        {
            if(tbID.Text != "")
            {
                if(File.Exists(path + tbID.Text + ".txt"))
                {
                    //아이디가 존재하지 않아도, 그 사실을 알려주지는 않는다.
                    //다른 항목들도 마찬가지. 하나라도 틀리면 그냥 찾을 수 없다고 알려줌.
                    string str,pw;
                    StreamReader sr = new StreamReader(path + tbID.Text + ".txt");
                    pw = sr.ReadLine(); // 첫 line 은 비밀번호
                    str = sr.ReadLine(); // 통신사
                    if(comboBox1.SelectedIndex == Convert.ToInt32(str))
                    {
                        str = sr.ReadLine(); // 전화번호
                        if(str == maskedTextBox1.Text)
                        {
                            str = sr.ReadLine(); //성별
                            if (rdbM.Checked)
                            {
                                if (str == rdbM.Text)
                                {
                                    MessageBox.Show("비밀번호는 " + pw + "입니다.");
                                    sr.Close();
                                    return;
                                }
                            }
                            else
                            {
                                if (str == rdbW.Text)
                                {
                                    MessageBox.Show("비밀번호는 " + pw + "입니다.");
                                    sr.Close();
                                    return;
                                }
                            }
                                
                        }
                    }
                    sr.Close();

                }
            }
            else
            {
                MessageBox.Show("아이디를 입력해주세요","",MessageBoxButtons.OK);
                return;
            }
            MessageBox.Show("일치하는 정보를 찾을 수 없습니다.", "", MessageBoxButtons.OK);
        }
    }
}
