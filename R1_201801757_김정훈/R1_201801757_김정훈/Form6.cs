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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        public delegate void Sen(string tmp); //sender
        public event Sen Cm; // close message
        private void Form6_Load(object sender, EventArgs e)
        {
            lblID.Text = this.Text;
            string path = Application.StartupPath + @"\idList\"+lblID.Text+".txt";
            StreamReader sr = new StreamReader(path);
            sr.ReadLine(); //첫번째 라인인 비밀번호는 버린다.
            lblPhone.Text = sr.ReadLine(); // 통신사
            if (Convert.ToInt32(lblPhone.Text) == 0)
                lblPhone.Text = "skt ";
            else if (Convert.ToInt32(lblPhone.Text) == 1)
                lblPhone.Text = "kt ";
            else if (Convert.ToInt32(lblPhone.Text) == 2)
                lblPhone.Text = "U+ ";
            lblPhone.Text += sr.ReadLine(); //번호
            lblGender.Text = sr.ReadLine(); //성별
            sr.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Cm("Information");
        }
    }
}
