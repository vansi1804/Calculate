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
    public partial class frmTimKiemMatHang : DevComponents.DotNetBar.Office2007Form
    {
        MatHangCtrl m_MatHangCtrl = new MatHangCtrl();
        LoaiTienCtrl m_LoaiTienCtrl = new LoaiTienCtrl();
        LoaiGiaoDichCtrl m_LoaiGiaoDichCtrl = new LoaiGiaoDichCtrl();
        NhaCungCapCtrl m_NhaCungCapCtrl = new NhaCungCapCtrl();
        public frmTimKiemMatHang()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmTimKiemMatHang_Load(object sender, EventArgs e)
        {
            m_LoaiTienCtrl.HienThiDataGridViewComboBoxColumn(colLoaiTien);
            m_LoaiGiaoDichCtrl.HienThiDataGridViewComboBoxColumn(colLoaiGD);
            m_NhaCungCapCtrl.HienThiDataGridViewComboBoxColumn(colTenNCC);
            m_MatHangCtrl.HienThi(DGVMatHang, BindingNavigatorMatHang);
        }
        #region Tìm kiếm mặt hàng
        private void btnSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TimKiemMatHang();
            }
        }

        void TimKiemMatHang()
        {
            try
            {
                if (cbMaMH.Checked == true)
                {
                    m_MatHangCtrl.TimKiemTheoMa(txtTimKiem.Text);
                }
                else if (cbTenMH.Checked == true)
                {
                    m_MatHangCtrl.TiemKiemTheoTen(txtTimKiem.Text);
                }
            }
            catch
            {
                MessageBoxEx.Show("Không thể tìm thấy Giá trị cần tìm!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                MessageBoxEx.Show("Giá trị tìm rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TimKiemMatHang();
            }
        }
        #endregion

        private void bindingNavigatorCloseItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}