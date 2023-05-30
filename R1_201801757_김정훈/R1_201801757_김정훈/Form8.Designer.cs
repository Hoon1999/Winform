namespace R1_201801757_김정훈
{
    partial class Form8
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.chFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFileSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.이동ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.파일삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.파일이동ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.파일복사ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.탭닫기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.tsslFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.폴더ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.외부에서가져오기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFileName,
            this.chFileSize,
            this.chDate});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(593, 312);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // chFileName
            // 
            this.chFileName.Text = "파일명";
            this.chFileName.Width = 220;
            // 
            // chFileSize
            // 
            this.chFileSize.Text = "용량";
            this.chFileSize.Width = 100;
            // 
            // chDate
            // 
            this.chDate.Text = "수정된 날짜";
            this.chDate.Width = 173;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.이동ToolStripMenuItem,
            this.파일삭제ToolStripMenuItem,
            this.파일이동ToolStripMenuItem,
            this.파일복사ToolStripMenuItem,
            this.탭닫기ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(144, 124);
            // 
            // 이동ToolStripMenuItem
            // 
            this.이동ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.폴더ToolStripMenuItem,
            this.외부에서가져오기ToolStripMenuItem});
            this.이동ToolStripMenuItem.Name = "이동ToolStripMenuItem";
            this.이동ToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.이동ToolStripMenuItem.Text = "파일 추가";
            // 
            // 파일삭제ToolStripMenuItem
            // 
            this.파일삭제ToolStripMenuItem.Name = "파일삭제ToolStripMenuItem";
            this.파일삭제ToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.파일삭제ToolStripMenuItem.Text = "파일 삭제";
            // 
            // 파일이동ToolStripMenuItem
            // 
            this.파일이동ToolStripMenuItem.Name = "파일이동ToolStripMenuItem";
            this.파일이동ToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.파일이동ToolStripMenuItem.Text = "파일 이동";
            // 
            // 파일복사ToolStripMenuItem
            // 
            this.파일복사ToolStripMenuItem.Name = "파일복사ToolStripMenuItem";
            this.파일복사ToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.파일복사ToolStripMenuItem.Text = "파일 복사";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.statusStrip2);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.statusStrip1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(593, 45);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 305);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(593, 45);
            this.toolStripContainer1.TabIndex = 4;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // 탭닫기ToolStripMenuItem
            // 
            this.탭닫기ToolStripMenuItem.Name = "탭닫기ToolStripMenuItem";
            this.탭닫기ToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.탭닫기ToolStripMenuItem.Text = "탭 닫기";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslFile});
            this.statusStrip1.Location = new System.Drawing.Point(9, 10);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(116, 26);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusStrip2
            // 
            this.statusStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslTime});
            this.statusStrip2.Location = new System.Drawing.Point(376, 10);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(116, 26);
            this.statusStrip2.TabIndex = 1;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // tsslFile
            // 
            this.tsslFile.Name = "tsslFile";
            this.tsslFile.Size = new System.Drawing.Size(99, 20);
            this.tsslFile.Text = "파일갯수표시";
            // 
            // tsslTime
            // 
            this.tsslTime.Name = "tsslTime";
            this.tsslTime.Size = new System.Drawing.Size(99, 20);
            this.tsslTime.Text = "현재시간표시";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 폴더ToolStripMenuItem
            // 
            this.폴더ToolStripMenuItem.Name = "폴더ToolStripMenuItem";
            this.폴더ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.폴더ToolStripMenuItem.Text = "폴더";
            // 
            // 외부에서가져오기ToolStripMenuItem
            // 
            this.외부에서가져오기ToolStripMenuItem.Name = "외부에서가져오기ToolStripMenuItem";
            this.외부에서가져오기ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.외부에서가져오기ToolStripMenuItem.Text = "외부에서가져오기";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 350);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.toolStripContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader chFileName;
        private System.Windows.Forms.ColumnHeader chFileSize;
        private System.Windows.Forms.ColumnHeader chDate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 이동ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 파일삭제ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 파일이동ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 파일복사ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 탭닫기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel tsslTime;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslFile;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 폴더ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 외부에서가져오기ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}