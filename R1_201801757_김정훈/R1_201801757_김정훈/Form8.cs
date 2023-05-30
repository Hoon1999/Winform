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
        string srcName;
        string destName;
        public delegate void Sen(string tmp);
        public event Sen Cm;
        string path = Application.StartupPath + @"\home\";
        private void Form8_Load(object sender, EventArgs e)
        {
            string tempPath = path + this.Text;

            if (!Directory.Exists(tempPath))
            {
                //디렉토리가 존재 하지 않는경우
                Directory.CreateDirectory(tempPath);
            }
            printFileList();

            tsslTime.Text = DateTime.Now.ToString();
            timer1.Tick += timer1_Tick;
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            tsslTime.Text = DateTime.Now.ToString();
        }
        private void 탭닫기ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            Cm("Storage");
        }

        private void 파일ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string tempPath = path + this.Text;
            for(int i = 0; i < 100; i++) // 새 파일99 까지만 생성가능
            {
                if(!File.Exists(tempPath + @"\새 파일" + i + ".txt"))
                {
                    File.Create(tempPath + @"\새 파일" + i + ".txt");
                    break;
                }
            }
            printFileList();
        }
        private void printFileList()
        {
            string tempPath = path + this.Text;
            int fileCount = 0;
            int dirCount = 0;

            listView1.Items.Clear();
            DirectoryInfo di = new DirectoryInfo(tempPath);
            foreach(var a in di.GetDirectories())
            {
                dirCount++;
                listView1.Items.Add(new ListViewItem(new String[] { a.Name, "", a.CreationTime.ToString() }));
            }
            foreach (var a in di.GetFiles())
            {
                fileCount++;
                listView1.Items.Add(new ListViewItem(new String[] { a.Name, a.Length.ToString(), a.CreationTime.ToString() }));
            }
            tsslFile.Text ="폴더 : " + dirCount + "개 파일 : " + fileCount.ToString() + "개";
        }

        private void 폴더ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string tempPath = path + this.Text;// \home\사용자ID
            for (int i = 0; i < 100; i++) // 새 폴더99 까지만 생성가능
            {
                if (!Directory.Exists(tempPath + @"\새 폴더" + i ))
                {
                    Directory.CreateDirectory(tempPath + @"\새 폴더" + i );
                    break;
                }
            }
            printFileList();
        }

        private void 파일삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string tempPath = path + this.Text+@"\";// \home\사용자ID\
            ListView.SelectedListViewItemCollection i = listView1.SelectedItems;
            if (i.Count == 0) //선택된 파일이 없는 경우.
                return;
            foreach (ListViewItem item in i)
            {
                if(Directory.Exists(tempPath + item.Text))
                {
                    Directory.Delete(tempPath + item.Text, true); //하위 디렉토리까지 삭제
                }
                else
                {
                    File.Delete(tempPath + item.Text);
                }
            }
            printFileList();
        }

        private void 파일복사ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //폴더복사 기능은 없음..
            string tempPath = path + this.Text + @"\";// \home\사용자ID\
            ListView.SelectedListViewItemCollection i = listView1.SelectedItems;
            if (i.Count == 0) //선택된 파일이 없는 경우.
                return;
            foreach(ListViewItem item in i)
            {
                if (Directory.Exists(tempPath + item.Text))
                {
                    ; //디렉토리가 선택된 경우 아무일도 발생하지 않음
                }
                else
                {
                    File.Copy(tempPath + item.Text, tempPath + item.Text + "복사본.txt" ,true);
                    //true면 파일명이 겹칠 경우에 덮어쓰기가 된다.
                }
            }
        }

        private void 파일이름변경ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //이름을 바꾸려는 원본파일 a, 새 파일 b
            //1 바꾸고 싶은 이름으로 파일 b 생성
            //2 파일b 에 파일a 의 내용을 옮김
            //3 원본파일a 삭제

            string tempPath = path + this.Text + @"\";// \home\사용자ID\
            ListView.SelectedListViewItemCollection i = listView1.SelectedItems;
            if(i.Count != 1)
            {//다중 파일 선택시 안내문구 출력
                MessageBox.Show("파일을 하나만 선택해주세요.");
                return;
            }
            int index = listView1.FocusedItem.Index;
            if (Directory.Exists(tempPath + listView1.Items[index].SubItems[0].Text))
            {//디렉토리가 선택된 경우 
                MessageBox.Show("폴더 이름은 변경하실 수 없습니다.");
                return;
            }
            srcName = tempPath + listView1.Items[index].SubItems[0].Text;
            destName = tempPath;
            Form9 frm9 = new Form9();
            frm9.Cm += new Form9.Sen(der2);
            frm9.ShowDialog();
        }
        private void der2(string tmp)
        {// Form9 의 확인버튼을 누르면 호출된다.
            if(tmp == "")
            {//바꿀 이름을 주지 않으면 아무일도 일어나지 않는다.
                return;
            }
            destName += tmp;
            File.Copy(srcName, destName, true); //true 면 이름이 중복될 때 덮어쓰기가 됨.
            File.Delete(srcName); //원본파일 삭제
            printFileList();
        }
        private void 외부파일ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string tempPath = path + this.Text + @"\";// \home\사용자ID\
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                srcName = openFileDialog1.FileName;
                string fn=""; // file name
                foreach(string tmp in srcName.Split('\\'))
                    fn = tmp;
                File.Copy(srcName, tempPath+fn, true);
                printFileList();
            }
        }

    }
}
