namespace GUI.Warehouse
{
    partial class FormWarehouseList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_warehouse = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgv_warehouseDetail = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cbb_NCC = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2DateTimePicker_Start = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2DateTimePicker_end = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btn_ExportToExcel = new Guna.UI2.WinForms.Guna2Button();
            this.btn_loc = new Guna.UI2.WinForms.Guna2Button();
            this.btn_reset = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_warehouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_warehouseDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_warehouse
            // 
            this.dgv_warehouse.AllowUserToAddRows = false;
            this.dgv_warehouse.AllowUserToDeleteRows = false;
            dataGridViewCellStyle37.BackColor = System.Drawing.Color.White;
            this.dgv_warehouse.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle37;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle38.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_warehouse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle38;
            this.dgv_warehouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle39.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_warehouse.DefaultCellStyle = dataGridViewCellStyle39;
            this.dgv_warehouse.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_warehouse.Location = new System.Drawing.Point(25, 122);
            this.dgv_warehouse.Name = "dgv_warehouse";
            this.dgv_warehouse.ReadOnly = true;
            this.dgv_warehouse.RowHeadersVisible = false;
            this.dgv_warehouse.RowHeadersWidth = 51;
            this.dgv_warehouse.RowTemplate.Height = 24;
            this.dgv_warehouse.Size = new System.Drawing.Size(896, 711);
            this.dgv_warehouse.TabIndex = 0;
            this.dgv_warehouse.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_warehouse.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_warehouse.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_warehouse.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_warehouse.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_warehouse.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_warehouse.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_warehouse.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_warehouse.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_warehouse.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_warehouse.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_warehouse.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_warehouse.ThemeStyle.HeaderStyle.Height = 4;
            this.dgv_warehouse.ThemeStyle.ReadOnly = true;
            this.dgv_warehouse.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_warehouse.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_warehouse.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_warehouse.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_warehouse.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_warehouse.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_warehouse.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_warehouse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_warehouse_CellContentClick);
            // 
            // dgv_warehouseDetail
            // 
            this.dgv_warehouseDetail.AllowUserToAddRows = false;
            this.dgv_warehouseDetail.AllowUserToDeleteRows = false;
            dataGridViewCellStyle40.BackColor = System.Drawing.Color.White;
            this.dgv_warehouseDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle40;
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle41.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle41.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle41.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle41.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle41.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle41.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_warehouseDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle41;
            this.dgv_warehouseDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle42.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle42.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle42.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle42.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle42.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_warehouseDetail.DefaultCellStyle = dataGridViewCellStyle42;
            this.dgv_warehouseDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_warehouseDetail.Location = new System.Drawing.Point(942, 122);
            this.dgv_warehouseDetail.Name = "dgv_warehouseDetail";
            this.dgv_warehouseDetail.ReadOnly = true;
            this.dgv_warehouseDetail.RowHeadersVisible = false;
            this.dgv_warehouseDetail.RowHeadersWidth = 51;
            this.dgv_warehouseDetail.RowTemplate.Height = 24;
            this.dgv_warehouseDetail.Size = new System.Drawing.Size(787, 711);
            this.dgv_warehouseDetail.TabIndex = 1;
            this.dgv_warehouseDetail.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_warehouseDetail.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_warehouseDetail.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_warehouseDetail.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_warehouseDetail.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_warehouseDetail.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_warehouseDetail.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_warehouseDetail.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_warehouseDetail.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_warehouseDetail.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_warehouseDetail.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_warehouseDetail.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_warehouseDetail.ThemeStyle.HeaderStyle.Height = 4;
            this.dgv_warehouseDetail.ThemeStyle.ReadOnly = true;
            this.dgv_warehouseDetail.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_warehouseDetail.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_warehouseDetail.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_warehouseDetail.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_warehouseDetail.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_warehouseDetail.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_warehouseDetail.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_warehouseDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_warehouseDetail_CellContentClick);
            // 
            // cbb_NCC
            // 
            this.cbb_NCC.BackColor = System.Drawing.Color.Transparent;
            this.cbb_NCC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_NCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_NCC.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_NCC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_NCC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbb_NCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbb_NCC.ItemHeight = 30;
            this.cbb_NCC.Location = new System.Drawing.Point(25, 70);
            this.cbb_NCC.Name = "cbb_NCC";
            this.cbb_NCC.Size = new System.Drawing.Size(356, 36);
            this.cbb_NCC.TabIndex = 2;
            this.cbb_NCC.SelectedIndexChanged += new System.EventHandler(this.cbb_NCC_SelectedIndexChanged);
            // 
            // guna2DateTimePicker_Start
            // 
            this.guna2DateTimePicker_Start.Checked = true;
            this.guna2DateTimePicker_Start.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker_Start.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker_Start.Location = new System.Drawing.Point(387, 70);
            this.guna2DateTimePicker_Start.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker_Start.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker_Start.Name = "guna2DateTimePicker_Start";
            this.guna2DateTimePicker_Start.Size = new System.Drawing.Size(261, 36);
            this.guna2DateTimePicker_Start.TabIndex = 3;
            this.guna2DateTimePicker_Start.Value = new System.DateTime(2024, 12, 7, 8, 52, 21, 66);
            this.guna2DateTimePicker_Start.ValueChanged += new System.EventHandler(this.guna2DateTimePicker_Start_ValueChanged);
            // 
            // guna2DateTimePicker_end
            // 
            this.guna2DateTimePicker_end.Checked = true;
            this.guna2DateTimePicker_end.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker_end.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker_end.Location = new System.Drawing.Point(663, 70);
            this.guna2DateTimePicker_end.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker_end.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker_end.Name = "guna2DateTimePicker_end";
            this.guna2DateTimePicker_end.Size = new System.Drawing.Size(258, 36);
            this.guna2DateTimePicker_end.TabIndex = 4;
            this.guna2DateTimePicker_end.Value = new System.DateTime(2024, 12, 7, 8, 52, 21, 66);
            this.guna2DateTimePicker_end.ValueChanged += new System.EventHandler(this.guna2DateTimePicker_end_ValueChanged);
            // 
            // btn_ExportToExcel
            // 
            this.btn_ExportToExcel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ExportToExcel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ExportToExcel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ExportToExcel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ExportToExcel.FillColor = System.Drawing.Color.Green;
            this.btn_ExportToExcel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_ExportToExcel.ForeColor = System.Drawing.Color.White;
            this.btn_ExportToExcel.Location = new System.Drawing.Point(1189, 70);
            this.btn_ExportToExcel.Name = "btn_ExportToExcel";
            this.btn_ExportToExcel.Size = new System.Drawing.Size(180, 36);
            this.btn_ExportToExcel.TabIndex = 5;
            this.btn_ExportToExcel.Text = "Xuất file excel";
            this.btn_ExportToExcel.Click += new System.EventHandler(this.btn_ExportToExcel_Click);
            // 
            // btn_loc
            // 
            this.btn_loc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_loc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_loc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_loc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_loc.FillColor = System.Drawing.Color.Green;
            this.btn_loc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_loc.ForeColor = System.Drawing.Color.White;
            this.btn_loc.Location = new System.Drawing.Point(942, 70);
            this.btn_loc.Name = "btn_loc";
            this.btn_loc.Size = new System.Drawing.Size(118, 36);
            this.btn_loc.TabIndex = 6;
            this.btn_loc.Text = "Lọc";
            this.btn_loc.Click += new System.EventHandler(this.btn_loc_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_reset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_reset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_reset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_reset.FillColor = System.Drawing.Color.Green;
            this.btn_reset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_reset.ForeColor = System.Drawing.Color.White;
            this.btn_reset.Location = new System.Drawing.Point(1066, 70);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(117, 36);
            this.btn_reset.TabIndex = 7;
            this.btn_reset.Text = "Reset";
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(691, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "HÓA ĐƠN NHẬP KHO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormWarehouseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1776, 857);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_loc);
            this.Controls.Add(this.btn_ExportToExcel);
            this.Controls.Add(this.guna2DateTimePicker_end);
            this.Controls.Add(this.guna2DateTimePicker_Start);
            this.Controls.Add(this.cbb_NCC);
            this.Controls.Add(this.dgv_warehouseDetail);
            this.Controls.Add(this.dgv_warehouse);
            this.Name = "FormWarehouseList";
            this.Text = "FormWarehouseList";
            this.Load += new System.EventHandler(this.FormWarehouseList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_warehouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_warehouseDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgv_warehouse;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_warehouseDetail;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_NCC;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker_Start;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker_end;
        private Guna.UI2.WinForms.Guna2Button btn_ExportToExcel;
        private Guna.UI2.WinForms.Guna2Button btn_loc;
        private Guna.UI2.WinForms.Guna2Button btn_reset;
        private System.Windows.Forms.Label label1;
    }
}