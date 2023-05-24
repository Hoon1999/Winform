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

        private void Form3_Load(object sender, EventArgs e)
        {
            TreeNode rootNode = new TreeNode("Root");
            TreeNode myNode = new TreeNode("my");
            TreeNode myInfoNode = new TreeNode("내 정보");
            TreeNode myInfoEditNode = new TreeNode("내 정보 수정");

            rootNode.Nodes.Add(myNode);
            myNode.Nodes.Add(myInfoNode);
            myNode.Nodes.Add(myInfoEditNode);
        }
    }
}
