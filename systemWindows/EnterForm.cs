using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace systemWindows
{
    public partial class denglu : Form
    {
        public denglu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            systemName.BackColor = Color.Transparent;
            userName.BackColor = Color.Transparent;
            userSecret.BackColor = Color.Transparent;
            userNameText.Text = "admin";
            passwdText.Text = "admin";

        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (userNameText.Text == "admin" && passwdText.Text == "admin")
            {
                AllMethodMessage form = new AllMethodMessage();
                form.StartPosition = FormStartPosition.CenterScreen;  //使窗口显示在屏幕正中心
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("用户名或者密码错误");

            }
        }

        private void quitButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

   
    }
}
