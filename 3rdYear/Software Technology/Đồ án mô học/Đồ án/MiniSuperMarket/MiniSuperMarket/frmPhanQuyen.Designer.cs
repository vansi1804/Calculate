namespace MiniSuperMarket
{
    partial class frmPhanQuyen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhanQuyen));
            this.DGVDPhanQuyen = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colMaNV = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colMaQuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNhomNguoiDung = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colMatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BindingNavigatorPhanQuyen = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCloseItem = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDPhanQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigatorPhanQuyen)).BeginInit();
            this.BindingNavigatorPhanQuyen.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVDPhanQuyen
            // 
            this.DGVDPhanQuyen.AllowUserToAddRows = false;
            this.DGVDPhanQuyen.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.DGVDPhanQuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDPhanQuyen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNV,
            this.colMaQuyen,
            this.colTenDangNhap,
            this.colMaNhomNguoiDung,
            this.colMatKhau});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVDPhanQuyen.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVDPhanQuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVDPhanQuyen.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DGVDPhanQuyen.Location = new System.Drawing.Point(0, 38);
            this.DGVDPhanQuyen.Name = "DGVDPhanQuyen";
            this.DGVDPhanQuyen.Size = new System.Drawing.Size(717, 286);
            this.DGVDPhanQuyen.TabIndex = 4;
            // 
            // colMaNV
            // 
            this.colMaNV.DataPropertyName = "MaNV";
            this.colMaNV.HeaderText = "Tên nhân viên";
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.Width = 150;
            // 
            // colMaQuyen
            // 
            this.colMaQuyen.DataPropertyName = "MaQuyen";
            this.colMaQuyen.HeaderText = "Mã quyền";
            this.colMaQuyen.Name = "colMaQuyen";
            this.colMaQuyen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colTenDangNhap
            // 
            this.colTenDangNhap.DataPropertyName = "TenDangNhap";
            this.colTenDangNhap.HeaderText = "Tên đăng nhập";
            this.colTenDangNhap.Name = "colTenDangNhap";
            this.colTenDangNhap.Width = 130;
            // 
            // colMaNhomNguoiDung
            // 
            this.colMaNhomNguoiDung.DataPropertyName = "MaNhomNguoiDung";
            this.colMaNhomNguoiDung.HeaderText = "Tên nhóm người dùng";
            this.colMaNhomNguoiDung.Name = "colMaNhomNguoiDung";
            this.colMaNhomNguoiDung.Width = 150;
            // 
            // colMatKhau
            // 
            this.colMatKhau.DataPropertyName = "MatKhau";
            this.colMatKhau.HeaderText = "Mật khẩu";
            this.colMatKhau.Name = "colMatKhau";
            // 
            // BindingNavigatorPhanQuyen
            // 
            this.BindingNavigatorPhanQuyen.AddNewItem = null;
            this.BindingNavigatorPhanQuyen.AutoSize = false;
            this.BindingNavigatorPhanQuyen.CountItem = this.bindingNavigatorCountItem;
            this.BindingNavigatorPhanQuyen.DeleteItem = null;
            this.BindingNavigatorPhanQuyen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorSaveItem,
            this.bindingNavigatorCloseItem});
            this.BindingNavigatorPhanQuyen.Location = new System.Drawing.Point(0, 0);
            this.BindingNavigatorPhanQuyen.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.BindingNavigatorPhanQuyen.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.BindingNavigatorPhanQuyen.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.BindingNavigatorPhanQuyen.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.BindingNavigatorPhanQuyen.Name = "BindingNavigatorPhanQuyen";
            this.BindingNavigatorPhanQuyen.PositionItem = this.bindingNavigatorPositionItem;
            this.BindingNavigatorPhanQuyen.Size = new System.Drawing.Size(717, 38);
            this.BindingNavigatorPhanQuyen.TabIndex = 3;
            this.BindingNavigatorPhanQuyen.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 35);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 35);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 35);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 35);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 35);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = global::MiniSuperMarket.Properties.Resources.Add;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(42, 35);
            this.bindingNavigatorAddNewItem.Text = "Thêm";
            this.bindingNavigatorAddNewItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(31, 35);
            this.bindingNavigatorDeleteItem.Text = "Xóa";
            this.bindingNavigatorDeleteItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorSaveItem
            // 
            this.bindingNavigatorSaveItem.Image = global::MiniSuperMarket.Properties.Resources.save;
            this.bindingNavigatorSaveItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorSaveItem.Name = "bindingNavigatorSaveItem";
            this.bindingNavigatorSaveItem.Size = new System.Drawing.Size(31, 35);
            this.bindingNavigatorSaveItem.Text = "Luu";
            this.bindingNavigatorSaveItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorSaveItem.Click += new System.EventHandler(this.bindingNavigatorSaveItem_Click);
            // 
            // bindingNavigatorCloseItem
            // 
            this.bindingNavigatorCloseItem.Image = global::MiniSuperMarket.Properties.Resources.Exit;
            this.bindingNavigatorCloseItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorCloseItem.Name = "bindingNavigatorCloseItem";
            this.bindingNavigatorCloseItem.Size = new System.Drawing.Size(42, 35);
            this.bindingNavigatorCloseItem.Text = "Thoat";
            this.bindingNavigatorCloseItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorCloseItem.Click += new System.EventHandler(this.bindingNavigatorCloseItem_Click);
            // 
            // frmPhanQuyen
            // 
            this.ClientSize = new System.Drawing.Size(717, 324);
            this.Controls.Add(this.DGVDPhanQuyen);
            this.Controls.Add(this.BindingNavigatorPhanQuyen);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPhanQuyen";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHÂN QUYỀN NGƯỜI DÙNG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPhanQuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDPhanQuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigatorPhanQuyen)).EndInit();
            this.BindingNavigatorPhanQuyen.ResumeLayout(false);
            this.BindingNavigatorPhanQuyen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX DGVDPhanQuyen;
        private System.Windows.Forms.BindingNavigator BindingNavigatorPhanQuyen;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorCloseItem;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaQuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDangNhap;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaNhomNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMatKhau;
    }
}