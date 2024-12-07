namespace GUI.ThongKeGUI
{
    partial class FormThongKe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThongKe));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txt_AmoutPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_ExportToExcel = new Guna.UI2.WinForms.Guna2Button();
            this.dgv_thongke = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btn_ResetFilter = new Guna.UI2.WinForms.Guna2Button();
            this.btn_FilterByDate = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.textBox_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2DateTimePicker_From = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2DateTimePicker_To = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.chartThongKe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKe)).BeginInit();
            this.SuspendLayout();
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
            this.txt_AmoutPrice.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AmoutPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_AmoutPrice.Location = new System.Drawing.Point(403, 598);
            this.txt_AmoutPrice.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_AmoutPrice.Name = "txt_AmoutPrice";
            this.txt_AmoutPrice.PasswordChar = '\0';
            this.txt_AmoutPrice.PlaceholderText = "";
            this.txt_AmoutPrice.SelectedText = "";
            this.txt_AmoutPrice.Size = new System.Drawing.Size(642, 46);
            this.txt_AmoutPrice.TabIndex = 76;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(246, 615);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 29);
            this.label6.TabIndex = 75;
            this.label6.Text = "Tổng Tiền";
            this.label6.Click += new System.EventHandler(this.label6_Click);
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
            this.btn_ExportToExcel.Location = new System.Drawing.Point(566, 664);
            this.btn_ExportToExcel.Name = "btn_ExportToExcel";
            this.btn_ExportToExcel.Size = new System.Drawing.Size(143, 48);
            this.btn_ExportToExcel.TabIndex = 66;
            this.btn_ExportToExcel.Text = "Xuất FIle Excel";
            this.btn_ExportToExcel.Click += new System.EventHandler(this.btn_ExportToExcel_Click);
            // 
            // dgv_thongke
            // 
            this.dgv_thongke.AllowUserToAddRows = false;
            this.dgv_thongke.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_thongke.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_thongke.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_thongke.ColumnHeadersHeight = 4;
            this.dgv_thongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_thongke.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_thongke.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_thongke.Location = new System.Drawing.Point(3, 62);
            this.dgv_thongke.Name = "dgv_thongke";
            this.dgv_thongke.ReadOnly = true;
            this.dgv_thongke.RowHeadersVisible = false;
            this.dgv_thongke.RowHeadersWidth = 51;
            this.dgv_thongke.RowTemplate.Height = 24;
            this.dgv_thongke.Size = new System.Drawing.Size(706, 478);
            this.dgv_thongke.TabIndex = 65;
            this.dgv_thongke.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_thongke.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_thongke.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_thongke.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_thongke.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_thongke.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_thongke.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_thongke.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_thongke.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_thongke.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_thongke.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_thongke.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_thongke.ThemeStyle.HeaderStyle.Height = 4;
            this.dgv_thongke.ThemeStyle.ReadOnly = true;
            this.dgv_thongke.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_thongke.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_thongke.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_thongke.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_thongke.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_thongke.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_thongke.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btn_ResetFilter
            // 
            this.btn_ResetFilter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ResetFilter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ResetFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ResetFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ResetFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_ResetFilter.ForeColor = System.Drawing.Color.White;
            this.btn_ResetFilter.Location = new System.Drawing.Point(1165, 6);
            this.btn_ResetFilter.Name = "btn_ResetFilter";
            this.btn_ResetFilter.Size = new System.Drawing.Size(93, 48);
            this.btn_ResetFilter.TabIndex = 64;
            this.btn_ResetFilter.Text = "Reset";
            this.btn_ResetFilter.Click += new System.EventHandler(this.btn_ResetFilter_Click);
            // 
            // btn_FilterByDate
            // 
            this.btn_FilterByDate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_FilterByDate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_FilterByDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_FilterByDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_FilterByDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_FilterByDate.ForeColor = System.Drawing.Color.White;
            this.btn_FilterByDate.Location = new System.Drawing.Point(1095, 6);
            this.btn_FilterByDate.Name = "btn_FilterByDate";
            this.btn_FilterByDate.Size = new System.Drawing.Size(64, 48);
            this.btn_FilterByDate.TabIndex = 63;
            this.btn_FilterByDate.Text = "Lọc";
            this.btn_FilterByDate.Click += new System.EventHandler(this.btn_FilterByDate_Click);
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
            this.guna2ComboBox1.Location = new System.Drawing.Point(388, 6);
            this.guna2ComboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(210, 36);
            this.guna2ComboBox1.TabIndex = 59;
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
            this.textBox_Search.Location = new System.Drawing.Point(3, 6);
            this.textBox_Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.PasswordChar = '\0';
            this.textBox_Search.PlaceholderText = "";
            this.textBox_Search.SelectedText = "";
            this.textBox_Search.ShadowDecoration.BorderRadius = 30;
            this.textBox_Search.ShadowDecoration.Color = System.Drawing.Color.IndianRed;
            this.textBox_Search.Size = new System.Drawing.Size(377, 48);
            this.textBox_Search.TabIndex = 58;
            this.textBox_Search.TextChanged += new System.EventHandler(this.textBox_Search_TextChanged);
            // 
            // guna2DateTimePicker_From
            // 
            this.guna2DateTimePicker_From.Checked = true;
            this.guna2DateTimePicker_From.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker_From.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker_From.Location = new System.Drawing.Point(614, 8);
            this.guna2DateTimePicker_From.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker_From.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker_From.Name = "guna2DateTimePicker_From";
            this.guna2DateTimePicker_From.Size = new System.Drawing.Size(225, 48);
            this.guna2DateTimePicker_From.TabIndex = 84;
            this.guna2DateTimePicker_From.Value = new System.DateTime(2024, 12, 5, 14, 8, 57, 719);
            this.guna2DateTimePicker_From.ValueChanged += new System.EventHandler(this.guna2DateTimePicker_From_ValueChanged);
            // 
            // guna2DateTimePicker_To
            // 
            this.guna2DateTimePicker_To.Checked = true;
            this.guna2DateTimePicker_To.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker_To.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker_To.Location = new System.Drawing.Point(845, 8);
            this.guna2DateTimePicker_To.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker_To.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker_To.Name = "guna2DateTimePicker_To";
            this.guna2DateTimePicker_To.Size = new System.Drawing.Size(218, 48);
            this.guna2DateTimePicker_To.TabIndex = 85;
            this.guna2DateTimePicker_To.Value = new System.DateTime(2024, 12, 5, 14, 8, 57, 719);
            this.guna2DateTimePicker_To.ValueChanged += new System.EventHandler(this.guna2DateTimePicker_To_ValueChanged);
            // 
            // chartThongKe
            // 
            chartArea1.Name = "ChartArea1";
            this.chartThongKe.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartThongKe.Legends.Add(legend1);
            this.chartThongKe.Location = new System.Drawing.Point(776, 84);
            this.chartThongKe.Name = "chartThongKe";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartThongKe.Series.Add(series1);
            this.chartThongKe.Size = new System.Drawing.Size(749, 469);
            this.chartThongKe.TabIndex = 86;
            this.chartThongKe.Text = "chartThongKe";
            // 
            // FormThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1766, 743);
            this.Controls.Add(this.chartThongKe);
            this.Controls.Add(this.guna2DateTimePicker_To);
            this.Controls.Add(this.guna2DateTimePicker_From);
            this.Controls.Add(this.txt_AmoutPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_ExportToExcel);
            this.Controls.Add(this.dgv_thongke);
            this.Controls.Add(this.btn_ResetFilter);
            this.Controls.Add(this.btn_FilterByDate);
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.textBox_Search);
            this.Name = "FormThongKe";
            this.Text = "FormThongKe";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txt_AmoutPrice;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button btn_ExportToExcel;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_thongke;
        private Guna.UI2.WinForms.Guna2Button btn_ResetFilter;
        private Guna.UI2.WinForms.Guna2Button btn_FilterByDate;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2TextBox textBox_Search;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker_From;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker_To;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThongKe;
    }
}