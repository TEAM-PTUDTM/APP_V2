namespace GUI.Invoice_GUI
{
    partial class Form_Invoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Invoice));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.textBox_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_UpdateInvoice = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DateTimePicker_From = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2DateTimePicker_To = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btn_FilterByDate = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ResetFilter = new Guna.UI2.WinForms.Guna2Button();
            this.dgv_invoice = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btn_ExportToExcel = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrderID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Phone = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_PriceShipp = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_AmoutPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Voucher = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_address = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbb_Payment = new System.Windows.Forms.ComboBox();
            this.cbb_order = new System.Windows.Forms.ComboBox();
            this.dgv_InvoiceDetail = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_InvoiceDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderColor = System.Drawing.Color.Red;
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
            this.guna2ComboBox1.Location = new System.Drawing.Point(415, 26);
            this.guna2ComboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(210, 36);
            this.guna2ComboBox1.TabIndex = 28;
            this.guna2ComboBox1.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // textBox_Search
            // 
            this.textBox_Search.Animated = true;
            this.textBox_Search.BorderColor = System.Drawing.Color.Red;
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
            this.textBox_Search.Location = new System.Drawing.Point(30, 26);
            this.textBox_Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.PasswordChar = '\0';
            this.textBox_Search.PlaceholderText = "";
            this.textBox_Search.SelectedText = "";
            this.textBox_Search.ShadowDecoration.BorderRadius = 30;
            this.textBox_Search.ShadowDecoration.Color = System.Drawing.Color.IndianRed;
            this.textBox_Search.Size = new System.Drawing.Size(377, 48);
            this.textBox_Search.TabIndex = 27;
            this.textBox_Search.TextChanged += new System.EventHandler(this.textBox_Search_TextChanged);
            // 
            // btn_UpdateInvoice
            // 
            this.btn_UpdateInvoice.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_UpdateInvoice.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_UpdateInvoice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_UpdateInvoice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_UpdateInvoice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_UpdateInvoice.ForeColor = System.Drawing.Color.White;
            this.btn_UpdateInvoice.Location = new System.Drawing.Point(1087, 571);
            this.btn_UpdateInvoice.Name = "btn_UpdateInvoice";
            this.btn_UpdateInvoice.Size = new System.Drawing.Size(163, 144);
            this.btn_UpdateInvoice.TabIndex = 29;
            this.btn_UpdateInvoice.Text = "Cập nhật hóa đơn";
            this.btn_UpdateInvoice.Click += new System.EventHandler(this.btn_UpdateInvoice_Click);
            // 
            // guna2DateTimePicker_From
            // 
            this.guna2DateTimePicker_From.Checked = true;
            this.guna2DateTimePicker_From.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker_From.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker_From.Location = new System.Drawing.Point(632, 26);
            this.guna2DateTimePicker_From.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker_From.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker_From.Name = "guna2DateTimePicker_From";
            this.guna2DateTimePicker_From.Size = new System.Drawing.Size(225, 48);
            this.guna2DateTimePicker_From.TabIndex = 30;
            this.guna2DateTimePicker_From.Value = new System.DateTime(2024, 12, 5, 14, 8, 57, 719);
            this.guna2DateTimePicker_From.ValueChanged += new System.EventHandler(this.guna2DateTimePicker_From_ValueChanged);
            // 
            // guna2DateTimePicker_To
            // 
            this.guna2DateTimePicker_To.Checked = true;
            this.guna2DateTimePicker_To.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker_To.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker_To.Location = new System.Drawing.Point(863, 26);
            this.guna2DateTimePicker_To.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker_To.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker_To.Name = "guna2DateTimePicker_To";
            this.guna2DateTimePicker_To.Size = new System.Drawing.Size(218, 48);
            this.guna2DateTimePicker_To.TabIndex = 31;
            this.guna2DateTimePicker_To.Value = new System.DateTime(2024, 12, 5, 14, 8, 57, 719);
            this.guna2DateTimePicker_To.ValueChanged += new System.EventHandler(this.guna2DateTimePicker_To_ValueChanged);
            // 
            // btn_FilterByDate
            // 
            this.btn_FilterByDate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_FilterByDate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_FilterByDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_FilterByDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_FilterByDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_FilterByDate.ForeColor = System.Drawing.Color.White;
            this.btn_FilterByDate.Location = new System.Drawing.Point(1087, 26);
            this.btn_FilterByDate.Name = "btn_FilterByDate";
            this.btn_FilterByDate.Size = new System.Drawing.Size(64, 48);
            this.btn_FilterByDate.TabIndex = 32;
            this.btn_FilterByDate.Text = "Lọc";
            this.btn_FilterByDate.Click += new System.EventHandler(this.btn_FilterByDate_Click);
            // 
            // btn_ResetFilter
            // 
            this.btn_ResetFilter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ResetFilter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ResetFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ResetFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ResetFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_ResetFilter.ForeColor = System.Drawing.Color.White;
            this.btn_ResetFilter.Location = new System.Drawing.Point(1157, 26);
            this.btn_ResetFilter.Name = "btn_ResetFilter";
            this.btn_ResetFilter.Size = new System.Drawing.Size(93, 48);
            this.btn_ResetFilter.TabIndex = 33;
            this.btn_ResetFilter.Text = "Reset";
            this.btn_ResetFilter.Click += new System.EventHandler(this.btn_ResetFilter_Click);
            // 
            // dgv_invoice
            // 
            this.dgv_invoice.AllowUserToAddRows = false;
            this.dgv_invoice.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_invoice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_invoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_invoice.ColumnHeadersHeight = 4;
            this.dgv_invoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_invoice.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_invoice.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_invoice.Location = new System.Drawing.Point(30, 82);
            this.dgv_invoice.Name = "dgv_invoice";
            this.dgv_invoice.ReadOnly = true;
            this.dgv_invoice.RowHeadersVisible = false;
            this.dgv_invoice.RowHeadersWidth = 51;
            this.dgv_invoice.RowTemplate.Height = 24;
            this.dgv_invoice.Size = new System.Drawing.Size(1246, 478);
            this.dgv_invoice.TabIndex = 34;
            this.dgv_invoice.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_invoice.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_invoice.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_invoice.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_invoice.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_invoice.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_invoice.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_invoice.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_invoice.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_invoice.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_invoice.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_invoice.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_invoice.ThemeStyle.HeaderStyle.Height = 4;
            this.dgv_invoice.ThemeStyle.ReadOnly = true;
            this.dgv_invoice.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_invoice.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_invoice.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_invoice.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_invoice.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_invoice.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_invoice.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_invoice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_invoice_CellContentClick_1);
            // 
            // btn_ExportToExcel
            // 
            this.btn_ExportToExcel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ExportToExcel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ExportToExcel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ExportToExcel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ExportToExcel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_ExportToExcel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_ExportToExcel.ForeColor = System.Drawing.Color.White;
            this.btn_ExportToExcel.Location = new System.Drawing.Point(1282, 26);
            this.btn_ExportToExcel.Name = "btn_ExportToExcel";
            this.btn_ExportToExcel.Size = new System.Drawing.Size(143, 48);
            this.btn_ExportToExcel.TabIndex = 35;
            this.btn_ExportToExcel.Text = "Xuất FIle Excel";
            this.btn_ExportToExcel.Click += new System.EventHandler(this.btn_ExportToExcel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 583);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 37;
            this.label1.Text = "Mã đơn hàng";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOrderID.DefaultText = "";
            this.txtOrderID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOrderID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOrderID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOrderID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOrderID.Enabled = false;
            this.txtOrderID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOrderID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtOrderID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOrderID.Location = new System.Drawing.Point(132, 571);
            this.txtOrderID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.PasswordChar = '\0';
            this.txtOrderID.PlaceholderText = "";
            this.txtOrderID.SelectedText = "";
            this.txtOrderID.Size = new System.Drawing.Size(367, 30);
            this.txtOrderID.TabIndex = 40;
            this.txtOrderID.TextChanged += new System.EventHandler(this.txtOrderID_TextChanged);
            // 
            // txt_Phone
            // 
            this.txt_Phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Phone.DefaultText = "";
            this.txt_Phone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Phone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Phone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Phone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Phone.Enabled = false;
            this.txt_Phone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Phone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Phone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Phone.Location = new System.Drawing.Point(132, 609);
            this.txt_Phone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.PasswordChar = '\0';
            this.txt_Phone.PlaceholderText = "";
            this.txt_Phone.SelectedText = "";
            this.txt_Phone.Size = new System.Drawing.Size(367, 30);
            this.txt_Phone.TabIndex = 42;
            this.txt_Phone.TextChanged += new System.EventHandler(this.txt_Phone_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 621);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 41;
            this.label2.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(534, 583);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 18);
            this.label3.TabIndex = 44;
            this.label3.Text = "Trạng thái thanh toán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(534, 621);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 18);
            this.label4.TabIndex = 46;
            this.label4.Text = "Trạng thái đơn hàng";
            // 
            // txt_PriceShipp
            // 
            this.txt_PriceShipp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_PriceShipp.DefaultText = "";
            this.txt_PriceShipp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_PriceShipp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_PriceShipp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_PriceShipp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_PriceShipp.Enabled = false;
            this.txt_PriceShipp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_PriceShipp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_PriceShipp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_PriceShipp.Location = new System.Drawing.Point(132, 647);
            this.txt_PriceShipp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_PriceShipp.Name = "txt_PriceShipp";
            this.txt_PriceShipp.PasswordChar = '\0';
            this.txt_PriceShipp.PlaceholderText = "";
            this.txt_PriceShipp.SelectedText = "";
            this.txt_PriceShipp.Size = new System.Drawing.Size(367, 30);
            this.txt_PriceShipp.TabIndex = 48;
            this.txt_PriceShipp.TextChanged += new System.EventHandler(this.txt_PriceShipp_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 659);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 18);
            this.label5.TabIndex = 47;
            this.label5.Text = "Phí vận chuyển";
            // 
            // txt_AmoutPrice
            // 
            this.txt_AmoutPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_AmoutPrice.DefaultText = "";
            this.txt_AmoutPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_AmoutPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_AmoutPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_AmoutPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_AmoutPrice.Enabled = false;
            this.txt_AmoutPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_AmoutPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_AmoutPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_AmoutPrice.Location = new System.Drawing.Point(700, 647);
            this.txt_AmoutPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_AmoutPrice.Name = "txt_AmoutPrice";
            this.txt_AmoutPrice.PasswordChar = '\0';
            this.txt_AmoutPrice.PlaceholderText = "";
            this.txt_AmoutPrice.SelectedText = "";
            this.txt_AmoutPrice.Size = new System.Drawing.Size(367, 30);
            this.txt_AmoutPrice.TabIndex = 50;
            this.txt_AmoutPrice.TextChanged += new System.EventHandler(this.txt_AmoutPrice_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(595, 659);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 18);
            this.label6.TabIndex = 49;
            this.label6.Text = "Tổng Tiền";
            // 
            // txt_Voucher
            // 
            this.txt_Voucher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Voucher.DefaultText = "";
            this.txt_Voucher.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Voucher.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Voucher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Voucher.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Voucher.Enabled = false;
            this.txt_Voucher.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Voucher.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Voucher.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Voucher.Location = new System.Drawing.Point(700, 685);
            this.txt_Voucher.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Voucher.Name = "txt_Voucher";
            this.txt_Voucher.PasswordChar = '\0';
            this.txt_Voucher.PlaceholderText = "";
            this.txt_Voucher.SelectedText = "";
            this.txt_Voucher.Size = new System.Drawing.Size(367, 30);
            this.txt_Voucher.TabIndex = 52;
            this.txt_Voucher.TextChanged += new System.EventHandler(this.txt_Voucher_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(595, 697);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 18);
            this.label7.TabIndex = 51;
            this.label7.Text = "Mã giảm giá";
            // 
            // txt_address
            // 
            this.txt_address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_address.DefaultText = "";
            this.txt_address.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_address.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_address.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_address.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_address.Enabled = false;
            this.txt_address.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_address.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_address.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_address.Location = new System.Drawing.Point(132, 685);
            this.txt_address.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_address.Name = "txt_address";
            this.txt_address.PasswordChar = '\0';
            this.txt_address.PlaceholderText = "";
            this.txt_address.SelectedText = "";
            this.txt_address.Size = new System.Drawing.Size(367, 30);
            this.txt_address.TabIndex = 54;
            this.txt_address.TextChanged += new System.EventHandler(this.txt_address_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 697);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 18);
            this.label8.TabIndex = 53;
            this.label8.Text = "Địa chỉ ";
            // 
            // cbb_Payment
            // 
            this.cbb_Payment.FormattingEnabled = true;
            this.cbb_Payment.Location = new System.Drawing.Point(700, 571);
            this.cbb_Payment.Name = "cbb_Payment";
            this.cbb_Payment.Size = new System.Drawing.Size(367, 24);
            this.cbb_Payment.TabIndex = 55;
            this.cbb_Payment.SelectedIndexChanged += new System.EventHandler(this.cbb_Payment_SelectedIndexChanged_1);
            // 
            // cbb_order
            // 
            this.cbb_order.FormattingEnabled = true;
            this.cbb_order.Location = new System.Drawing.Point(700, 609);
            this.cbb_order.Name = "cbb_order";
            this.cbb_order.Size = new System.Drawing.Size(367, 24);
            this.cbb_order.TabIndex = 56;
            // 
            // dgv_InvoiceDetail
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgv_InvoiceDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_InvoiceDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_InvoiceDetail.ColumnHeadersHeight = 4;
            this.dgv_InvoiceDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_InvoiceDetail.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_InvoiceDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_InvoiceDetail.Location = new System.Drawing.Point(1282, 82);
            this.dgv_InvoiceDetail.Name = "dgv_InvoiceDetail";
            this.dgv_InvoiceDetail.RowHeadersVisible = false;
            this.dgv_InvoiceDetail.RowHeadersWidth = 51;
            this.dgv_InvoiceDetail.RowTemplate.Height = 24;
            this.dgv_InvoiceDetail.Size = new System.Drawing.Size(378, 478);
            this.dgv_InvoiceDetail.TabIndex = 57;
            this.dgv_InvoiceDetail.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_InvoiceDetail.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_InvoiceDetail.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_InvoiceDetail.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_InvoiceDetail.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_InvoiceDetail.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_InvoiceDetail.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_InvoiceDetail.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_InvoiceDetail.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_InvoiceDetail.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_InvoiceDetail.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_InvoiceDetail.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_InvoiceDetail.ThemeStyle.HeaderStyle.Height = 4;
            this.dgv_InvoiceDetail.ThemeStyle.ReadOnly = false;
            this.dgv_InvoiceDetail.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_InvoiceDetail.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_InvoiceDetail.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_InvoiceDetail.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_InvoiceDetail.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_InvoiceDetail.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_InvoiceDetail.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_InvoiceDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_InvoiceDetail_CellContentClick);
            // 
            // Form_Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1672, 764);
            this.Controls.Add(this.dgv_InvoiceDetail);
            this.Controls.Add(this.cbb_order);
            this.Controls.Add(this.cbb_Payment);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Voucher);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_AmoutPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_PriceShipp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Phone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ExportToExcel);
            this.Controls.Add(this.dgv_invoice);
            this.Controls.Add(this.btn_ResetFilter);
            this.Controls.Add(this.btn_FilterByDate);
            this.Controls.Add(this.guna2DateTimePicker_To);
            this.Controls.Add(this.guna2DateTimePicker_From);
            this.Controls.Add(this.btn_UpdateInvoice);
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.textBox_Search);
            this.Name = "Form_Invoice";
            this.Text = "Form_Invoice";
            this.Load += new System.EventHandler(this.Form_Invoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_InvoiceDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler1;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2TextBox textBox_Search;
        private Guna.UI2.WinForms.Guna2Button btn_UpdateInvoice;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker_From;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker_To;
        private Guna.UI2.WinForms.Guna2Button btn_FilterByDate;
        private Guna.UI2.WinForms.Guna2Button btn_ResetFilter;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_invoice;
        private Guna.UI2.WinForms.Guna2Button btn_ExportToExcel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtOrderID;
        private Guna.UI2.WinForms.Guna2TextBox txt_Phone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txt_PriceShipp;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txt_AmoutPrice;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txt_Voucher;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txt_address;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbb_Payment;
        private System.Windows.Forms.ComboBox cbb_order;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_InvoiceDetail;
    }
}