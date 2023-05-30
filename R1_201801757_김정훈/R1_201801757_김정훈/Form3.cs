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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int myInfoIndex = -1;
        int myInfoEditIndex = -1;
        int storageIndex = -1;
        private void Form3_Load(object sender, EventArgs e)
        {
            TreeNode rootNode = new TreeNode("Root");
            TreeNode myNode = new TreeNode("my");
            TreeNode myInfoNode = new TreeNode("내 정보");
            TreeNode myInfoEditNode = new TreeNode("내 정보 수정");
            TreeNode storage = new TreeNode("저장공간");

            rootNode.Nodes.Add(myNode);
            myNode.Nodes.Add(myInfoNode);
            myNode.Nodes.Add(myInfoEditNode);
            rootNode.Nodes.Add(storage);

            treeView1.Nodes.Add(rootNode);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            if (e.Node.Text == "내 정보")
            {
                if (myInfoIndex != -1)
                {
                    return; // 내 정보 탭이 이미 존재하면 아무일도 일어나지 않는다.
                }
                tabControl1.TabPages.Add("Information", "내 정보"); // key : Information
                myInfoIndex = tabControl1.TabPages.IndexOfKey("Information"); // key 와 대응되는 index 반환
                
                Form6 frm6 = new Form6();
                frm6.TopLevel = false; // 안하면 에러
                tabControl1.TabPages[myInfoIndex].Controls.Add(frm6);
                frm6.WindowState = FormWindowState.Maximized;
                frm6.Text = this.Text; // form 6에 ID 전달.
                frm6.Show();

                frm6.Cm += new Form6.Sen(der); // Cm(이벤트)에 Sen(델리게이트) 추가.
            }
            else if (e.Node.Text == "내 정보 수정")
            {
                if (myInfoEditIndex != -1)
                    return;
                tabControl1.TabPages.Add("InformationEdit", "내 정보 수정");
                myInfoEditIndex = tabControl1.TabPages.IndexOfKey("InformationEdit");

                Form7 frm7 = new Form7();
                frm7.TopLevel = false;
                tabControl1.TabPages[myInfoEditIndex].Controls.Add(frm7);
                frm7.WindowState = FormWindowState.Maximized;
                frm7.Text = this.Text;
                frm7.Show();

                frm7.Cm += new Form7.Sen(der);
            }
            else if (e.Node.Text == "저장공간")
            {
                if (storageIndex != -1)
                    return;
                tabControl1.TabPages.Add("Storage", "저장공간");
                storageIndex = tabControl1.TabPages.IndexOfKey("Storage");

                Form8 frm8 = new Form8();
                frm8.TopLevel = false;
                tabControl1.TabPages[storageIndex].Controls.Add(frm8);
                frm8.WindowState = FormWindowState.Maximized;
                frm8.Text = this.Text;
                frm8.Show();

                //frm8.Cm += new Form7.Sen(der);
            }
        }
        private void der(string tmp)
        {
            //창 닫기 버튼을 받으면 호출된다.
            myInfoIndex = tabControl1.TabPages.IndexOfKey("Information");
            myInfoEditIndex = tabControl1.TabPages.IndexOfKey("InformationEdit");
            //storageIndex =
            if (tmp == "Information")
            {
                tabControl1.TabPages.Remove(tabControl1.TabPages[myInfoIndex]);
                myInfoIndex = -1; // -1 은 tab이 없다는 것을 의미함.
            }
            else if (tmp == "InformationEdit")
            {
                tabControl1.TabPages.Remove(tabControl1.TabPages[myInfoEditIndex]);
                myInfoEditIndex = -1;
            }
        }
    }
}
