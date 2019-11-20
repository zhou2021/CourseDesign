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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string commandText1 =
                "SELECT 1"
                + " FROM tb_User"
                + $" WHERE No = '{this.tb_Users.Text }'"
                + $" AND Password = '{this.tb_Password.Text }'";
            SqlHelper sqlHelper = new SqlHelper();
            int result = sqlHelper.QuickReturn<int>(commandText1);
            if (result == 1)
            {
                MessageBox.Show("登录成功！");
                frm_System system = new frm_System();
                system.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("登录失败！用户号/密码错误！");
            }

        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            frm_SignUp signUp = new frm_SignUp();
            signUp.ShowDialog();
        }
    }
}
