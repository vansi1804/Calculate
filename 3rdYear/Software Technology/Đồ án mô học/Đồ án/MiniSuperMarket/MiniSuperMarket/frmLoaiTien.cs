using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using MiniSuperMarket.General;
using MiniSuperMarket.Bussiness;
using MiniSuperMarket.Controller;

namespace MiniSuperMarket
{
    public partial class frmLoaiTien : Office2007Form
    {
        LoaiTienCtrl m_LoaiTienCtrl = new LoaiTienCtrl();
        QuyDinh m_QuyDinh = new QuyDinh();
        public frmLoaiTien()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmLoaiTien_Load(object sender, EventArgs e)
        {
            m_LoaiTienCtrl.HienThi(DGVDMLoaiTien, BindingNavigatorDMLoaiTien);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (DGVDMLoaiTien.RowCount == 0)
                BindingNavigatorDMLoaiTien.Enabled = true;
            DataRow m_Row = m_LoaiTienCtrl.ThemDongMoi();
            m_Row["MaLoaiTien"] = "";
            m_Row["LoaiTien"] = "";
            m_LoaiTienCtrl.ThemMoi(m_Row);
            BindingNavigatorDMLoaiTien.BindingSource.MoveLast();
        }
        public Boolean KiemTraTruocKhiLuu(String str)
        {
            foreach (DataGridViewRow row in DGVDMLoaiTien.Rows)
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
            if (KiemTraTruocKhiLuu("colMaLoaiTien") == true &&
               KiemTraTruocKhiLuu("colLoaiTien") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_LoaiTienCtrl.LuuLoaiTien();
                MessageBoxEx.Show("Đã lưu thành công!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBoxEx.Show("Giá trị của ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (DGVDMLoaiTien.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else
                if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BindingNavigatorDMLoaiTien.BindingSource.RemoveCurrent();
                }
        }

        private void bindingNavigatorCloseItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}