using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using MiniSuperMarket.Controller;
using MiniSuperMarket.DataLayer;
using MiniSuperMarket.General;

namespace MiniSuperMarket
{
    public partial class frmTimKiemKhachHang : Office2007Form
    {
        KhachHangCtrl m_KhachHangCtrl = new KhachHangCtrl();
        public frmTimKiemKhachHang()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmTimKiemKhachHang_Load(object sender, EventArgs e)
        {
            m_KhachHangCtrl.HienThi(DGVKhachHang, BindingNavigatorKhachHang);
        }

        #region Tìm kiếm khách hàng
        private void btnSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TimKiemKhachHang();
            }
        }

        void TimKiemKhachHang()
        {
            try
            {
                if (cbMaKH.Checked == true)
                {
                    m_KhachHangCtrl.TimKiemTheoMa(txtTimKiem.Text);
                }
                else
                {
                    m_KhachHangCtrl.TimKiemTheoTen(txtTimKiem.Text);
                }

            }
            catch
            {
                MessageBoxEx.Show("Không thể tìm thấy Giá trị cần tìm!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
         private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                MessageBoxEx.Show("Giá trị tìm rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TimKiemKhachHang();
            }
        }

        #endregion  

        private void bindingNavigatorCloseItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}