namespace GUI.CategoryGUI
{
    partial class FormCategory_Size
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
            System.Windows.Forms.Label maMauLabel;
            System.Windows.Forms.Label hEXCODELabel;
            System.Windows.Forms.Label tenMauLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategory_Size));
            this.sHOP = new GUI.SHOP();
            this.mausacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mausacTableAdapter = new GUI.SHOPTableAdapters.mausacTableAdapter();
            this.tableAdapterManager = new GUI.SHOPTableAdapters.TableAdapterManager();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.maMauTextBox = new System.Windows.Forms.TextBox();
            this.hEXCODETextBox = new System.Windows.Forms.TextBox();
            this.tenMauTextBox = new System.Windows.Forms.TextBox();
            this.mausacDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mausacBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.mausacBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            maMauLabel = new System.Windows.Forms.Label();
            hEXCODELabel = new System.Windows.Forms.Label();
            tenMauLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sHOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mausacBindingSource)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mausacDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mausacBindingNavigator)).BeginInit();
            this.mausacBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // maMauLabel
            // 
            maMauLabel.AutoSize = true;
            maMauLabel.Location = new System.Drawing.Point(9, 58);
            maMauLabel.Name = "maMauLabel";
            maMauLabel.Size = new System.Drawing.Size(66, 20);
            maMauLabel.TabIndex = 2;
            maMauLabel.Text = "Ma Mau:";
            // 
            // hEXCODELabel
            // 
            hEXCODELabel.AutoSize = true;
            hEXCODELabel.Location = new System.Drawing.Point(9, 114);
            hEXCODELabel.Name = "hEXCODELabel";
            hEXCODELabel.Size = new System.Drawing.Size(79, 20);
            hEXCODELabel.TabIndex = 6;
            hEXCODELabel.Text = "HEXCODE:";
            // 
            // tenMauLabel
            // 
            tenMauLabel.AutoSize = true;
            tenMauLabel.Location = new System.Drawing.Point(9, 86);
            tenMauLabel.Name = "tenMauLabel";
            tenMauLabel.Size = new System.Drawing.Size(68, 20);
            tenMauLabel.TabIndex = 4;
            tenMauLabel.Text = "Ten Mau:";
            // 
            // sHOP
            // 
            this.sHOP.DataSetName = "SHOP";
            this.sHOP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mausacBindingSource
            // 
            this.mausacBindingSource.DataMember = "mausac";
            this.mausacBindingSource.DataSource = this.sHOP;
            // 
            // mausacTableAdapter
            // 
            this.mausacTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.kichthuocTableAdapter = null;
            this.tableAdapterManager.mausacTableAdapter = this.mausacTableAdapter;
            this.tableAdapterManager.migrationsTableAdapter = null;
            this.tableAdapterManager.password_reset_tokensTableAdapter = null;
            this.tableAdapterManager.sanphamTableAdapter = null;
            this.tableAdapterManager.sessionsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GUI.SHOPTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            this.tableAdapterManager.voucher_khachhangTableAdapter = null;
            this.tableAdapterManager.voucherTableAdapter = null;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.maMauTextBox);
            this.guna2GroupBox1.Controls.Add(maMauLabel);
            this.guna2GroupBox1.Controls.Add(this.hEXCODETextBox);
            this.guna2GroupBox1.Controls.Add(hEXCODELabel);
            this.guna2GroupBox1.Controls.Add(tenMauLabel);
            this.guna2GroupBox1.Controls.Add(this.tenMauTextBox);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 411);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(566, 180);
            this.guna2GroupBox1.TabIndex = 11;
            this.guna2GroupBox1.Text = "Quản lý màu sắc";
            // 
            // maMauTextBox
            // 
            this.maMauTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mausacBindingSource, "MaMau", true));
            this.maMauTextBox.Location = new System.Drawing.Point(124, 58);
            this.maMauTextBox.Name = "maMauTextBox";
            this.maMauTextBox.Size = new System.Drawing.Size(173, 27);
            this.maMauTextBox.TabIndex = 3;
            // 
            // hEXCODETextBox
            // 
            this.hEXCODETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mausacBindingSource, "HEXCODE", true));
            this.hEXCODETextBox.Location = new System.Drawing.Point(124, 114);
            this.hEXCODETextBox.Name = "hEXCODETextBox";
            this.hEXCODETextBox.Size = new System.Drawing.Size(173, 27);
            this.hEXCODETextBox.TabIndex = 7;
            // 
            // tenMauTextBox
            // 
            this.tenMauTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mausacBindingSource, "TenMau", true));
            this.tenMauTextBox.Location = new System.Drawing.Point(124, 86);
            this.tenMauTextBox.Name = "tenMauTextBox";
            this.tenMauTextBox.Size = new System.Drawing.Size(173, 27);
            this.tenMauTextBox.TabIndex = 5;
            // 
            // mausacDataGridView
            // 
            this.mausacDataGridView.AutoGenerateColumns = false;
            this.mausacDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.mausacDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mausacDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.mausacDataGridView.DataSource = this.mausacBindingSource;
            this.mausacDataGridView.Location = new System.Drawing.Point(0, 75);
            this.mausacDataGridView.Name = "mausacDataGridView";
            this.mausacDataGridView.RowHeadersWidth = 51;
            this.mausacDataGridView.RowTemplate.Height = 24;
            this.mausacDataGridView.Size = new System.Drawing.Size(566, 315);
            this.mausacDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaMau";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaMau";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenMau";
            this.dataGridViewTextBoxColumn2.HeaderText = "TenMau";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "HEXCODE";
            this.dataGridViewTextBoxColumn3.HeaderText = "HEXCODE";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // mausacBindingNavigator
            // 
            this.mausacBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.mausacBindingNavigator.BindingSource = this.mausacBindingSource;
            this.mausacBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.mausacBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.mausacBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mausacBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.mausacBindingNavigatorSaveItem});
            this.mausacBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.mausacBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.mausacBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.mausacBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.mausacBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.mausacBindingNavigator.Name = "mausacBindingNavigator";
            this.mausacBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.mausacBindingNavigator.Size = new System.Drawing.Size(1250, 27);
            this.mausacBindingNavigator.TabIndex = 9;
            this.mausacBindingNavigator.Text = "bindingNavigator1";
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
            // mausacBindingNavigatorSaveItem
            // 
            this.mausacBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mausacBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("mausacBindingNavigatorSaveItem.Image")));
            this.mausacBindingNavigatorSaveItem.Name = "mausacBindingNavigatorSaveItem";
            this.mausacBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.mausacBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // FormCategory_Size
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 620);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.mausacDataGridView);
            this.Controls.Add(this.mausacBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCategory_Size";
            this.Text = "FormCategory_Size";
            this.Load += new System.EventHandler(this.FormCategory_Size_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sHOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mausacBindingSource)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mausacDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mausacBindingNavigator)).EndInit();
            this.mausacBindingNavigator.ResumeLayout(false);
            this.mausacBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SHOP sHOP;
        private System.Windows.Forms.BindingSource mausacBindingSource;
        private SHOPTableAdapters.mausacTableAdapter mausacTableAdapter;
        private SHOPTableAdapters.TableAdapterManager tableAdapterManager;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.TextBox maMauTextBox;
        private System.Windows.Forms.TextBox hEXCODETextBox;
        private System.Windows.Forms.TextBox tenMauTextBox;
        private System.Windows.Forms.DataGridView mausacDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingNavigator mausacBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton mausacBindingNavigatorSaveItem;
    }
}