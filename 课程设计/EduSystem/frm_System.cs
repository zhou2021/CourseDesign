using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduSystem
{
    public partial class frm_System : Form
    {
        public frm_System()
        {
            InitializeComponent();
        }

        private void frm_System_Load(object sender, EventArgs e)
        {
            this.FormClosing += Frm_System_FormClosing;
        }

        private void Frm_System_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_MyDesktop frm_MyDesktop = new frm_MyDesktop();
            frm_MyDesktop.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_StudentAchievement frm_StudentAchievement = new frm_StudentAchievement();
            frm_StudentAchievement.ShowDialog();
        }
    }
}
