namespace EduSystem
{
    partial class frm_StudentAchievement
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
            this.tc = new System.Windows.Forms.TabControl();
            this.tp_StudentManagement = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv_StudentMgament = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgv_Danger = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgv_Active = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.dgv_ApplyExcStu = new System.Windows.Forms.DataGridView();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.dgv_ExcStuScore = new System.Windows.Forms.DataGridView();
            this.tp_MyAchievement = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.dgv_Score = new System.Windows.Forms.DataGridView();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.dgv_LevelExamScore = new System.Windows.Forms.DataGridView();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.dgv_ScoreFact = new System.Windows.Forms.DataGridView();
            this.btn_Look = new System.Windows.Forms.Button();
            this.tc.SuspendLayout();
            this.tp_StudentManagement.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StudentMgament)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Danger)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Active)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ApplyExcStu)).BeginInit();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ExcStuScore)).BeginInit();
            this.tp_MyAchievement.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Score)).BeginInit();
            this.tabPage10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LevelExamScore)).BeginInit();
            this.tabPage12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ScoreFact)).BeginInit();
            this.SuspendLayout();
            // 
            // tc
            // 
            this.tc.Controls.Add(this.tp_StudentManagement);
            this.tc.Controls.Add(this.tp_MyAchievement);
            this.tc.Location = new System.Drawing.Point(1, 3);
            this.tc.Name = "tc";
            this.tc.SelectedIndex = 0;
            this.tc.Size = new System.Drawing.Size(749, 435);
            this.tc.TabIndex = 0;
            // 
            // tp_StudentManagement
            // 
            this.tp_StudentManagement.BackColor = System.Drawing.SystemColors.Control;
            this.tp_StudentManagement.Controls.Add(this.tabControl1);
            this.tp_StudentManagement.Location = new System.Drawing.Point(4, 22);
            this.tp_StudentManagement.Name = "tp_StudentManagement";
            this.tp_StudentManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tp_StudentManagement.Size = new System.Drawing.Size(741, 409);
            this.tp_StudentManagement.TabIndex = 0;
            this.tp_StudentManagement.Text = "学籍管理";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(738, 403);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(730, 377);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "学籍卡片";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.dgv_StudentMgament);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(730, 377);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "学籍信息管理";
            // 
            // dgv_StudentMgament
            // 
            this.dgv_StudentMgament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_StudentMgament.Location = new System.Drawing.Point(3, 3);
            this.dgv_StudentMgament.Name = "dgv_StudentMgament";
            this.dgv_StudentMgament.RowTemplate.Height = 23;
            this.dgv_StudentMgament.Size = new System.Drawing.Size(727, 374);
            this.dgv_StudentMgament.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.dgv_Danger);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(730, 377);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "学籍预警查询";
            // 
            // dgv_Danger
            // 
            this.dgv_Danger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Danger.Location = new System.Drawing.Point(2, 1);
            this.dgv_Danger.Name = "dgv_Danger";
            this.dgv_Danger.RowTemplate.Height = 23;
            this.dgv_Danger.Size = new System.Drawing.Size(727, 374);
            this.dgv_Danger.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.dgv_Active);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(730, 377);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "学籍异动信息";
            // 
            // dgv_Active
            // 
            this.dgv_Active.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Active.Location = new System.Drawing.Point(2, 1);
            this.dgv_Active.Name = "dgv_Active";
            this.dgv_Active.RowTemplate.Height = 23;
            this.dgv_Active.Size = new System.Drawing.Size(727, 374);
            this.dgv_Active.TabIndex = 1;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(730, 377);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "专业分流";
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(730, 377);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "交换生选课";
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage7.Controls.Add(this.dgv_ApplyExcStu);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(730, 377);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "申请交换生";
            // 
            // dgv_ApplyExcStu
            // 
            this.dgv_ApplyExcStu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ApplyExcStu.Location = new System.Drawing.Point(2, 1);
            this.dgv_ApplyExcStu.Name = "dgv_ApplyExcStu";
            this.dgv_ApplyExcStu.RowTemplate.Height = 23;
            this.dgv_ApplyExcStu.Size = new System.Drawing.Size(727, 374);
            this.dgv_ApplyExcStu.TabIndex = 1;
            // 
            // tabPage8
            // 
            this.tabPage8.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage8.Controls.Add(this.dgv_ExcStuScore);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(730, 377);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "交换生成绩";
            // 
            // dgv_ExcStuScore
            // 
            this.dgv_ExcStuScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ExcStuScore.Location = new System.Drawing.Point(2, 1);
            this.dgv_ExcStuScore.Name = "dgv_ExcStuScore";
            this.dgv_ExcStuScore.RowTemplate.Height = 23;
            this.dgv_ExcStuScore.Size = new System.Drawing.Size(727, 374);
            this.dgv_ExcStuScore.TabIndex = 1;
            // 
            // tp_MyAchievement
            // 
            this.tp_MyAchievement.BackColor = System.Drawing.SystemColors.Control;
            this.tp_MyAchievement.Controls.Add(this.tabControl2);
            this.tp_MyAchievement.Location = new System.Drawing.Point(4, 22);
            this.tp_MyAchievement.Name = "tp_MyAchievement";
            this.tp_MyAchievement.Padding = new System.Windows.Forms.Padding(3);
            this.tp_MyAchievement.Size = new System.Drawing.Size(741, 409);
            this.tp_MyAchievement.TabIndex = 1;
            this.tp_MyAchievement.Text = "我的成绩";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage9);
            this.tabControl2.Controls.Add(this.tabPage10);
            this.tabControl2.Controls.Add(this.tabPage11);
            this.tabControl2.Controls.Add(this.tabPage12);
            this.tabControl2.Location = new System.Drawing.Point(0, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(741, 403);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage9
            // 
            this.tabPage9.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage9.Controls.Add(this.dgv_Score);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(733, 377);
            this.tabPage9.TabIndex = 0;
            this.tabPage9.Text = "课程成绩查询";
            // 
            // dgv_Score
            // 
            this.dgv_Score.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Score.Location = new System.Drawing.Point(3, 1);
            this.dgv_Score.Name = "dgv_Score";
            this.dgv_Score.RowTemplate.Height = 23;
            this.dgv_Score.Size = new System.Drawing.Size(727, 374);
            this.dgv_Score.TabIndex = 1;
            // 
            // tabPage10
            // 
            this.tabPage10.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage10.Controls.Add(this.dgv_LevelExamScore);
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(733, 377);
            this.tabPage10.TabIndex = 1;
            this.tabPage10.Text = "等级考试成绩";
            // 
            // dgv_LevelExamScore
            // 
            this.dgv_LevelExamScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LevelExamScore.Location = new System.Drawing.Point(3, 1);
            this.dgv_LevelExamScore.Name = "dgv_LevelExamScore";
            this.dgv_LevelExamScore.RowTemplate.Height = 23;
            this.dgv_LevelExamScore.Size = new System.Drawing.Size(727, 374);
            this.dgv_LevelExamScore.TabIndex = 1;
            // 
            // tabPage11
            // 
            this.tabPage11.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage11.Location = new System.Drawing.Point(4, 22);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(733, 377);
            this.tabPage11.TabIndex = 2;
            this.tabPage11.Text = "OSCE成绩查询";
            // 
            // tabPage12
            // 
            this.tabPage12.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage12.Controls.Add(this.dgv_ScoreFact);
            this.tabPage12.Location = new System.Drawing.Point(4, 22);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage12.Size = new System.Drawing.Size(733, 377);
            this.tabPage12.TabIndex = 3;
            this.tabPage12.Text = "成绩认定";
            // 
            // dgv_ScoreFact
            // 
            this.dgv_ScoreFact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ScoreFact.Location = new System.Drawing.Point(3, 1);
            this.dgv_ScoreFact.Name = "dgv_ScoreFact";
            this.dgv_ScoreFact.RowTemplate.Height = 23;
            this.dgv_ScoreFact.Size = new System.Drawing.Size(727, 374);
            this.dgv_ScoreFact.TabIndex = 1;
            // 
            // btn_Look
            // 
            this.btn_Look.Location = new System.Drawing.Point(335, 444);
            this.btn_Look.Name = "btn_Look";
            this.btn_Look.Size = new System.Drawing.Size(82, 30);
            this.btn_Look.TabIndex = 1;
            this.btn_Look.Text = "查看";
            this.btn_Look.UseVisualStyleBackColor = true;
            this.btn_Look.Click += new System.EventHandler(this.btn_Look_Click);
            // 
            // frm_StudentAchievement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 486);
            this.Controls.Add(this.btn_Look);
            this.Controls.Add(this.tc);
            this.Name = "frm_StudentAchievement";
            this.Text = "学籍成绩";
            this.tc.ResumeLayout(false);
            this.tp_StudentManagement.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StudentMgament)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Danger)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Active)).EndInit();
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ApplyExcStu)).EndInit();
            this.tabPage8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ExcStuScore)).EndInit();
            this.tp_MyAchievement.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Score)).EndInit();
            this.tabPage10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LevelExamScore)).EndInit();
            this.tabPage12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ScoreFact)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc;
        private System.Windows.Forms.TabPage tp_StudentManagement;
        private System.Windows.Forms.TabPage tp_MyAchievement;
        private System.Windows.Forms.Button btn_Look;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.TabPage tabPage12;
        private System.Windows.Forms.DataGridView dgv_StudentMgament;
        private System.Windows.Forms.DataGridView dgv_Danger;
        private System.Windows.Forms.DataGridView dgv_Active;
        private System.Windows.Forms.DataGridView dgv_ApplyExcStu;
        private System.Windows.Forms.DataGridView dgv_ExcStuScore;
        private System.Windows.Forms.DataGridView dgv_Score;
        private System.Windows.Forms.DataGridView dgv_LevelExamScore;
        private System.Windows.Forms.DataGridView dgv_ScoreFact;
    }
}