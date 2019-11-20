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

namespace 课程设计
{
    public partial class frm_SignUp : Form
    {
        public frm_SignUp()
        {
            InitializeComponent();
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            string commandText =
                "INSERT tb_User(No,Password)"
                + $" VALUES('{this.tb_Users.Text }','{this.tb_Password.Text}')";
            SqlHelper sqlHelper = new SqlHelper();
            int rowAffected = sqlHelper.QuickReturn<int>(commandText);
            if (rowAffected == 1)
            {
                MessageBox.Show("注册成功！");
            }
            else
            {
                MessageBox.Show("注册失败！");
            }
        }
    }
}
