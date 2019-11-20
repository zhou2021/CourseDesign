namespace EduSystem
{
    partial class frm_MyDesktop
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
            this.tc_mydesktop = new System.Windows.Forms.TabControl();
            this.tp_Message = new System.Windows.Forms.TabPage();
            this.f = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rtb_Announcement = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rtb_Message = new System.Windows.Forms.RichTextBox();
            this.tp_PersonalInformation = new System.Windows.Forms.TabPage();
            this.txb_Hobby = new System.Windows.Forms.TextBox();
            this.cb_Class = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rBtn_Girl = new System.Windows.Forms.RadioButton();
            this.rBtn_Boy = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_Birthdate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.txb_No = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tp_TeachingWeek = new System.Windows.Forms.TabPage();
            this.dgv_TeachingWeek = new System.Windows.Forms.DataGridView();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Load = new System.Windows.Forms.Button();
            this.tc_mydesktop.SuspendLayout();
            this.tp_Message.SuspendLayout();
            this.f.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tp_PersonalInformation.SuspendLayout();
            this.tp_TeachingWeek.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TeachingWeek)).BeginInit();
            this.SuspendLayout();
            // 
            // tc_mydesktop
            // 
            this.tc_mydesktop.Controls.Add(this.tp_Message);
            this.tc_mydesktop.Controls.Add(this.tp_PersonalInformation);
            this.tc_mydesktop.Controls.Add(this.tp_TeachingWeek);
            this.tc_mydesktop.Location = new System.Drawing.Point(2, 2);
            this.tc_mydesktop.Name = "tc_mydesktop";
            this.tc_mydesktop.SelectedIndex = 0;
            this.tc_mydesktop.Size = new System.Drawing.Size(558, 239);
            this.tc_mydesktop.TabIndex = 0;
            // 
            // tp_Message
            // 
            this.tp_Message.Controls.Add(this.f);
            this.tp_Message.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tp_Message.Location = new System.Drawing.Point(4, 22);
            this.tp_Message.Name = "tp_Message";
            this.tp_Message.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Message.Size = new System.Drawing.Size(550, 213);
            this.tp_Message.TabIndex = 0;
            this.tp_Message.Text = "公告留言";
            // 
            // f
            // 
            this.f.Controls.Add(this.tabPage1);
            this.f.Controls.Add(this.tabPage2);
            this.f.Location = new System.Drawing.Point(-4, 0);
            this.f.Name = "f";
            this.f.SelectedIndex = 0;
            this.f.Size = new System.Drawing.Size(560, 273);
            this.f.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rtb_Announcement);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(552, 247);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "公告";
            // 
            // rtb_Announcement
            // 
            this.rtb_Announcement.Location = new System.Drawing.Point(6, 6);
            this.rtb_Announcement.Name = "rtb_Announcement";
            this.rtb_Announcement.Size = new System.Drawing.Size(538, 207);
            this.rtb_Announcement.TabIndex = 0;
            this.rtb_Announcement.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rtb_Message);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(552, 247);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "留言";
            // 
            // rtb_Message
            // 
            this.rtb_Message.Location = new System.Drawing.Point(6, 6);
            this.rtb_Message.Name = "rtb_Message";
            this.rtb_Message.Size = new System.Drawing.Size(540, 230);
            this.rtb_Message.TabIndex = 1;
            this.rtb_Message.Text = "";
            // 
            // tp_PersonalInformation
            // 
            this.tp_PersonalInformation.Controls.Add(this.txb_Hobby);
            this.tp_PersonalInformation.Controls.Add(this.cb_Class);
            this.tp_PersonalInformation.Controls.Add(this.label6);
            this.tp_PersonalInformation.Controls.Add(this.rBtn_Girl);
            this.tp_PersonalInformation.Controls.Add(this.rBtn_Boy);
            this.tp_PersonalInformation.Controls.Add(this.label5);
            this.tp_PersonalInformation.Controls.Add(this.label4);
            this.tp_PersonalInformation.Controls.Add(this.dtp_Birthdate);
            this.tp_PersonalInformation.Controls.Add(this.label3);
            this.tp_PersonalInformation.Controls.Add(this.txb_Name);
            this.tp_PersonalInformation.Controls.Add(this.txb_No);
            this.tp_PersonalInformation.Controls.Add(this.label2);
            this.tp_PersonalInformation.Controls.Add(this.label1);
            this.tp_PersonalInformation.Location = new System.Drawing.Point(4, 22);
            this.tp_PersonalInformation.Name = "tp_PersonalInformation";
            this.tp_PersonalInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tp_PersonalInformation.Size = new System.Drawing.Size(550, 213);
            this.tp_PersonalInformation.TabIndex = 1;
            this.tp_PersonalInformation.Text = "个人信息";
            // 
            // txb_Hobby
            // 
            this.txb_Hobby.Location = new System.Drawing.Point(330, 129);
            this.txb_Hobby.Name = "txb_Hobby";
            this.txb_Hobby.Size = new System.Drawing.Size(128, 21);
            this.txb_Hobby.TabIndex = 13;
            // 
            // cb_Class
            // 
            this.cb_Class.FormattingEnabled = true;
            this.cb_Class.Location = new System.Drawing.Point(330, 87);
            this.cb_Class.Name = "cb_Class";
            this.cb_Class.Size = new System.Drawing.Size(128, 20);
            this.cb_Class.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "特长：";
            // 
            // rBtn_Girl
            // 
            this.rBtn_Girl.AutoSize = true;
            this.rBtn_Girl.Location = new System.Drawing.Point(178, 130);
            this.rBtn_Girl.Name = "rBtn_Girl";
            this.rBtn_Girl.Size = new System.Drawing.Size(35, 16);
            this.rBtn_Girl.TabIndex = 10;
            this.rBtn_Girl.TabStop = true;
            this.rBtn_Girl.Text = "女";
            this.rBtn_Girl.UseVisualStyleBackColor = true;
            // 
            // rBtn_Boy
            // 
            this.rBtn_Boy.AutoSize = true;
            this.rBtn_Boy.Location = new System.Drawing.Point(137, 130);
            this.rBtn_Boy.Name = "rBtn_Boy";
            this.rBtn_Boy.Size = new System.Drawing.Size(35, 16);
            this.rBtn_Boy.TabIndex = 9;
            this.rBtn_Boy.TabStop = true;
            this.rBtn_Boy.Text = "男";
            this.rBtn_Boy.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "性别：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "班级：";
            // 
            // dtp_Birthdate
            // 
            this.dtp_Birthdate.Location = new System.Drawing.Point(330, 42);
            this.dtp_Birthdate.Name = "dtp_Birthdate";
            this.dtp_Birthdate.Size = new System.Drawing.Size(128, 21);
            this.dtp_Birthdate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "生日：";
            // 
            // txb_Name
            // 
            this.txb_Name.Location = new System.Drawing.Point(137, 87);
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.Size = new System.Drawing.Size(100, 21);
            this.txb_Name.TabIndex = 3;
            // 
            // txb_No
            // 
            this.txb_No.Location = new System.Drawing.Point(137, 42);
            this.txb_No.Name = "txb_No";
            this.txb_No.Size = new System.Drawing.Size(100, 21);
            this.txb_No.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "学号：";
            // 
            // tp_TeachingWeek
            // 
            this.tp_TeachingWeek.Controls.Add(this.dgv_TeachingWeek);
            this.tp_TeachingWeek.Location = new System.Drawing.Point(4, 22);
            this.tp_TeachingWeek.Name = "tp_TeachingWeek";
            this.tp_TeachingWeek.Padding = new System.Windows.Forms.Padding(3);
            this.tp_TeachingWeek.Size = new System.Drawing.Size(550, 213);
            this.tp_TeachingWeek.TabIndex = 2;
            this.tp_TeachingWeek.Text = "教学周历";
            // 
            // dgv_TeachingWeek
            // 
            this.dgv_TeachingWeek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TeachingWeek.Location = new System.Drawing.Point(0, 0);
            this.dgv_TeachingWeek.Name = "dgv_TeachingWeek";
            this.dgv_TeachingWeek.RowTemplate.Height = 23;
            this.dgv_TeachingWeek.Size = new System.Drawing.Size(547, 213);
            this.dgv_TeachingWeek.TabIndex = 0;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(291, 252);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(82, 30);
            this.btn_Update.TabIndex = 17;
            this.btn_Update.Text = "更新";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click_1);
            // 
            // btn_Load
            // 
            this.btn_Load.Location = new System.Drawing.Point(184, 252);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(82, 30);
            this.btn_Load.TabIndex = 16;
            this.btn_Load.Text = "载入";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click_1);
            // 
            // frm_MyDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 294);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.tc_mydesktop);
            this.Name = "frm_MyDesktop";
            this.Text = "我的桌面";
            this.tc_mydesktop.ResumeLayout(false);
            this.tp_Message.ResumeLayout(false);
            this.f.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tp_PersonalInformation.ResumeLayout(false);
            this.tp_PersonalInformation.PerformLayout();
            this.tp_TeachingWeek.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TeachingWeek)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc_mydesktop;
        private System.Windows.Forms.TabPage tp_Message;
        private System.Windows.Forms.TabPage tp_PersonalInformation;
        private System.Windows.Forms.TabPage tp_TeachingWeek;
        private System.Windows.Forms.TabControl f;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txb_Hobby;
        private System.Windows.Forms.ComboBox cb_Class;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rBtn_Girl;
        private System.Windows.Forms.RadioButton rBtn_Boy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_Birthdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_Name;
        private System.Windows.Forms.TextBox txb_No;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtb_Announcement;
        private System.Windows.Forms.RichTextBox rtb_Message;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.DataGridView dgv_TeachingWeek;
    }
}