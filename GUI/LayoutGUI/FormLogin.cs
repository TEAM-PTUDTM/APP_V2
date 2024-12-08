using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI.LayoutGUI
{
    public partial class FormLogin : Form
    {
        EmployeeBLL NVbll = new EmployeeBLL();
        public FormLogin()
        {
            InitializeComponent();
            this.btnLogin.Click += BtnLogin_Click;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != "" && txtPassword.Text != "")
            {
                if (NVbll.Login(txtEmail.Text, txtPassword.Text))
                {
                    Properties.Settings.Default.isSave = tglRememberMe.Checked;
                    if (tglRememberMe.Checked)
                    {
                        Properties.Settings.Default.email = txtEmail.Text;
                        Properties.Settings.Default.password = txtPassword.Text;
                    }
                    Properties.Settings.Default.Save();
                    FormMain fMain = new FormMain(txtEmail.Text);
                    this.Hide();
                    fMain.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Sai email hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Text = "";
                    txtPassword.Text = "";
                    txtEmail.Focus();
                }
            }
        }
    }
}
