namespace GUI.LayoutGUI
{
    partial class FormCategoryLayout
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
            this.Panel_content_category = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_CategoryProduct = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btn_Product_color = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btn_productSize = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.SuspendLayout();
            // 
            // Panel_content_category
            // 
            this.Panel_content_category.Location = new System.Drawing.Point(327, 36);
            this.Panel_content_category.Name = "Panel_content_category";
            this.Panel_content_category.Size = new System.Drawing.Size(942, 583);
            this.Panel_content_category.TabIndex = 12;
            // 
            // btn_CategoryProduct
            // 
            this.btn_CategoryProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_CategoryProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_CategoryProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_CategoryProduct.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_CategoryProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_CategoryProduct.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_CategoryProduct.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_CategoryProduct.ForeColor = System.Drawing.Color.White;
            this.btn_CategoryProduct.Location = new System.Drawing.Point(48, 268);
            this.btn_CategoryProduct.Name = "btn_CategoryProduct";
            this.btn_CategoryProduct.Size = new System.Drawing.Size(208, 42);
            this.btn_CategoryProduct.TabIndex = 10;
            this.btn_CategoryProduct.Text = "Quản lý danh mục";
            // 
            // btn_Product_color
            // 
            this.btn_Product_color.Animated = true;
            this.btn_Product_color.BackColor = System.Drawing.Color.Transparent;
            this.btn_Product_color.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Product_color.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Product_color.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Product_color.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Product_color.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Product_color.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Product_color.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Product_color.ForeColor = System.Drawing.Color.White;
            this.btn_Product_color.Location = new System.Drawing.Point(48, 141);
            this.btn_Product_color.Name = "btn_Product_color";
            this.btn_Product_color.Size = new System.Drawing.Size(208, 42);
            this.btn_Product_color.TabIndex = 9;
            this.btn_Product_color.Text = "Quản lý kích cỡ";
            // 
            // btn_productSize
            // 
            this.btn_productSize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_productSize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_productSize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_productSize.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_productSize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_productSize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_productSize.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_productSize.ForeColor = System.Drawing.Color.White;
            this.btn_productSize.Location = new System.Drawing.Point(48, 202);
            this.btn_productSize.Name = "btn_productSize";
            this.btn_productSize.Size = new System.Drawing.Size(208, 42);
            this.btn_productSize.TabIndex = 8;
            this.btn_productSize.Text = "Quản lý màu sắc";
            // 
            // FormCategoryLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 668);
            this.Controls.Add(this.Panel_content_category);
            this.Controls.Add(this.btn_CategoryProduct);
            this.Controls.Add(this.btn_Product_color);
            this.Controls.Add(this.btn_productSize);
            this.Name = "FormCategoryLayout";
            this.Text = "FormCategoryLayout";
            this.Load += new System.EventHandler(this.FormCategoryLayout_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Panel_content_category;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_CategoryProduct;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_Product_color;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_productSize;
    }
}