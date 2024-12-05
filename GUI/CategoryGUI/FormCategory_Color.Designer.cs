namespace GUI.CategoryGUI
{
    partial class FormCategory_Color
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
            System.Windows.Forms.Label maKichThuocLabel;
            System.Windows.Forms.Label tenKichThuocLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategory_Color));
            this.sHOP = new GUI.SHOP();
            this.kichthuocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kichthuocTableAdapter = new GUI.SHOPTableAdapters.kichthuocTableAdapter();
            this.tableAdapterManager = new GUI.SHOPTableAdapters.TableAdapterManager();
            this.kichthuocBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.kichthuocBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.kichthuocDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKichThuocTextBox = new System.Windows.Forms.TextBox();
            this.tenKichThuocTextBox = new System.Windows.Forms.TextBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            maKichThuocLabel = new System.Windows.Forms.Label();
            tenKichThuocLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sHOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kichthuocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kichthuocBindingNavigator)).BeginInit();
            this.kichthuocBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kichthuocDataGridView)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // maKichThuocLabel
            // 
            maKichThuocLabel.AutoSize = true;
            maKichThuocLabel.Location = new System.Drawing.Point(14, 86);
            maKichThuocLabel.Name = "maKichThuocLabel";
            maKichThuocLabel.Size = new System.Drawing.Size(109, 20);
            maKichThuocLabel.TabIndex = 2;
            maKichThuocLabel.Text = "Ma Kich Thuoc:";
            maKichThuocLabel.Click += new System.EventHandler(this.maKichThuocLabel_Click);
            // 
            // tenKichThuocLabel
            // 
            tenKichThuocLabel.AutoSize = true;
            tenKichThuocLabel.Location = new System.Drawing.Point(14, 121);
            tenKichThuocLabel.Name = "tenKichThuocLabel";
            tenKichThuocLabel.Size = new System.Drawing.Size(111, 20);
            tenKichThuocLabel.TabIndex = 4;
            tenKichThuocLabel.Text = "Ten Kich Thuoc:";
            // 
            // sHOP
            // 
            this.sHOP.DataSetName = "SHOP";
            this.sHOP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kichthuocBindingSource
            // 
            this.kichthuocBindingSource.DataMember = "kichthuoc";
            this.kichthuocBindingSource.DataSource = this.sHOP;
            // 
            // kichthuocTableAdapter
            // 
            this.kichthuocTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cache_locksTableAdapter = null;
            this.tableAdapterManager.cacheTableAdapter = null;
            this.tableAdapterManager.chitietdonhangTableAdapter = null;
            this.tableAdapterManager.chitietsanphamTableAdapter = null;
            this.tableAdapterManager.danhmucTableAdapter = null;
            this.tableAdapterManager.donhangTableAdapter = null;
            this.tableAdapterManager.failed_jobsTableAdapter = null;
            this.tableAdapterManager.feedbackTableAdapter = null;
            this.tableAdapterManager.giohangTableAdapter = null;
            this.tableAdapterManager.hinhanhTableAdapter = null;
            this.tableAdapterManager.job_batchesTableAdapter = null;
            this.tableAdapterManager.jobsTableAdapter = null;
            this.tableAdapterManager.khachhangTableAdapter = null;
            this.tableAdapterManager.kichthuocTableAdapter = this.kichthuocTableAdapter;
            this.tableAdapterManager.mausacTableAdapter = null;
            this.tableAdapterManager.migrationsTableAdapter = null;
            this.tableAdapterManager.password_reset_tokensTableAdapter = null;
            this.tableAdapterManager.sanphamTableAdapter = null;
            this.tableAdapterManager.sessionsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GUI.SHOPTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            this.tableAdapterManager.voucher_khachhangTableAdapter = null;
            this.tableAdapterManager.voucherTableAdapter = null;
            // 
            // kichthuocBindingNavigator
            // 
            this.kichthuocBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.kichthuocBindingNavigator.BindingSource = this.kichthuocBindingSource;
            this.kichthuocBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.kichthuocBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.kichthuocBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.kichthuocBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.kichthuocBindingNavigatorSaveItem});
            this.kichthuocBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.kichthuocBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.kichthuocBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.kichthuocBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.kichthuocBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.kichthuocBindingNavigator.Name = "kichthuocBindingNavigator";
            this.kichthuocBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.kichthuocBindingNavigator.Size = new System.Drawing.Size(1331, 27);
            this.kichthuocBindingNavigator.TabIndex = 0;
            this.kichthuocBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // kichthuocBindingNavigatorSaveItem
            // 
            this.kichthuocBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.kichthuocBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("kichthuocBindingNavigatorSaveItem.Image")));
            this.kichthuocBindingNavigatorSaveItem.Name = "kichthuocBindingNavigatorSaveItem";
            this.kichthuocBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.kichthuocBindingNavigatorSaveItem.Text = "Save Data";
            this.kichthuocBindingNavigatorSaveItem.Click += new System.EventHandler(this.kichthuocBindingNavigatorSaveItem_Click);
            // 
            // kichthuocDataGridView
            // 
            this.kichthuocDataGridView.AutoGenerateColumns = false;
            this.kichthuocDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.kichthuocDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kichthuocDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.kichthuocDataGridView.DataSource = this.kichthuocBindingSource;
            this.kichthuocDataGridView.Location = new System.Drawing.Point(12, 51);
            this.kichthuocDataGridView.Name = "kichthuocDataGridView";
            this.kichthuocDataGridView.RowHeadersWidth = 51;
            this.kichthuocDataGridView.RowTemplate.Height = 24;
            this.kichthuocDataGridView.Size = new System.Drawing.Size(392, 220);
            this.kichthuocDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaKichThuoc";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaKichThuoc";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenKichThuoc";
            this.dataGridViewTextBoxColumn2.HeaderText = "TenKichThuoc";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // maKichThuocTextBox
            // 
            this.maKichThuocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kichthuocBindingSource, "MaKichThuoc", true));
            this.maKichThuocTextBox.Location = new System.Drawing.Point(145, 83);
            this.maKichThuocTextBox.Name = "maKichThuocTextBox";
            this.maKichThuocTextBox.Size = new System.Drawing.Size(229, 27);
            this.maKichThuocTextBox.TabIndex = 3;
            // 
            // tenKichThuocTextBox
            // 
            this.tenKichThuocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kichthuocBindingSource, "TenKichThuoc", true));
            this.tenKichThuocTextBox.Location = new System.Drawing.Point(145, 116);
            this.tenKichThuocTextBox.Name = "tenKichThuocTextBox";
            this.tenKichThuocTextBox.Size = new System.Drawing.Size(229, 27);
            this.tenKichThuocTextBox.TabIndex = 5;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.maKichThuocTextBox);
            this.guna2GroupBox1.Controls.Add(maKichThuocLabel);
            this.guna2GroupBox1.Controls.Add(this.tenKichThuocTextBox);
            this.guna2GroupBox1.Controls.Add(tenKichThuocLabel);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(12, 295);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(392, 200);
            this.guna2GroupBox1.TabIndex = 6;
            this.guna2GroupBox1.Text = "Quản lý kích cỡ";
            // 
            // FormCategory_Color
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 681);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.kichthuocDataGridView);
            this.Controls.Add(this.kichthuocBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCategory_Color";
            this.Text = "FormCategory_Color";
            this.Load += new System.EventHandler(this.FormCategory_Color_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sHOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kichthuocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kichthuocBindingNavigator)).EndInit();
            this.kichthuocBindingNavigator.ResumeLayout(false);
            this.kichthuocBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kichthuocDataGridView)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SHOP sHOP;
        private System.Windows.Forms.BindingSource kichthuocBindingSource;
        private SHOPTableAdapters.kichthuocTableAdapter kichthuocTableAdapter;
        private SHOPTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator kichthuocBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton kichthuocBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView kichthuocDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox maKichThuocTextBox;
        private System.Windows.Forms.TextBox tenKichThuocTextBox;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
    }
}