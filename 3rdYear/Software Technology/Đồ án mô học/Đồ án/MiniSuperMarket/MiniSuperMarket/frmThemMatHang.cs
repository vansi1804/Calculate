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
    public partial class frmThemMatHang : Office2007Form
    {
        QuyDinh m_QuyDinh = new QuyDinh();
        MatHangCtrl m_MatHangCtrl = new MatHangCtrl();
        LoaiTienCtrl m_LoaiTienCtrl = new LoaiTienCtrl();
        LoaiGiaoDichCtrl m_LoaiGiaoDichCtrl = new LoaiGiaoDichCtrl();
        NhaCungCapCtrl m_NhaCungCapCtrl = new NhaCungCapCtrl();
        public frmThemMatHang()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmThemMatHang_Load(object sender, EventArgs e)
        {
            m_LoaiTienCtrl.HienThiComboBox(cmbLoaiTienGui);
            m_LoaiTienCtrl.HienThiDataGridViewComboBoxColumn(colLoaiTien);
            m_LoaiGiaoDichCtrl.HienThiComboBox(cmbLoaiGiaoDich);
            m_LoaiGiaoDichCtrl.HienThiDataGridViewComboBoxColumn(colLoaiGD);
            m_NhaCungCapCtrl.HienThiComboBox(cmbTenNCC);
            m_NhaCungCapCtrl.HienThiDataGridViewComboBoxColumn(colTenNCC);
            m_MatHangCtrl.HienThi(DGVMatHang, BindingNavigatorMatHang, txtMaPhieu, txtMaMH, txtTenMH, dtNgayNhap, txtSoLuong, txtDonGia, txtGiaBan, txtMaNCC, cmbTenNCC, cmbLoaiGiaoDich, cmbLoaiTienGui);
        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {

            txtTimKiem.Text = "";
            m_LoaiTienCtrl.HienThiComboBox(cmbLoaiTienGui);
            m_LoaiTienCtrl.HienThiDataGridViewComboBoxColumn(colLoaiTien);
            m_LoaiGiaoDichCtrl.HienThiComboBox(cmbLoaiGiaoDich);
            m_LoaiGiaoDichCtrl.HienThiDataGridViewComboBoxColumn(colLoaiGD);
            m_NhaCungCapCtrl.HienThiComboBox(cmbTenNCC);
            m_NhaCungCapCtrl.HienThiDataGridViewComboBoxColumn(colTenNCC);
            m_MatHangCtrl.HienThi(DGVMatHang, BindingNavigatorMatHang, txtMaPhieu, txtMaMH, txtTenMH, dtNgayNhap, txtSoLuong, txtDonGia, txtGiaBan, txtMaNCC, cmbTenNCC, cmbLoaiGiaoDich, cmbLoaiTienGui);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (DGVMatHang.RowCount == 0)
                BindingNavigatorMatHang.Enabled = true;
            DataRow m_Row = m_MatHangCtrl.ThemDongMoi();
            m_Row["MaPhieu"] = "NH" + m_QuyDinh.LaySTT(DGVMatHang.Rows.Count + 1);
            m_Row["MaMH"] = "MH" + m_QuyDinh.LaySTT(DGVMatHang.Rows.Count + 1);
            m_Row["TenMH"] = "";
            m_Row["MaNCC"] = "";
            m_Row["NgayNhap"] = DateTime.Today;
            m_Row["SoLuong"] = 0;
            m_Row["DonGia"] = 0;
            m_Row["GiaBan"] = 0;
            m_Row["MaLoaiGiaoDich"] = "";
            m_Row["MaLoaiTien"] = "";

            m_MatHangCtrl.ThemMoi(m_Row);
            BindingNavigatorMatHang.BindingSource.MoveLast();
        }
        public Boolean KiemTraTruocKhiLuu(String str)
        {
            foreach (DataGridViewRow row in DGVMatHang.Rows)
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
            if (    KiemTraTruocKhiLuu("colMaPhieu") == true &&
                    KiemTraTruocKhiLuu("colMaMH") == true &&
                    KiemTraTruocKhiLuu("colTenMH") == true &&
                    KiemTraTruocKhiLuu("colMaNCC") == true &&
                    KiemTraTruocKhiLuu("colTenNCC") == true &&
                    KiemTraTruocKhiLuu("colDonGia") == true &&
                    KiemTraTruocKhiLuu("colGiaBan") == true &&
                    KiemTraTruocKhiLuu("colLoaiTien") == true &&
                    KiemTraTruocKhiLuu("colLoaiGD") == true &&
                    KiemTraTruocKhiLuu("colNgayNhap") == true &&
                    KiemTraTruocKhiLuu("colSoLuong") == true)
             {
                bindingNavigatorPositionItem.Focus();
                m_MatHangCtrl.LuuMatHang();
            }
            else
            {
                MessageBoxEx.Show("Giá trị ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (DGVMatHang.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else
                if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BindingNavigatorMatHang.BindingSource.RemoveCurrent();
                }
        }

        private void bindingNavigatorCloseItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiNhaCungCap();
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            txtTenMH.Text = "";
            txtSoLuong.Text = "0";
            txtDonGia.Text = "0";
            txtGiaBan.Text = "0";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (DGVMatHang.RowCount == 0)
                BindingNavigatorMatHang.Enabled = true;
            DataRow m_Row = m_MatHangCtrl.ThemDongMoi();
            m_Row["MaPhieu"] = "NH" + m_QuyDinh.LaySTT(DGVMatHang.Rows.Count + 1);
            m_Row["MaMH"] = "MH" + m_QuyDinh.LaySTT(DGVMatHang.Rows.Count + 1);
            m_Row["TenMH"] = "";
            m_Row["MaNCC"] = "";
            m_Row["NgayNhap"] = DateTime.Today;
            m_Row["SoLuong"] = 0;
            m_Row["DonGia"] = 0;
            m_Row["GiaBan"] = 0;
            m_Row["MaLoaiGiaoDich"] = "";
            m_Row["MaLoaiTien"] = "";

            m_MatHangCtrl.ThemMoi(m_Row);
            BindingNavigatorMatHang.BindingSource.MoveLast();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenMH.Text != "" && txtDonGia.Text != "" && txtGiaBan.Text != "" && cmbTenNCC.SelectedValue != null && cmbLoaiTienGui.SelectedValue != null && cmbLoaiGiaoDich.SelectedValue !=null && dtNgayNhap.Value != null)
            {
            m_MatHangCtrl.LuuMatHang(txtMaPhieu.Text, txtMaMH.Text, txtTenMH.Text, Convert.ToInt64(txtSoLuong.Text), Convert.ToInt64(txtDonGia.Text), Convert.ToInt64(txtGiaBan.Text), cmbTenNCC.SelectedValue.ToString(), dtNgayNhap.Value, cmbLoaiTienGui.SelectedValue.ToString(), cmbLoaiGiaoDich.SelectedValue.ToString());
            m_MatHangCtrl.HienThi(DGVMatHang, BindingNavigatorMatHang, txtMaPhieu, txtMaMH, txtTenMH, dtNgayNhap, txtSoLuong, txtDonGia, txtGiaBan, txtMaNCC, cmbTenNCC, cmbLoaiGiaoDich, cmbLoaiTienGui);
            MessageBoxEx.Show("Đã lưu thành công!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBoxEx.Show("Phải nhập đầy đủ dữ liệu để thêm mặt hàng", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            m_MatHangCtrl.SuaMatHang(txtMaPhieu.Text, txtMaMH.Text, txtTenMH.Text, Convert.ToInt64(txtSoLuong.Text), Convert.ToInt64(txtDonGia.Text), Convert.ToInt64(txtGiaBan.Text), cmbTenNCC.SelectedValue.ToString(), dtNgayNhap.Value, cmbLoaiTienGui.SelectedValue.ToString(), cmbLoaiGiaoDich.SelectedValue.ToString());
            m_MatHangCtrl.HienThi(DGVMatHang, BindingNavigatorMatHang, txtMaPhieu, txtMaMH, txtTenMH, dtNgayNhap, txtSoLuong, txtDonGia, txtGiaBan, txtMaNCC, cmbTenNCC, cmbLoaiGiaoDich, cmbLoaiTienGui);
            MessageBoxEx.Show("Đã sửa thành công!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("Bạn có chắc chắn xóa mặt hàng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                m_MatHangCtrl.XoaMatHang(txtMaPhieu.Text, txtMaMH.Text);
                m_MatHangCtrl.HienThi(DGVMatHang, BindingNavigatorMatHang,txtMaPhieu, txtMaMH, txtTenMH, dtNgayNhap, txtSoLuong, txtDonGia, txtGiaBan, txtMaNCC, cmbTenNCC, cmbLoaiGiaoDich, cmbLoaiTienGui);
            }
        }
    }
}