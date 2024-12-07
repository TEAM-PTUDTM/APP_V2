namespace GUI.Warehouse
{
    partial class FormWarehoues
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWarehoues));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chitietsanphamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSHOPDataSet1 = new GUI.QLSHOPDataSet();
            this.chitietsanphamTableAdapter = new GUI.QLSHOPDataSetTableAdapters.chitietsanphamTableAdapter();
            this.qLSHOPDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSHOPDataSet = new GUI.QLSHOPDataSet();
            this.chitietsanphamBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgv_Product = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhanTramGiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sửa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanphamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgv_DetailProduct = new Guna.UI2.WinForms.Guna2DataGridView();
            this.sanphamTableAdapter = new GUI.QLSHOPDataSetTableAdapters.sanphamTableAdapter();
            this.textBox_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbb_Color = new System.Windows.Forms.ComboBox();
            this.cbb_Size = new System.Windows.Forms.ComboBox();
            this.txt_SLT = new System.Windows.Forms.TextBox();
            this.txt_MaChiTiet = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txt_SLN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_GiaNhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Nhap = new Guna.UI2.WinForms.Guna2Button();
            this.cbb_ncc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_SanPhamNhap = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btn_TaoHoaDonNhap = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chitietsanphamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSHOPDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSHOPDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSHOPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chitietsanphamBindingSource1)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanphamBindingSource)).BeginInit();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DetailProduct)).BeginInit();
            this.guna2GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SanPhamNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // chitietsanphamBindingSource
            // 
            this.chitietsanphamBindingSource.DataMember = "chitietsanpham";
            this.chitietsanphamBindingSource.DataSource = this.qLSHOPDataSet1;
            // 
            // qLSHOPDataSet1
            // 
            this.qLSHOPDataSet1.DataSetName = "QLSHOPDataSet";
            this.qLSHOPDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chitietsanphamTableAdapter
            // 
            this.chitietsanphamTableAdapter.ClearBeforeFill = true;
            // 
            // qLSHOPDataSetBindingSource
            // 
            this.qLSHOPDataSetBindingSource.DataSource = this.qLSHOPDataSet;
            this.qLSHOPDataSetBindingSource.Position = 0;
            // 
            // qLSHOPDataSet
            // 
            this.qLSHOPDataSet.DataSetName = "QLSHOPDataSet";
            this.qLSHOPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chitietsanphamBindingSource1
            // 
            this.chitietsanphamBindingSource1.DataMember = "chitietsanpham";
            this.chitietsanphamBindingSource1.DataSource = this.qLSHOPDataSetBindingSource;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.dgv_Product);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(1105, 74);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(601, 432);
            this.guna2GroupBox1.TabIndex = 78;
            this.guna2GroupBox1.Text = "Quản lý sản phẩm";
            this.guna2GroupBox1.Click += new System.EventHandler(this.guna2GroupBox1_Click);
            // 
            // dgv_Product
            // 
            this.dgv_Product.AllowUserToAddRows = false;
            this.dgv_Product.AllowUserToDeleteRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            this.dgv_Product.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.dgv_Product.AutoGenerateColumns = false;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Product.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgv_Product.ColumnHeadersHeight = 18;
            this.dgv_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.Gia,
            this.PhanTramGiamGia,
            this.MoTa,
            this.MaDanhMuc,
            this.NhaCungCap,
            this.TrinhTrang,
            this.Sửa});
            this.dgv_Product.DataSource = this.sanphamBindingSource;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Product.DefaultCellStyle = dataGridViewCellStyle21;
            this.dgv_Product.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Product.Location = new System.Drawing.Point(17, 54);
            this.dgv_Product.Name = "dgv_Product";
            this.dgv_Product.ReadOnly = true;
            this.dgv_Product.RowHeadersVisible = false;
            this.dgv_Product.RowHeadersWidth = 51;
            this.dgv_Product.RowTemplate.Height = 24;
            this.dgv_Product.Size = new System.Drawing.Size(565, 362);
            this.dgv_Product.TabIndex = 31;
            this.dgv_Product.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Product.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Product.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Product.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Product.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Product.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Product.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Product.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_Product.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Product.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Product.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Product.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Product.ThemeStyle.HeaderStyle.Height = 18;
            this.dgv_Product.ThemeStyle.ReadOnly = true;
            this.dgv_Product.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Product.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Product.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Product.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Product.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_Product.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Product.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Product.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Product_CellContentClick);
            this.dgv_Product.SelectionChanged += new System.EventHandler(this.dgv_Product_SelectionChanged);
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "MaSP";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "TenSP";
            this.TenSP.MinimumWidth = 6;
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Gia";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            this.Gia.ReadOnly = true;
            // 
            // PhanTramGiamGia
            // 
            this.PhanTramGiamGia.DataPropertyName = "PhanTramGiamGia";
            this.PhanTramGiamGia.HeaderText = "PhanTramGiamGia";
            this.PhanTramGiamGia.MinimumWidth = 6;
            this.PhanTramGiamGia.Name = "PhanTramGiamGia";
            this.PhanTramGiamGia.ReadOnly = true;
            // 
            // MoTa
            // 
            this.MoTa.DataPropertyName = "MoTa";
            this.MoTa.HeaderText = "MoTa";
            this.MoTa.MinimumWidth = 6;
            this.MoTa.Name = "MoTa";
            this.MoTa.ReadOnly = true;
            // 
            // MaDanhMuc
            // 
            this.MaDanhMuc.DataPropertyName = "MaDanhMuc";
            this.MaDanhMuc.HeaderText = "MaDanhMuc";
            this.MaDanhMuc.MinimumWidth = 6;
            this.MaDanhMuc.Name = "MaDanhMuc";
            this.MaDanhMuc.ReadOnly = true;
            // 
            // NhaCungCap
            // 
            this.NhaCungCap.DataPropertyName = "MaNhaCungCap";
            this.NhaCungCap.HeaderText = "MaNhaCungCap";
            this.NhaCungCap.MinimumWidth = 6;
            this.NhaCungCap.Name = "NhaCungCap";
            this.NhaCungCap.ReadOnly = true;
            // 
            // TrinhTrang
            // 
            this.TrinhTrang.DataPropertyName = "TrinhTrang";
            this.TrinhTrang.HeaderText = "TrinhTrang";
            this.TrinhTrang.MinimumWidth = 6;
            this.TrinhTrang.Name = "TrinhTrang";
            this.TrinhTrang.ReadOnly = true;
            // 
            // Sửa
            // 
            this.Sửa.DataPropertyName = "MaSP";
            this.Sửa.HeaderText = "icon_edit";
            this.Sửa.MinimumWidth = 6;
            this.Sửa.Name = "Sửa";
            this.Sửa.ReadOnly = true;
            // 
            // sanphamBindingSource
            // 
            this.sanphamBindingSource.DataMember = "sanpham";
            this.sanphamBindingSource.DataSource = this.qLSHOPDataSet;
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Controls.Add(this.btn_Nhap);
            this.guna2GroupBox2.Controls.Add(this.txt_GiaNhap);
            this.guna2GroupBox2.Controls.Add(this.label2);
            this.guna2GroupBox2.Controls.Add(this.txt_SLN);
            this.guna2GroupBox2.Controls.Add(this.label1);
            this.guna2GroupBox2.Controls.Add(this.cbb_Color);
            this.guna2GroupBox2.Controls.Add(this.dgv_DetailProduct);
            this.guna2GroupBox2.Controls.Add(this.cbb_Size);
            this.guna2GroupBox2.Controls.Add(this.label9);
            this.guna2GroupBox2.Controls.Add(this.txt_SLT);
            this.guna2GroupBox2.Controls.Add(this.label10);
            this.guna2GroupBox2.Controls.Add(this.txt_MaChiTiet);
            this.guna2GroupBox2.Controls.Add(this.label11);
            this.guna2GroupBox2.Controls.Add(this.label12);
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox2.Location = new System.Drawing.Point(1105, 512);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(601, 314);
            this.guna2GroupBox2.TabIndex = 79;
            this.guna2GroupBox2.Text = "Chi tiết sản phẩm";
            this.guna2GroupBox2.Click += new System.EventHandler(this.guna2GroupBox2_Click);
            // 
            // dgv_DetailProduct
            // 
            this.dgv_DetailProduct.AllowUserToAddRows = false;
            this.dgv_DetailProduct.AllowUserToDeleteRows = false;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.White;
            this.dgv_DetailProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DetailProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dgv_DetailProduct.ColumnHeadersHeight = 18;
            this.dgv_DetailProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_DetailProduct.DefaultCellStyle = dataGridViewCellStyle24;
            this.dgv_DetailProduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_DetailProduct.Location = new System.Drawing.Point(316, 53);
            this.dgv_DetailProduct.Name = "dgv_DetailProduct";
            this.dgv_DetailProduct.ReadOnly = true;
            this.dgv_DetailProduct.RowHeadersVisible = false;
            this.dgv_DetailProduct.RowHeadersWidth = 51;
            this.dgv_DetailProduct.RowTemplate.Height = 24;
            this.dgv_DetailProduct.Size = new System.Drawing.Size(261, 195);
            this.dgv_DetailProduct.TabIndex = 32;
            this.dgv_DetailProduct.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_DetailProduct.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_DetailProduct.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_DetailProduct.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_DetailProduct.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_DetailProduct.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_DetailProduct.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_DetailProduct.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_DetailProduct.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_DetailProduct.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_DetailProduct.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_DetailProduct.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_DetailProduct.ThemeStyle.HeaderStyle.Height = 18;
            this.dgv_DetailProduct.ThemeStyle.ReadOnly = true;
            this.dgv_DetailProduct.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_DetailProduct.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_DetailProduct.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_DetailProduct.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_DetailProduct.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_DetailProduct.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_DetailProduct.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_DetailProduct.SelectionChanged += new System.EventHandler(this.dgv_DetailProduct_SelectionChanged);
            // 
            // sanphamTableAdapter
            // 
            this.sanphamTableAdapter.ClearBeforeFill = true;
            // 
            // textBox_Search
            // 
            this.textBox_Search.Animated = true;
            this.textBox_Search.AutoRoundedCorners = true;
            this.textBox_Search.BorderColor = System.Drawing.Color.Red;
            this.textBox_Search.BorderRadius = 18;
            this.textBox_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_Search.DefaultText = "";
            this.textBox_Search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_Search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_Search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_Search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox_Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_Search.IconRight = ((System.Drawing.Image)(resources.GetObject("textBox_Search.IconRight")));
            this.textBox_Search.Location = new System.Drawing.Point(1105, 24);
            this.textBox_Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.PasswordChar = '\0';
            this.textBox_Search.PlaceholderText = "";
            this.textBox_Search.SelectedText = "";
            this.textBox_Search.ShadowDecoration.BorderRadius = 30;
            this.textBox_Search.ShadowDecoration.Color = System.Drawing.Color.IndianRed;
            this.textBox_Search.Size = new System.Drawing.Size(372, 39);
            this.textBox_Search.TabIndex = 75;
            this.textBox_Search.TextChanged += new System.EventHandler(this.textBox_Search_TextChanged);
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.AutoRoundedCorners = true;
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderColor = System.Drawing.Color.Red;
            this.guna2ComboBox1.BorderRadius = 17;
            this.guna2ComboBox1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FillColor = System.Drawing.Color.PaleTurquoise;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.DeepPink;
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Items.AddRange(new object[] {
            "category"});
            this.guna2ComboBox1.Location = new System.Drawing.Point(1485, 27);
            this.guna2ComboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(182, 36);
            this.guna2ComboBox1.TabIndex = 76;
            this.guna2ComboBox1.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // cbb_Color
            // 
            this.cbb_Color.Enabled = false;
            this.cbb_Color.FormattingEnabled = true;
            this.cbb_Color.Location = new System.Drawing.Point(128, 86);
            this.cbb_Color.Name = "cbb_Color";
            this.cbb_Color.Size = new System.Drawing.Size(165, 28);
            this.cbb_Color.TabIndex = 80;
            this.cbb_Color.SelectedIndexChanged += new System.EventHandler(this.cbb_Color_SelectedIndexChanged);
            // 
            // cbb_Size
            // 
            this.cbb_Size.Enabled = false;
            this.cbb_Size.FormattingEnabled = true;
            this.cbb_Size.Location = new System.Drawing.Point(128, 116);
            this.cbb_Size.Name = "cbb_Size";
            this.cbb_Size.Size = new System.Drawing.Size(165, 28);
            this.cbb_Size.TabIndex = 81;
            this.cbb_Size.SelectedIndexChanged += new System.EventHandler(this.cbb_Size_SelectedIndexChanged);
            // 
            // txt_SLT
            // 
            this.txt_SLT.Enabled = false;
            this.txt_SLT.Location = new System.Drawing.Point(128, 146);
            this.txt_SLT.Name = "txt_SLT";
            this.txt_SLT.Size = new System.Drawing.Size(165, 27);
            this.txt_SLT.TabIndex = 82;
            this.txt_SLT.TextChanged += new System.EventHandler(this.txt_SLT_TextChanged);
            // 
            // txt_MaChiTiet
            // 
            this.txt_MaChiTiet.Enabled = false;
            this.txt_MaChiTiet.Location = new System.Drawing.Point(128, 53);
            this.txt_MaChiTiet.Name = "txt_MaChiTiet";
            this.txt_MaChiTiet.Size = new System.Drawing.Size(165, 27);
            this.txt_MaChiTiet.TabIndex = 83;
            this.txt_MaChiTiet.TextChanged += new System.EventHandler(this.txt_MaChiTiet_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 20);
            this.label12.TabIndex = 89;
            this.label12.Text = "Sô Lương Tồn";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 20);
            this.label11.TabIndex = 88;
            this.label11.Text = "Size";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 20);
            this.label9.TabIndex = 86;
            this.label9.Text = "Mã Chi tiết";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 20);
            this.label10.TabIndex = 87;
            this.label10.Text = "Màu";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.Controls.Add(this.txt_TongTien);
            this.guna2GroupBox3.Controls.Add(this.label4);
            this.guna2GroupBox3.Controls.Add(this.btn_TaoHoaDonNhap);
            this.guna2GroupBox3.Controls.Add(this.dgv_SanPhamNhap);
            this.guna2GroupBox3.Controls.Add(this.label3);
            this.guna2GroupBox3.Controls.Add(this.cbb_ncc);
            this.guna2GroupBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox3.Location = new System.Drawing.Point(12, 13);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.Size = new System.Drawing.Size(1086, 813);
            this.guna2GroupBox3.TabIndex = 80;
            this.guna2GroupBox3.Text = "guna2GroupBox3";
            // 
            // txt_SLN
            // 
            this.txt_SLN.Location = new System.Drawing.Point(128, 185);
            this.txt_SLN.Name = "txt_SLN";
            this.txt_SLN.Size = new System.Drawing.Size(165, 27);
            this.txt_SLN.TabIndex = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 91;
            this.label1.Text = "Số lượng nhập";
            // 
            // txt_GiaNhap
            // 
            this.txt_GiaNhap.Location = new System.Drawing.Point(128, 221);
            this.txt_GiaNhap.Name = "txt_GiaNhap";
            this.txt_GiaNhap.Size = new System.Drawing.Size(165, 27);
            this.txt_GiaNhap.TabIndex = 92;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 93;
            this.label2.Text = "Giá nhập";
            // 
            // btn_Nhap
            // 
            this.btn_Nhap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Nhap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Nhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Nhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Nhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Nhap.ForeColor = System.Drawing.Color.White;
            this.btn_Nhap.Location = new System.Drawing.Point(20, 254);
            this.btn_Nhap.Name = "btn_Nhap";
            this.btn_Nhap.Size = new System.Drawing.Size(273, 41);
            this.btn_Nhap.TabIndex = 94;
            this.btn_Nhap.Text = "Nhập sản phẩm";
            this.btn_Nhap.Click += new System.EventHandler(this.btn_Nhap_Click);
            // 
            // cbb_ncc
            // 
            this.cbb_ncc.BackColor = System.Drawing.Color.Transparent;
            this.cbb_ncc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_ncc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_ncc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_ncc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_ncc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbb_ncc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbb_ncc.ItemHeight = 30;
            this.cbb_ncc.Location = new System.Drawing.Point(202, 61);
            this.cbb_ncc.Name = "cbb_ncc";
            this.cbb_ncc.Size = new System.Drawing.Size(447, 36);
            this.cbb_ncc.TabIndex = 1;
            this.cbb_ncc.SelectedIndexChanged += new System.EventHandler(this.cbb_ncc_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 87;
            this.label3.Text = "Chọn nhà cung cấp";
            // 
            // dgv_SanPhamNhap
            // 
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.White;
            this.dgv_SanPhamNhap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_SanPhamNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dgv_SanPhamNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_SanPhamNhap.DefaultCellStyle = dataGridViewCellStyle27;
            this.dgv_SanPhamNhap.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_SanPhamNhap.Location = new System.Drawing.Point(32, 129);
            this.dgv_SanPhamNhap.Name = "dgv_SanPhamNhap";
            this.dgv_SanPhamNhap.RowHeadersVisible = false;
            this.dgv_SanPhamNhap.RowHeadersWidth = 51;
            this.dgv_SanPhamNhap.RowTemplate.Height = 24;
            this.dgv_SanPhamNhap.Size = new System.Drawing.Size(1011, 558);
            this.dgv_SanPhamNhap.TabIndex = 88;
            this.dgv_SanPhamNhap.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_SanPhamNhap.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_SanPhamNhap.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_SanPhamNhap.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_SanPhamNhap.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_SanPhamNhap.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_SanPhamNhap.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_SanPhamNhap.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_SanPhamNhap.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_SanPhamNhap.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgv_SanPhamNhap.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_SanPhamNhap.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SanPhamNhap.ThemeStyle.HeaderStyle.Height = 4;
            this.dgv_SanPhamNhap.ThemeStyle.ReadOnly = false;
            this.dgv_SanPhamNhap.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_SanPhamNhap.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_SanPhamNhap.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgv_SanPhamNhap.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.dgv_SanPhamNhap.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_SanPhamNhap.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_SanPhamNhap.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_SanPhamNhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SanPhamNhap_CellContentClick);
            // 
            // btn_TaoHoaDonNhap
            // 
            this.btn_TaoHoaDonNhap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_TaoHoaDonNhap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_TaoHoaDonNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_TaoHoaDonNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_TaoHoaDonNhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_TaoHoaDonNhap.ForeColor = System.Drawing.Color.White;
            this.btn_TaoHoaDonNhap.Location = new System.Drawing.Point(32, 720);
            this.btn_TaoHoaDonNhap.Name = "btn_TaoHoaDonNhap";
            this.btn_TaoHoaDonNhap.Size = new System.Drawing.Size(1011, 45);
            this.btn_TaoHoaDonNhap.TabIndex = 89;
            this.btn_TaoHoaDonNhap.Text = "Tạo hóa đơn nhập";
            this.btn_TaoHoaDonNhap.Click += new System.EventHandler(this.btn_TaoHoaDonNhap_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(686, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 90;
            this.label4.Text = "Tổng tiền:";
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.Enabled = false;
            this.txt_TongTien.Location = new System.Drawing.Point(790, 70);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.Size = new System.Drawing.Size(253, 27);
            this.txt_TongTien.TabIndex = 91;
            this.txt_TongTien.TextChanged += new System.EventHandler(this.txt_TongTien_TextChanged);
            // 
            // FormWarehoues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1746, 838);
            this.Controls.Add(this.guna2GroupBox3);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.guna2ComboBox1);
            this.Name = "FormWarehoues";
            this.Text = "FormWarehoues";
            ((System.ComponentModel.ISupportInitialize)(this.chitietsanphamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSHOPDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSHOPDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSHOPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chitietsanphamBindingSource1)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanphamBindingSource)).EndInit();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DetailProduct)).EndInit();
            this.guna2GroupBox3.ResumeLayout(false);
            this.guna2GroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SanPhamNhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource chitietsanphamBindingSource;
        private QLSHOPDataSet qLSHOPDataSet1;
        private QLSHOPDataSetTableAdapters.chitietsanphamTableAdapter chitietsanphamTableAdapter;
        private System.Windows.Forms.BindingSource qLSHOPDataSetBindingSource;
        private QLSHOPDataSet qLSHOPDataSet;
        private System.Windows.Forms.BindingSource chitietsanphamBindingSource1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhanTramGiamGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sửa;
        private System.Windows.Forms.BindingSource sanphamBindingSource;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_DetailProduct;
        private QLSHOPDataSetTableAdapters.sanphamTableAdapter sanphamTableAdapter;
        private Guna.UI2.WinForms.Guna2TextBox textBox_Search;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private System.Windows.Forms.ComboBox cbb_Color;
        private System.Windows.Forms.ComboBox cbb_Size;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_SLT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_MaChiTiet;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private System.Windows.Forms.TextBox txt_SLN;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_Nhap;
        private System.Windows.Forms.TextBox txt_GiaNhap;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_ncc;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_SanPhamNhap;
        private Guna.UI2.WinForms.Guna2Button btn_TaoHoaDonNhap;
        private System.Windows.Forms.TextBox txt_TongTien;
        private System.Windows.Forms.Label label4;
    }
}