namespace GUI.ProductGUI
{
    partial class FormProductDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductDetail));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel_Image = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btn_create = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btn_exit = new Guna.UI2.WinForms.Guna2GradientTileButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 454);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Panel_Image
            // 
            this.Panel_Image.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Image.FillColor = System.Drawing.Color.White;
            this.Panel_Image.Location = new System.Drawing.Point(27, 22);
            this.Panel_Image.Margin = new System.Windows.Forms.Padding(4);
            this.Panel_Image.Name = "Panel_Image";
            this.Panel_Image.ShadowColor = System.Drawing.Color.Black;
            this.Panel_Image.Size = new System.Drawing.Size(900, 430);
            this.Panel_Image.TabIndex = 41;
            this.Panel_Image.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Image_Paint);
            // 
            // btn_create
            // 
            this.btn_create.Animated = true;
            this.btn_create.BackColor = System.Drawing.Color.Transparent;
            this.btn_create.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.btn_create.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_create.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_create.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_create.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_create.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_create.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_create.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_create.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.btn_create.ForeColor = System.Drawing.Color.White;
            this.btn_create.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btn_create.Location = new System.Drawing.Point(124, 460);
            this.btn_create.Margin = new System.Windows.Forms.Padding(4);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(236, 50);
            this.btn_create.TabIndex = 40;
            this.btn_create.Text = "CREATE IMAGE";
            this.btn_create.UseTransparentBackground = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Animated = true;
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.btn_exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_exit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_exit.FillColor = System.Drawing.Color.Red;
            this.btn_exit.FillColor2 = System.Drawing.Color.Yellow;
            this.btn_exit.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btn_exit.Location = new System.Drawing.Point(691, 466);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(236, 50);
            this.btn_exit.TabIndex = 54;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.UseTransparentBackground = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // FormProductDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(949, 552);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Panel_Image);
            this.Controls.Add(this.btn_create);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProductDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProductDetail";
            this.Load += new System.EventHandler(this.FormProductDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2ShadowPanel Panel_Image;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_create;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_exit;
    }
}