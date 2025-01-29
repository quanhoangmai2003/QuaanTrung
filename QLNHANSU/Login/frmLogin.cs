using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using BusinessLayer;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;

namespace QLNHANSU.Login
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        USERS _user;
        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            _user = new USERS();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int lg = _user.Login(txtUsername.Text, txtPass.Text);
            if (lg == 1)
            {
                if (Commons.handle != null)
                    SplashScreenManager.CloseOverlayForm(Commons.handle);
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng. ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}