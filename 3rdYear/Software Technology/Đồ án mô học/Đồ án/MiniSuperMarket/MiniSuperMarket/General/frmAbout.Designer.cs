namespace MiniSuperMarket.General
{
    partial class frmAbout
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
            this.lblThoat = new DevComponents.DotNetBar.LabelX();
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.SuspendLayout();
            // 
            // lblThoat
            // 
            this.lblThoat.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.lblThoat.BackgroundStyle.Class = "";
            this.lblThoat.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblThoat.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoat.Location = new System.Drawing.Point(650, 330);
            this.lblThoat.Name = "lblThoat";
            this.lblThoat.Size = new System.Drawing.Size(60, 50);
            this.lblThoat.TabIndex = 14;
            this.lblThoat.Text = "Thoát";
            this.lblThoat.Click += new System.EventHandler(this.lblThoat_Click);
            // 
            // reflectionImage1
            // 
            // 
            // 
            // 
            this.reflectionImage1.BackgroundStyle.Class = "";
            this.reflectionImage1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionImage1.Image = global::MiniSuperMarket.Properties.Resources.Shopping_cart_128;
            this.reflectionImage1.Location = new System.Drawing.Point(15, 28);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.Size = new System.Drawing.Size(73, 102);
            this.reflectionImage1.TabIndex = 16;
            // 
            // frmAbout
            // 
            this.BackgroundImage = global::MiniSuperMarket.Properties.Resources.Untitled;
            this.ClientSize = new System.Drawing.Size(750, 404);
            this.Controls.Add(this.reflectionImage1);
            this.Controls.Add(this.lblThoat);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÔNG TIN PHẦN MỀM";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lblThoat;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
    }
}