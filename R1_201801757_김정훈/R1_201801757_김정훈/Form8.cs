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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        string path = Application.StartupPath + @"\home\";
        private void Form8_Load(object sender, EventArgs e)
        {
            string tempPath = path + this.Text;
            int fileCount = 0;
            if (!Directory.Exists(tempPath))
            {
                //디렉토리가 존재 하지 않는경우
                Directory.CreateDirectory(tempPath);
            }
            DirectoryInfo di = new DirectoryInfo(tempPath);
            ListViewItem item = new ListViewItem();
            foreach(var a in di.GetFiles())
            {
                fileCount++;
                listView1.Items.Add(new ListViewItem(new String[] { a.Name, a.Length.ToString(), a.CreationTime.ToString() }));
            }
            tsslFile.Text = "파일 : "+ fileCount.ToString() + "개";

            tsslTime.Text = DateTime.Now.ToString();
            timer1.Tick += timer1_Tick;
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tsslTime.Text = DateTime.Now.ToString();
        }

    }
}
