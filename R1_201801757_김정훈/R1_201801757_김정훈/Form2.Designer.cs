namespace R1_201801757_김정훈
{
    partial class Form2
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblPW = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rdbW = new System.Windows.Forms.RadioButton();
            this.rdbM = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbPW = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblCheck = new System.Windows.Forms.Label();
            this.gbGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(48, 41);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(52, 15);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "아이디";
            // 
            // lblPW
            // 
            this.lblPW.AutoSize = true;
            this.lblPW.Location = new System.Drawing.Point(33, 101);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(67, 15);
            this.lblPW.TabIndex = 1;
            this.lblPW.Text = "비밀번호";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "전화번호";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "SKT",
            "KT",
            "U+"});
            this.comboBox1.Location = new System.Drawing.Point(114, 135);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(58, 23);
            this.comboBox1.TabIndex = 3;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(188, 134);
            this.maskedTextBox1.Mask = "(999)9000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(121, 25);
            this.maskedTextBox1.TabIndex = 4;
            this.maskedTextBox1.Click += new System.EventHandler(this.maskedTextBox1_Click);
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.rdbW);
            this.gbGender.Controls.Add(this.rdbM);
            this.gbGender.Location = new System.Drawing.Point(130, 165);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(149, 42);
            this.gbGender.TabIndex = 5;
            this.gbGender.TabStop = false;
            // 
            // rdbW
            // 
            this.rdbW.AutoSize = true;
            this.rdbW.Location = new System.Drawing.Point(85, 17);
            this.rdbW.Name = "rdbW";
            this.rdbW.Size = new System.Drawing.Size(58, 19);
            this.rdbW.TabIndex = 1;
            this.rdbW.TabStop = true;
            this.rdbW.Text = "여성";
            this.rdbW.UseVisualStyleBackColor = true;
            // 
            // rdbM
            // 
            this.rdbM.AutoSize = true;
            this.rdbM.Location = new System.Drawing.Point(6, 17);
            this.rdbM.Name = "rdbM";
            this.rdbM.Size = new System.Drawing.Size(58, 19);
            this.rdbM.TabIndex = 0;
            this.rdbM.TabStop = true;
            this.rdbM.Text = "남성";
            this.rdbM.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 77);
            this.button1.TabIndex = 6;
            this.button1.Text = "가입";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(336, 35);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(81, 27);
            this.btnCheck.TabIndex = 7;
            this.btnCheck.Text = "중복검사";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(114, 36);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(195, 25);
            this.tbID.TabIndex = 8;
            this.tbID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbID_KeyPress);
            // 
            // tbPW
            // 
            this.tbPW.Location = new System.Drawing.Point(114, 96);
            this.tbPW.Name = "tbPW";
            this.tbPW.PasswordChar = '*';
            this.tbPW.Size = new System.Drawing.Size(195, 25);
            this.tbPW.TabIndex = 9;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(63, 182);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(37, 15);
            this.lblGender.TabIndex = 2;
            this.lblGender.Text = "성별";
            // 
            // lblCheck
            // 
            this.lblCheck.AutoSize = true;
            this.lblCheck.Location = new System.Drawing.Point(112, 71);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(197, 15);
            this.lblCheck.TabIndex = 10;
            this.lblCheck.Text = "아이디 중복검사를 해주세요";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 329);
            this.Controls.Add(this.lblCheck);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.tbPW);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbGender);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPW);
            this.Controls.Add(this.lblID);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "회원가입";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblPW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rdbW;
        private System.Windows.Forms.RadioButton rdbM;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbPW;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblCheck;
    }
}