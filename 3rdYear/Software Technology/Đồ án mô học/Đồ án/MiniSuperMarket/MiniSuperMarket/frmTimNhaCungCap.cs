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
    public partial class frmTimNhaCungCap : Office2007Form
    {
        NhaCungCapCtrl m_NhaCungCapCtrl = new NhaCungCapCtrl();
        public frmTimNhaCungCap()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmTimNhaCungCap_Load(object sender, EventArgs e)
        {
            m_NhaCungCapCtrl.HienThi(DGVNhaCungCap, BindingNavigatorNhaCungCap);
        }
        #region Tìm kiếm nhà cung cấp
        private void btnSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TimKiemNhaCungCap();
            }
        }

        void TimKiemNhaCungCap()
        {
            try
            {
                if (cbMaNCC.Checked == true)
                {
                    m_NhaCungCapCtrl.TimKiemTheoMa(txtTimKiem.Text);
                }
                else if (cbTenNCC.Checked == true)
                {
                    m_NhaCungCapCtrl.TiemKiemTheoTen(txtTimKiem.Text);
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
                TimKiemNhaCungCap();
            }
        }
        #endregion

        private void bindingNavigatorCloseItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}