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
    public partial class frm_StudentAchievement : Form
    {
        public frm_StudentAchievement()
        {
            InitializeComponent();
        }

        private void btn_Look_Click(object sender, EventArgs e)
        {
            SqlHelper sqlHelper = new SqlHelper();
            var scoreTable = sqlHelper
                .NewCommand("SELECT * FROM tb_Score;")
                .ReturnTable();
            this.dgv_Score.DataSource = scoreTable;
            var studentManagementTable=sqlHelper
                .NewCommand("SELECT * FROM tb_StudentManagement;")
                .ReturnTable();
            this.dgv_StudentMgament.DataSource = studentManagementTable;
            var dangerTable = sqlHelper
                .NewCommand("SELECT * FROM tb_Danger;")
                .ReturnTable();
            this.dgv_Danger.DataSource = dangerTable;
            var activeTable = sqlHelper
                .NewCommand("SELECT * FROM tb_Active;")
                .ReturnTable();
            this.dgv_Active.DataSource = activeTable;
            var ApplyExcStuTable = sqlHelper
                .NewCommand("SELECT * FROM tb_ApplyExcStu;")
                .ReturnTable();
            this.dgv_ApplyExcStu.DataSource = ApplyExcStuTable;
            var LevelExamScoreTable = sqlHelper
                .NewCommand("SELECT * FROM tb_LevelExamScore;")
                .ReturnTable();
            this.dgv_LevelExamScore.DataSource = LevelExamScoreTable;
            var ScoreFactTable = sqlHelper
                .NewCommand("SELECT * FROM tb_ScoreFact;")
                .ReturnTable();
            this.dgv_ScoreFact.DataSource = ScoreFactTable;
        }
    }
}
