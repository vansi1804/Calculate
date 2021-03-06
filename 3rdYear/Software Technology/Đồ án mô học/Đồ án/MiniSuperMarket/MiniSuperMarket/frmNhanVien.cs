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
    public partial class frmNhanVien : Office2007Form
    {
        QuyDinh m_QuyDinh = new QuyDinh();
        NhanVienCtrl m_NhanVienCtrl = new NhanVienCtrl();
        QuayGiaoDichCtrl m_QuayGiaoDihCtrl = new QuayGiaoDichCtrl();
        public frmNhanVien()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            m_QuayGiaoDihCtrl.HienThiComboBox(cmbQuayGiaoDich);
            m_QuayGiaoDihCtrl.HienThiDataGridViewComboBoxColumn(colMaQuayGD);
            m_NhanVienCtrl.HienThi(DGVNhanVien, BindingNavigatorNhanVien, txtMaNV, txtHoTen, dtNgaySinh, txtDiaChi, txtSoDienThoai, cmbQuayGiaoDich);
        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            m_QuayGiaoDihCtrl.HienThiComboBox(cmbQuayGiaoDich);
            m_QuayGiaoDihCtrl.HienThiDataGridViewComboBoxColumn(colMaQuayGD);
            m_NhanVienCtrl.HienThi(DGVNhanVien, BindingNavigatorNhanVien, txtMaNV, txtHoTen, dtNgaySinh, txtDiaChi, txtSoDienThoai, cmbQuayGiaoDich);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (DGVNhanVien.RowCount == 0)
                BindingNavigatorNhanVien.Enabled = true;
            DataRow m_Row = m_NhanVienCtrl.ThemDongMoi();
            m_Row["MaNV"] = "NV" + m_QuyDinh.LaySTT(DGVNhanVien.Rows.Count + 1);
            m_Row["HoTenNV"] = "";
            m_Row["NgaySinh"] = DateTime.Today;
            m_Row["DiaChi"] = "";
            m_Row["DienThoai"] = "";
            m_Row["MaQuayGiaoDich"] = "";

            m_NhanVienCtrl.ThemMoi(m_Row);
            BindingNavigatorNhanVien.BindingSource.MoveLast();
        }
        public Boolean KiemTraTruocKhiLuu(String str)
        {
            foreach (DataGridViewRow row in DGVNhanVien.Rows)
            {
                if (row.Cells[str].Value != null)
                {
                    String m_Str = row.Cells[str].Value.ToString();
                    if (m_Str == "")
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (KiemTraTruocKhiLuu("colMaNV") == true &&
                    KiemTraTruocKhiLuu("colHoTen") == true &&
                    KiemTraTruocKhiLuu("colDiaChi") == true &&
                    KiemTraTruocKhiLuu("colDienThoai") == true &&
                    KiemTraTruocKhiLuu("colNgaySinh") == true &&
                    KiemTraTruocKhiLuu("colMaQuayGD") == true)
                    bindingNavigatorPositionItem.Focus();
                m_NhanVienCtrl.LuuNhanVien();
            }
            catch
            {
                MessageBoxEx.Show("Giá trị ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (DGVNhanVien.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else
                if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BindingNavigatorNhanVien.BindingSource.RemoveCurrent();
                }
        }

        private void bindingNavigatorCloseItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiQuayGiaoDich();
        }
        #region Tim Kiem nhan vien
        private void btnSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TimKiemNhanVien();
            }
        }

        void TimKiemNhanVien()
        {
            try
            {
                if (cbMaNV.Checked == true)
                {
                    m_NhanVienCtrl.TimKiemTheoMa(txtTimKiem.Text);
                }
                else if (cbHoTen.Checked == true)
                {
                    m_NhanVienCtrl.TiemKiemTheoTen(txtTimKiem.Text);
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
                TimKiemNhanVien();
            }

        }
        #endregion

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if (DGVNhanVien.RowCount == 0)
                BindingNavigatorNhanVien.Enabled = true;
            DataRow m_Row = m_NhanVienCtrl.ThemDongMoi();
            m_Row["MaNV"] = "NV" + m_QuyDinh.LaySTT(DGVNhanVien.Rows.Count + 1);
            m_Row["HoTenNV"] = "";
            m_Row["NgaySinh"] = DateTime.Today;
            m_Row["DiaChi"] = "";
            m_Row["DienThoai"] = "";
            m_Row["MaQuayGiaoDich"] = "";

            m_NhanVienCtrl.ThemMoi(m_Row);
            BindingNavigatorNhanVien.BindingSource.MoveLast();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text != "" && txtDiaChi.Text != "" && txtSoDienThoai.Text != "" && dtNgaySinh.Value != null && cmbQuayGiaoDich.SelectedValue != null)
            {
                m_NhanVienCtrl.LuuNhanVien(txtMaNV.Text, txtHoTen.Text, dtNgaySinh.Value, txtDiaChi.Text, txtSoDienThoai.Text, cmbQuayGiaoDich.SelectedValue.ToString());
                m_NhanVienCtrl.HienThi(DGVNhanVien, BindingNavigatorNhanVien, txtMaNV, txtHoTen, dtNgaySinh, txtDiaChi, txtSoDienThoai, cmbQuayGiaoDich);
                MessageBoxEx.Show("Đã lưu thành công!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBoxEx.Show("Phải nhập đầy đủ dữ liệu để thêm nhân viên", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            m_NhanVienCtrl.SuaNhanVien(txtMaNV.Text, txtHoTen.Text, dtNgaySinh.Value, txtDiaChi.Text, txtSoDienThoai.Text, cmbQuayGiaoDich.SelectedValue.ToString());
            m_NhanVienCtrl.HienThi(DGVNhanVien, BindingNavigatorNhanVien, txtMaNV, txtHoTen, dtNgaySinh, txtDiaChi, txtSoDienThoai, cmbQuayGiaoDich);
            MessageBoxEx.Show("Đã sửa thành công!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("Bạn có chắc chắn xóa nhân viên này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                m_NhanVienCtrl.XoaNhanVien(txtMaNV.Text);
                m_NhanVienCtrl.HienThi(DGVNhanVien, BindingNavigatorNhanVien, txtMaNV, txtHoTen, dtNgaySinh, txtDiaChi, txtSoDienThoai, cmbQuayGiaoDich);
            }
        }
    }
}