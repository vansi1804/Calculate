namespace QuanLyBanHang
{
    partial class frmDatHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatHang));
            this.DGVDatHang = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colMaPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenMH = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colTenKH = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colNgayDat = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhToan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colLoaiTien = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colLoaiGD = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BindingNavigatorDatHang = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.bindingNavigatorRefreshItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCloseItem = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtMaPhieu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtThanhTien = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbThanhToan = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.btnThemMH = new DevComponents.DotNetBar.ButtonX();
            this.txtGhiChu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cmbTenMH = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnDel = new DevComponents.DotNetBar.ButtonX();
            this.btnSua = new DevComponents.DotNetBar.ButtonX();
            this.btnLuu = new DevComponents.DotNetBar.ButtonX();
            this.btnNhapLai = new DevComponents.DotNetBar.ButtonX();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.btnHuy = new DevComponents.DotNetBar.ButtonX();
            this.dtNgayDat = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.cmbLoaiTienGui = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.cmbLoaiGiaoDich = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtGiaBan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSoLuong = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.cmbTenKH = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnThemKH = new DevComponents.DotNetBar.ButtonX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigatorDatHang)).BeginInit();
            this.BindingNavigatorDatHang.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayDat)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVDatHang
            // 
            this.DGVDatHang.AllowUserToAddRows = false;
            this.DGVDatHang.AllowUserToResizeRows = false;
            this.DGVDatHang.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.DGVDatHang.ColumnHeadersHeight = 34;
            this.DGVDatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVDatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaPhieu,
            this.colTenMH,
            this.colTenKH,
            this.colNgayDat,
            this.colSoLuong,
            this.colGiaBan,
            this.colThanhTien,
            this.colThanhToan,
            this.colLoaiTien,
            this.colLoaiGD,
            this.colGhiChu});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVDatHang.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVDatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVDatHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DGVDatHang.Location = new System.Drawing.Point(0, 301);
            this.DGVDatHang.Name = "DGVDatHang";
            this.DGVDatHang.RowHeadersWidth = 62;
            this.DGVDatHang.Size = new System.Drawing.Size(1247, 413);
            this.DGVDatHang.TabIndex = 15;
            // 
            // colMaPhieu
            // 
            this.colMaPhieu.DataPropertyName = "MaPhieu";
            this.colMaPhieu.HeaderText = "Mã Phiếu";
            this.colMaPhieu.MinimumWidth = 8;
            this.colMaPhieu.Name = "colMaPhieu";
            this.colMaPhieu.Width = 70;
            // 
            // colTenMH
            // 
            this.colTenMH.DataPropertyName = "TenMH";
            this.colTenMH.HeaderText = "Tên mặt hàng";
            this.colTenMH.MinimumWidth = 8;
            this.colTenMH.Name = "colTenMH";
            this.colTenMH.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colTenMH.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colTenMH.Width = 150;
            // 
            // colTenKH
            // 
            this.colTenKH.DataPropertyName = "TenKH";
            this.colTenKH.HeaderText = "Tên khách hàng";
            this.colTenKH.MinimumWidth = 8;
            this.colTenKH.Name = "colTenKH";
            this.colTenKH.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTenKH.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colTenKH.Width = 150;
            // 
            // colNgayDat
            // 
            // 
            // 
            // 
            this.colNgayDat.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.colNgayDat.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colNgayDat.DataPropertyName = "NgayDat";
            dataGridViewCellStyle1.Format = "dd/mm/yy";
            this.colNgayDat.DefaultCellStyle = dataGridViewCellStyle1;
            this.colNgayDat.HeaderText = "Ngày đặt hàng";
            this.colNgayDat.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center;
            this.colNgayDat.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.colNgayDat.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.colNgayDat.MinimumWidth = 8;
            // 
            // 
            // 
            this.colNgayDat.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.colNgayDat.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.colNgayDat.MonthCalendar.BackgroundStyle.Class = "";
            this.colNgayDat.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.colNgayDat.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.colNgayDat.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colNgayDat.MonthCalendar.DisplayMonth = new System.DateTime(2011, 11, 1, 0, 0, 0, 0);
            this.colNgayDat.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.colNgayDat.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.colNgayDat.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.colNgayDat.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colNgayDat.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.colNgayDat.Name = "colNgayDat";
            this.colNgayDat.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colNgayDat.Width = 150;
            // 
            // colSoLuong
            // 
            this.colSoLuong.DataPropertyName = "SoLuong";
            this.colSoLuong.HeaderText = "Số Lượng";
            this.colSoLuong.MinimumWidth = 8;
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Width = 80;
            // 
            // colGiaBan
            // 
            this.colGiaBan.DataPropertyName = "GiaBan";
            this.colGiaBan.HeaderText = "Giá bán";
            this.colGiaBan.MinimumWidth = 8;
            this.colGiaBan.Name = "colGiaBan";
            this.colGiaBan.Width = 150;
            // 
            // colThanhTien
            // 
            this.colThanhTien.DataPropertyName = "ThanhTien";
            this.colThanhTien.HeaderText = "Thành Tiền";
            this.colThanhTien.MinimumWidth = 8;
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.Width = 150;
            // 
            // colThanhToan
            // 
            this.colThanhToan.DataPropertyName = "ThanhToan";
            this.colThanhToan.HeaderText = "Thanh Toán";
            this.colThanhToan.MinimumWidth = 8;
            this.colThanhToan.Name = "colThanhToan";
            this.colThanhToan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colThanhToan.Width = 80;
            // 
            // colLoaiTien
            // 
            this.colLoaiTien.DataPropertyName = "MaLoaiTien";
            this.colLoaiTien.HeaderText = "Loại tiền";
            this.colLoaiTien.MinimumWidth = 8;
            this.colLoaiTien.Name = "colLoaiTien";
            this.colLoaiTien.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colLoaiTien.Width = 70;
            // 
            // colLoaiGD
            // 
            this.colLoaiGD.DataPropertyName = "MaLoaiGiaoDich";
            this.colLoaiGD.HeaderText = "Loại giao dịch";
            this.colLoaiGD.MinimumWidth = 8;
            this.colLoaiGD.Name = "colLoaiGD";
            this.colLoaiGD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colLoaiGD.Width = 150;
            // 
            // colGhiChu
            // 
            this.colGhiChu.DataPropertyName = "GhiChu";
            this.colGhiChu.HeaderText = "Ghi Chú";
            this.colGhiChu.MinimumWidth = 8;
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Width = 150;
            // 
            // BindingNavigatorDatHang
            // 
            this.BindingNavigatorDatHang.AddNewItem = null;
            this.BindingNavigatorDatHang.AutoSize = false;
            this.BindingNavigatorDatHang.CountItem = this.bindingNavigatorCountItem;
            this.BindingNavigatorDatHang.DeleteItem = null;
            this.BindingNavigatorDatHang.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.BindingNavigatorDatHang.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorRefreshItem,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorSaveItem,
            this.bindingNavigatorCloseItem});
            this.BindingNavigatorDatHang.Location = new System.Drawing.Point(0, 261);
            this.BindingNavigatorDatHang.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.BindingNavigatorDatHang.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.BindingNavigatorDatHang.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.BindingNavigatorDatHang.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.BindingNavigatorDatHang.Name = "BindingNavigatorDatHang";
            this.BindingNavigatorDatHang.PositionItem = this.bindingNavigatorPositionItem;
            this.BindingNavigatorDatHang.Size = new System.Drawing.Size(1247, 40);
            this.BindingNavigatorDatHang.TabIndex = 14;
            this.BindingNavigatorDatHang.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 35);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 35);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 35);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 40);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 35);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 35);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = global::QuanLyBanHang.Properties.Resources.Add;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(60, 35);
            this.bindingNavigatorAddNewItem.Text = "Thêm";
            this.bindingNavigatorAddNewItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorRefreshItem
            // 
            this.bindingNavigatorRefreshItem.Image = global::QuanLyBanHang.Properties.Resources.Refresh;
            this.bindingNavigatorRefreshItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorRefreshItem.Name = "bindingNavigatorRefreshItem";
            this.bindingNavigatorRefreshItem.Size = new System.Drawing.Size(86, 35);
            this.bindingNavigatorRefreshItem.Text = "Làm tươi";
            this.bindingNavigatorRefreshItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorRefreshItem.Click += new System.EventHandler(this.bindingNavigatorRefreshItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(47, 35);
            this.bindingNavigatorDeleteItem.Text = "Xóa";
            this.bindingNavigatorDeleteItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorSaveItem
            // 
            this.bindingNavigatorSaveItem.Image = global::QuanLyBanHang.Properties.Resources.save;
            this.bindingNavigatorSaveItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorSaveItem.Name = "bindingNavigatorSaveItem";
            this.bindingNavigatorSaveItem.Size = new System.Drawing.Size(45, 35);
            this.bindingNavigatorSaveItem.Text = "Lưu";
            this.bindingNavigatorSaveItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorSaveItem.Click += new System.EventHandler(this.bindingNavigatorSaveItem_Click);
            // 
            // bindingNavigatorCloseItem
            // 
            this.bindingNavigatorCloseItem.Image = global::QuanLyBanHang.Properties.Resources.Exit;
            this.bindingNavigatorCloseItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorCloseItem.Name = "bindingNavigatorCloseItem";
            this.bindingNavigatorCloseItem.Size = new System.Drawing.Size(61, 35);
            this.bindingNavigatorCloseItem.Text = "Thoát";
            this.bindingNavigatorCloseItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorCloseItem.Click += new System.EventHandler(this.bindingNavigatorCloseItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1247, 261);
            this.panel2.TabIndex = 13;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.txtMaPhieu);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.txtThanhTien);
            this.groupPanel1.Controls.Add(this.cbThanhToan);
            this.groupPanel1.Controls.Add(this.btnThemMH);
            this.groupPanel1.Controls.Add(this.txtGhiChu);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.cmbTenMH);
            this.groupPanel1.Controls.Add(this.btnDel);
            this.groupPanel1.Controls.Add(this.btnSua);
            this.groupPanel1.Controls.Add(this.btnLuu);
            this.groupPanel1.Controls.Add(this.btnNhapLai);
            this.groupPanel1.Controls.Add(this.btnThem);
            this.groupPanel1.Controls.Add(this.btnHuy);
            this.groupPanel1.Controls.Add(this.dtNgayDat);
            this.groupPanel1.Controls.Add(this.labelX12);
            this.groupPanel1.Controls.Add(this.labelX8);
            this.groupPanel1.Controls.Add(this.cmbLoaiTienGui);
            this.groupPanel1.Controls.Add(this.labelX7);
            this.groupPanel1.Controls.Add(this.labelX11);
            this.groupPanel1.Controls.Add(this.cmbLoaiGiaoDich);
            this.groupPanel1.Controls.Add(this.txtGiaBan);
            this.groupPanel1.Controls.Add(this.txtSoLuong);
            this.groupPanel1.Controls.Add(this.labelX6);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.cmbTenKH);
            this.groupPanel1.Controls.Add(this.btnThemKH);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Location = new System.Drawing.Point(3, 10);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1238, 248);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.Class = "";
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.Class = "";
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.Class = "";
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 2;
            this.groupPanel1.Text = "Khung nhập liệu";
            // 
            // txtMaPhieu
            // 
            // 
            // 
            // 
            this.txtMaPhieu.Border.Class = "TextBoxBorder";
            this.txtMaPhieu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaPhieu.Location = new System.Drawing.Point(135, 10);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.ReadOnly = true;
            this.txtMaPhieu.Size = new System.Drawing.Size(85, 36);
            this.txtMaPhieu.TabIndex = 89;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(15, 10);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(61, 20);
            this.labelX2.TabIndex = 88;
            this.labelX2.Text = "Mã Phiếu:";
            // 
            // txtThanhTien
            // 
            // 
            // 
            // 
            this.txtThanhTien.Border.Class = "TextBoxBorder";
            this.txtThanhTien.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtThanhTien.Location = new System.Drawing.Point(135, 152);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(329, 36);
            this.txtThanhTien.TabIndex = 87;
            // 
            // cbThanhToan
            // 
            this.cbThanhToan.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.cbThanhToan.BackgroundStyle.Class = "";
            this.cbThanhToan.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbThanhToan.Location = new System.Drawing.Point(692, 78);
            this.cbThanhToan.Name = "cbThanhToan";
            this.cbThanhToan.Size = new System.Drawing.Size(80, 23);
            this.cbThanhToan.TabIndex = 86;
            this.cbThanhToan.Text = "Thanh Toán";
            // 
            // btnThemMH
            // 
            this.btnThemMH.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemMH.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemMH.Image = global::QuanLyBanHang.Properties.Resources.Add;
            this.btnThemMH.Location = new System.Drawing.Point(438, 44);
            this.btnThemMH.Name = "btnThemMH";
            this.btnThemMH.Size = new System.Drawing.Size(26, 20);
            this.btnThemMH.TabIndex = 85;
            this.btnThemMH.Tooltip = "Thêm nhà cung cấp";
            this.btnThemMH.Click += new System.EventHandler(this.btnThemMH_Click);
            // 
            // txtGhiChu
            // 
            // 
            // 
            // 
            this.txtGhiChu.Border.Class = "TextBoxBorder";
            this.txtGhiChu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtGhiChu.Location = new System.Drawing.Point(756, 150);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(290, 36);
            this.txtGhiChu.TabIndex = 84;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(694, 150);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(56, 20);
            this.labelX1.TabIndex = 83;
            this.labelX1.Text = "Ghi Chú:";
            // 
            // cmbTenMH
            // 
            this.cmbTenMH.DisplayMember = "Text";
            this.cmbTenMH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTenMH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTenMH.FormattingEnabled = true;
            this.cmbTenMH.ItemHeight = 14;
            this.cmbTenMH.Location = new System.Drawing.Point(135, 45);
            this.cmbTenMH.Name = "cmbTenMH";
            this.cmbTenMH.Size = new System.Drawing.Size(297, 20);
            this.cmbTenMH.TabIndex = 82;
            // 
            // btnDel
            // 
            this.btnDel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Image = global::QuanLyBanHang.Properties.Resources.Delete;
            this.btnDel.Location = new System.Drawing.Point(832, 185);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(77, 28);
            this.btnDel.TabIndex = 81;
            this.btnDel.Text = "Xóa";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSua
            // 
            this.btnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = global::QuanLyBanHang.Properties.Resources.NhapLai;
            this.btnSua.Location = new System.Drawing.Point(651, 185);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(77, 28);
            this.btnSua.TabIndex = 80;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = global::QuanLyBanHang.Properties.Resources.save;
            this.btnLuu.Location = new System.Drawing.Point(472, 185);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(72, 28);
            this.btnLuu.TabIndex = 79;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNhapLai.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNhapLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapLai.Image = global::QuanLyBanHang.Properties.Resources.NhapLai;
            this.btnNhapLai.Location = new System.Drawing.Point(276, 185);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(77, 28);
            this.btnNhapLai.TabIndex = 77;
            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::QuanLyBanHang.Properties.Resources.Add;
            this.btnThem.Location = new System.Drawing.Point(93, 185);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(72, 28);
            this.btnThem.TabIndex = 76;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = global::QuanLyBanHang.Properties.Resources.Exit;
            this.btnHuy.Location = new System.Drawing.Point(1022, 185);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(82, 28);
            this.btnHuy.TabIndex = 78;
            this.btnHuy.Text = "Thoát";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // dtNgayDat
            // 
            // 
            // 
            // 
            this.dtNgayDat.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtNgayDat.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtNgayDat.ButtonDropDown.Visible = true;
            this.dtNgayDat.CustomFormat = "dd/MM/yyyy";
            this.dtNgayDat.IsPopupCalendarOpen = false;
            this.dtNgayDat.Location = new System.Drawing.Point(793, 43);
            // 
            // 
            // 
            this.dtNgayDat.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtNgayDat.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtNgayDat.MonthCalendar.BackgroundStyle.Class = "";
            this.dtNgayDat.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtNgayDat.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtNgayDat.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtNgayDat.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtNgayDat.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtNgayDat.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtNgayDat.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtNgayDat.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtNgayDat.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtNgayDat.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtNgayDat.MonthCalendar.DisplayMonth = new System.DateTime(2007, 3, 1, 0, 0, 0, 0);
            this.dtNgayDat.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtNgayDat.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtNgayDat.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtNgayDat.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtNgayDat.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtNgayDat.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtNgayDat.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtNgayDat.MonthCalendar.TodayButtonVisible = true;
            this.dtNgayDat.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtNgayDat.Name = "dtNgayDat";
            this.dtNgayDat.Size = new System.Drawing.Size(253, 26);
            this.dtNgayDat.TabIndex = 7;
            // 
            // labelX12
            // 
            this.labelX12.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.Class = "";
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.Location = new System.Drawing.Point(694, 46);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(79, 19);
            this.labelX12.TabIndex = 0;
            this.labelX12.Text = "Ngày Đặt Hàng:";
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.Class = "";
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(15, 151);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(93, 20);
            this.labelX8.TabIndex = 0;
            this.labelX8.Text = "Thành Tiền:";
            // 
            // cmbLoaiTienGui
            // 
            this.cmbLoaiTienGui.DisplayMember = "Text";
            this.cmbLoaiTienGui.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLoaiTienGui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLoaiTienGui.FormattingEnabled = true;
            this.cmbLoaiTienGui.ItemHeight = 14;
            this.cmbLoaiTienGui.Location = new System.Drawing.Point(865, 76);
            this.cmbLoaiTienGui.Name = "cmbLoaiTienGui";
            this.cmbLoaiTienGui.Size = new System.Drawing.Size(181, 20);
            this.cmbLoaiTienGui.TabIndex = 8;
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.Class = "";
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(800, 81);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(56, 20);
            this.labelX7.TabIndex = 0;
            this.labelX7.Text = "Loại Tiền:";
            // 
            // labelX11
            // 
            this.labelX11.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.Class = "";
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Location = new System.Drawing.Point(694, 115);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(80, 20);
            this.labelX11.TabIndex = 0;
            this.labelX11.Text = "Loại Giao Dịch:";
            // 
            // cmbLoaiGiaoDich
            // 
            this.cmbLoaiGiaoDich.DisplayMember = "Text";
            this.cmbLoaiGiaoDich.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLoaiGiaoDich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLoaiGiaoDich.FormattingEnabled = true;
            this.cmbLoaiGiaoDich.ItemHeight = 14;
            this.cmbLoaiGiaoDich.Location = new System.Drawing.Point(793, 115);
            this.cmbLoaiGiaoDich.Name = "cmbLoaiGiaoDich";
            this.cmbLoaiGiaoDich.Size = new System.Drawing.Size(253, 20);
            this.cmbLoaiGiaoDich.TabIndex = 9;
            // 
            // txtGiaBan
            // 
            // 
            // 
            // 
            this.txtGiaBan.Border.Class = "TextBoxBorder";
            this.txtGiaBan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtGiaBan.Location = new System.Drawing.Point(276, 111);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(188, 36);
            this.txtGiaBan.TabIndex = 4;
            // 
            // txtSoLuong
            // 
            // 
            // 
            // 
            this.txtSoLuong.Border.Class = "TextBoxBorder";
            this.txtSoLuong.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSoLuong.Location = new System.Drawing.Point(135, 115);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(85, 36);
            this.txtSoLuong.TabIndex = 3;
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(225, 111);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(48, 20);
            this.labelX6.TabIndex = 0;
            this.labelX6.Text = "Giá Bán:";
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(15, 115);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(61, 20);
            this.labelX5.TabIndex = 0;
            this.labelX5.Text = "Số Lượng:";
            // 
            // cmbTenKH
            // 
            this.cmbTenKH.DisplayMember = "Text";
            this.cmbTenKH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTenKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTenKH.FormattingEnabled = true;
            this.cmbTenKH.ItemHeight = 14;
            this.cmbTenKH.Location = new System.Drawing.Point(135, 80);
            this.cmbTenKH.Name = "cmbTenKH";
            this.cmbTenKH.Size = new System.Drawing.Size(297, 20);
            this.cmbTenKH.TabIndex = 6;
            // 
            // btnThemKH
            // 
            this.btnThemKH.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemKH.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemKH.Image = global::QuanLyBanHang.Properties.Resources.Add;
            this.btnThemKH.Location = new System.Drawing.Point(438, 79);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(26, 20);
            this.btnThemKH.TabIndex = 60;
            this.btnThemKH.Tooltip = "Thêm nhà cung cấp";
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(15, 80);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(105, 20);
            this.labelX4.TabIndex = 0;
            this.labelX4.Text = "Tên Khách Hàng:";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(15, 45);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(82, 23);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "Tên Mặt Hàng:";
            // 
            // frmDatHang
            // 
            this.ClientSize = new System.Drawing.Size(1247, 714);
            this.Controls.Add(this.DGVDatHang);
            this.Controls.Add(this.BindingNavigatorDatHang);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmDatHang";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐẶT HÀNG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigatorDatHang)).EndInit();
            this.BindingNavigatorDatHang.ResumeLayout(false);
            this.BindingNavigatorDatHang.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayDat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX DGVDatHang;
        private System.Windows.Forms.BindingNavigator BindingNavigatorDatHang;
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
        private System.Windows.Forms.ToolStripButton bindingNavigatorRefreshItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorCloseItem;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbTenMH;
        private DevComponents.DotNetBar.ButtonX btnDel;
        private DevComponents.DotNetBar.ButtonX btnSua;
        private DevComponents.DotNetBar.ButtonX btnLuu;
        private DevComponents.DotNetBar.ButtonX btnNhapLai;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private DevComponents.DotNetBar.ButtonX btnHuy;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtNgayDat;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbLoaiTienGui;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbLoaiGiaoDich;
        private DevComponents.DotNetBar.Controls.TextBoxX txtGiaBan;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSoLuong;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbTenKH;
        private DevComponents.DotNetBar.ButtonX btnThemKH;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.ButtonX btnThemMH;
        private DevComponents.DotNetBar.Controls.TextBoxX txtGhiChu;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbThanhToan;
        private DevComponents.DotNetBar.Controls.TextBoxX txtThanhTien;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaPhieu;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhieu;
        private System.Windows.Forms.DataGridViewComboBoxColumn colTenMH;
        private System.Windows.Forms.DataGridViewComboBoxColumn colTenKH;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn colNgayDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colThanhToan;
        private System.Windows.Forms.DataGridViewComboBoxColumn colLoaiTien;
        private System.Windows.Forms.DataGridViewComboBoxColumn colLoaiGD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChu;
    }
}