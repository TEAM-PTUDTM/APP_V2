using DocumentFormat.OpenXml.Wordprocessing;
using GUI.Invoice_GUI;
using GUI.ProductGUI;
using GUI.ThongKeGUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.LayoutGUI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            btn_close.Click += Btn_close_Click;
            btn_Product.Click += Btn_Product_Click;
            btn_Category.Click += Btn_Category_Click;
            btn_ThongKe.Click += Btn_ThongKe_Click;
        }

        private void Btn_ThongKe_Click(object sender, EventArgs e)
        {
            LoadThongKe(); // Lọc theo tháng 6, năm 2024
        }

        private void Btn_Category_Click(object sender, EventArgs e)
        {
            LoadEmpCategory();
        }

      
        private void Btn_Product_Click(object sender, EventArgs e)
        {
            LoadEmployeesForm();
        }

        private void LoadEmployeesForm()
        {
            if (this.panel_content.Controls.Count > 0)
                this.panel_content.Controls[0].Dispose();
            FormProductList productForm = new FormProductList();
            productForm.TopLevel = false;
            productForm.FormBorderStyle = FormBorderStyle.None;
            productForm.Dock = DockStyle.Fill;
            this.panel_content.Controls.Add(productForm);
            this.panel_content.Tag = productForm;
            productForm.Show();
        }

        private void LoadEmpCategory()
        {
            if (this.panel_content.Controls.Count > 0)
                this.panel_content.Controls[0].Dispose();
            FormCategoryLayout productForm = new FormCategoryLayout();
            productForm.TopLevel = false;
            productForm.FormBorderStyle = FormBorderStyle.None;
            productForm.Dock = DockStyle.Fill;
            this.panel_content.Controls.Add(productForm);
            this.panel_content.Tag = productForm;
            productForm.Show();
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            LoadEmpInvoice();
        }
        private void LoadEmpInvoice()
        {
            if (this.panel_content.Controls.Count > 0)
                this.panel_content.Controls[0].Dispose();
            Form_Invoice Form = new Form_Invoice();
            Form.TopLevel = false;
            Form.FormBorderStyle = FormBorderStyle.None;
            Form.Dock = DockStyle.Fill;
            this.panel_content.Controls.Add(Form);
            this.panel_content.Tag = Form;
            Form.Show();
        }

        private void LoadThongKe()
        {

            if (this.panel_content.Controls.Count > 0)
                this.panel_content.Controls[0].Dispose();

            // Thay Form_Invoice thành FormThongKe
            FormThongKe form = new FormThongKe();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            this.panel_content.Controls.Add(form);
            this.panel_content.Tag = form;
            form.Show();
        }

    }
}
