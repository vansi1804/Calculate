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
    public partial class frmQuayGiaoDich : Office2007Form
    {
        QuayGiaoDichCtrl m_QuayGiaoDichCtrl = new QuayGiaoDichCtrl();

        public frmQuayGiaoDich()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmQuayGiaoDich_Load(object sender, EventArgs e)
        {
            m_QuayGiaoDichCtrl.HienThi(DGVQuayGiaoDich, BindingNavigatorQuayGiaoDich);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

            if (DGVQuayGiaoDich.RowCount == 0)
                BindingNavigatorQuayGiaoDich.Enabled = true;
            DataRow m_Row = m_QuayGiaoDichCtrl.ThemDongMoi();
            m_Row["MaQuayGiaoDich"] = "";
            m_Row["TenQuayGiaoDich"] = "";
            m_QuayGiaoDichCtrl.ThemMoi(m_Row);
            BindingNavigatorQuayGiaoDich.BindingSource.MoveLast();
        }
        public Boolean KiemTraTruocKhiLuu(String str)
        {
            foreach (DataGridViewRow row in DGVQuayGiaoDich.Rows)
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
                    bindingNavigatorPositionItem.Focus();
                m_QuayGiaoDichCtrl.LuuQuayGiaoDich();
                MessageBoxEx.Show("Đã lưu thành công!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBoxEx.Show("Giá trị ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (DGVQuayGiaoDich.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else
                if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BindingNavigatorQuayGiaoDich.BindingSource.RemoveCurrent();
                }
        }

        private void bindingNavigatorCloseItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

    }
}