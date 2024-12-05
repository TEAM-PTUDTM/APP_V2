namespace GUI.CategoryGUI
{
    partial class FormCategoryType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategoryType));
            System.Windows.Forms.Label maDanhMucLabel;
            System.Windows.Forms.Label tenDanhMucLabel;
            this.sHOP = new GUI.SHOP();
            this.danhmucBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.danhmucTableAdapter = new GUI.SHOPTableAdapters.danhmucTableAdapter();
            this.tableAdapterManager = new GUI.SHOPTableAdapters.TableAdapterManager();
            this.danhmucBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.danhmucBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.danhmucDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maDanhMucTextBox = new System.Windows.Forms.TextBox();
            this.tenDanhMucTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            maDanhMucLabel = new System.Windows.Forms.Label();
            tenDanhMucLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sHOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhmucBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhmucBindingNavigator)).BeginInit();
            this.danhmucBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhmucDataGridView)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sHOP
            // 
            this.sHOP.DataSetName = "SHOP";
            this.sHOP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // danhmucBindingSource
            // 
            this.danhmucBindingSource.DataMember = "danhmuc";
            this.danhmucBindingSource.DataSource = this.sHOP;
            // 
            // danhmucTableAdapter
            // 
            this.danhmucTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cache_locksTableAdapter = null;
            this.tableAdapterManager.cacheTableAdapter = null;
            this.tableAdapterManager.chitietdonhangTableAdapter = null;
            this.tableAdapterManager.chitietsanphamTableAdapter = null;
            this.tableAdapterManager.danhmucTableAdapter = this.danhmucTableAdapter;
            this.tableAdapterManager.donhangTableAdapter = null;
            this.tableAdapterManager.failed_jobsTableAdapter = null;
            this.tableAdapterManager.feedbackTableAdapter = null;
            this.tableAdapterManager.giohangTableAdapter = null;
            this.tableAdapterManager.hinhanhTableAdapter = null;
            this.tableAdapterManager.job_batchesTableAdapter = null;
            this.tableAdapterManager.jobsTableAdapter = null;
            this.tableAdapterManager.khachhangTableAdapter = null;
            this.tableAdapterManager.kichthuocTableAdapter = null;
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
            // danhmucBindingNavigator
            // 
            this.danhmucBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.danhmucBindingNavigator.BindingSource = this.danhmucBindingSource;
            this.danhmucBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.danhmucBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.danhmucBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.danhmucBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.danhmucBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.danhmucBindingNavigatorSaveItem,
            this.bindingNavigatorDeleteItem});
            this.danhmucBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.danhmucBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.danhmucBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.danhmucBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.danhmucBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.danhmucBindingNavigator.Name = "danhmucBindingNavigator";
            this.danhmucBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.danhmucBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.danhmucBindingNavigator.Size = new System.Drawing.Size(1236, 27);
            this.danhmucBindingNavigator.TabIndex = 0;
            this.danhmucBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // danhmucBindingNavigatorSaveItem
            // 
            this.danhmucBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.danhmucBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("danhmucBindingNavigatorSaveItem.Image")));
            this.danhmucBindingNavigatorSaveItem.Name = "danhmucBindingNavigatorSaveItem";
            this.danhmucBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.danhmucBindingNavigatorSaveItem.Text = "Save Data";
            this.danhmucBindingNavigatorSaveItem.Click += new System.EventHandler(this.danhmucBindingNavigatorSaveItem_Click);
            // 
            // danhmucDataGridView
            // 
            this.danhmucDataGridView.AllowUserToOrderColumns = true;
            this.danhmucDataGridView.AutoGenerateColumns = false;
            this.danhmucDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.danhmucDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhmucDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.danhmucDataGridView.DataSource = this.danhmucBindingSource;
            this.danhmucDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.danhmucDataGridView.Location = new System.Drawing.Point(25, 55);
            this.danhmucDataGridView.Name = "danhmucDataGridView";
            this.danhmucDataGridView.RowHeadersWidth = 51;
            this.danhmucDataGridView.RowTemplate.Height = 24;
            this.danhmucDataGridView.Size = new System.Drawing.Size(422, 222);
            this.danhmucDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaDanhMuc";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaDanhMuc";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenDanhMuc";
            this.dataGridViewTextBoxColumn2.HeaderText = "TenDanhMuc";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // maDanhMucLabel
            // 
            maDanhMucLabel.AutoSize = true;
            maDanhMucLabel.Location = new System.Drawing.Point(12, 75);
            maDanhMucLabel.Name = "maDanhMucLabel";
            maDanhMucLabel.Size = new System.Drawing.Size(104, 20);
            maDanhMucLabel.TabIndex = 2;
            maDanhMucLabel.Text = "Ma Danh Muc:";
            // 
            // maDanhMucTextBox
            // 
            this.maDanhMucTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.danhmucBindingSource, "MaDanhMuc", true));
            this.maDanhMucTextBox.Enabled = false;
            this.maDanhMucTextBox.Location = new System.Drawing.Point(145, 72);
            this.maDanhMucTextBox.Name = "maDanhMucTextBox";
            this.maDanhMucTextBox.Size = new System.Drawing.Size(169, 27);
            this.maDanhMucTextBox.TabIndex = 3;
            // 
            // tenDanhMucLabel
            // 
            tenDanhMucLabel.AutoSize = true;
            tenDanhMucLabel.Location = new System.Drawing.Point(12, 103);
            tenDanhMucLabel.Name = "tenDanhMucLabel";
            tenDanhMucLabel.Size = new System.Drawing.Size(106, 20);
            tenDanhMucLabel.TabIndex = 4;
            tenDanhMucLabel.Text = "Ten Danh Muc:";
            // 
            // tenDanhMucTextBox
            // 
            this.tenDanhMucTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.danhmucBindingSource, "TenDanhMuc", true));
            this.tenDanhMucTextBox.Location = new System.Drawing.Point(145, 100);
            this.tenDanhMucTextBox.Name = "tenDanhMucTextBox";
            this.tenDanhMucTextBox.Size = new System.Drawing.Size(169, 27);
            this.tenDanhMucTextBox.TabIndex = 5;
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
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
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
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
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(maDanhMucLabel);
            this.guna2GroupBox1.Controls.Add(this.tenDanhMucTextBox);
            this.guna2GroupBox1.Controls.Add(this.maDanhMucTextBox);
            this.guna2GroupBox1.Controls.Add(tenDanhMucLabel);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(25, 311);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(422, 200);
            this.guna2GroupBox1.TabIndex = 6;
            this.guna2GroupBox1.Text = "Quản lý danh mục";
            // 
            // FormCategoryType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 616);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.danhmucDataGridView);
            this.Controls.Add(this.danhmucBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCategoryType";
            this.Text = "FormCategoryType";
            this.Load += new System.EventHandler(this.FormCategoryType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sHOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhmucBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhmucBindingNavigator)).EndInit();
            this.danhmucBindingNavigator.ResumeLayout(false);
            this.danhmucBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhmucDataGridView)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SHOP sHOP;
        private System.Windows.Forms.BindingSource danhmucBindingSource;
        private SHOPTableAdapters.danhmucTableAdapter danhmucTableAdapter;
        private SHOPTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator danhmucBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton danhmucBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView danhmucDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox maDanhMucTextBox;
        private System.Windows.Forms.TextBox tenDanhMucTextBox;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
    }
}