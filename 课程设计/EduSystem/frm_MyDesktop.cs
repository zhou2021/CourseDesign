using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartLinli.DatabaseDevelopement;

namespace EduSystem
{
    public partial class frm_MyDesktop : Form
    {
        public frm_MyDesktop()
        {
            InitializeComponent();
        }
        private void btn_Load_Click_1(object sender, EventArgs e)
        {
            string
                studentCommand = $"SELECT * FROM tb_Student WHERE  No='{this.txb_No.Text.Trim() }';"
                , classCommand = "SELECT * FROM tb_Class";
            SqlHelper sqlHelper = new SqlHelper();
            var teachingWeekTable = sqlHelper
                .NewCommand("SELECT * FROM tb_TeachingWeek;")
                .ReturnTable();
            this.dgv_TeachingWeek.DataSource = teachingWeekTable;
            var studentReader = sqlHelper.NewCommand(studentCommand).ReturnReader();
            var classTable = sqlHelper.NewCommand(classCommand).ReturnTable();
            this.cb_Class.DataSource = classTable;
            this.cb_Class.ValueMember = "No";
            this.cb_Class.DisplayMember = "Name";
            if (studentReader.Read())
            {
                this.txb_No.Text = studentReader["No"].ToString();
                this.txb_Name.Text = studentReader["Name"].ToString();
                this.rBtn_Boy.Checked = (bool)studentReader["Gender"];
                this.rBtn_Girl.Checked = !(bool)studentReader["Gender"];
                this.dtp_Birthdate.Value = (DateTime)studentReader["BirthDate"];
                this.cb_Class.SelectedValue = (int)studentReader["ClassNo"];
                this.txb_Hobby.Text = studentReader["Speciality"].ToString();
                this.rtb_Announcement.Text = studentReader["Announcement"].ToString();
                this.rtb_Message.Text = studentReader["Message"].ToString();
            }
        }

        private void btn_Update_Click_1(object sender, EventArgs e)
        {

            string commandText =
                $"UPDATE tb_Student"
                + $" SET"
                + $" Name='{this.txb_Name.Text.Trim()}'"
                + $" ,Gender='{this.rBtn_Boy.Checked }'"
                + $" ,BirthDate='{this.dtp_Birthdate.Value }'"
                + $" ,ClassNo={this.cb_Class.SelectedValue }"
                + $" ,Speciality='{this.txb_Hobby.Text.Trim()}'"
                + $" WHERE No='{this.txb_No.Text.Trim()}';";
            SqlHelper sqlHelper = new SqlHelper();
            int rowAffected = sqlHelper
                .NewCommand(commandText).Submit();
            MessageBox.Show($"更新{rowAffected }行。");
        }
    }
}
