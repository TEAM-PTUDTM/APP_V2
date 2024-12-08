using GUI.Invoice_GUI;
using GUI.ProductGUI;
using GUI.Warehouse;
using GUI.UserGUI;
using GUI.AccountGUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI.LayoutGUI
{
    public partial class FormMain : Form
    {
        EmployeeBLL NVbll = new EmployeeBLL();
        FormProductList proForm = new FormProductList();
        FormCategoryLayout cateForm = new FormCategoryLayout();
        Form_Invoice invoiceForm = new Form_Invoice();
        FormWarehoues wareForm = new FormWarehoues();
        FormWarehouseList wavelistForm = new FormWarehouseList();
        FormAccount fAccount;
        public FormMain(string email)
        {
            InitializeComponent();
            btn_close.Click += Btn_close_Click;
            btn_Product.Click += Btn_Product_Click;
            btn_Category.Click += Btn_Category_Click;
            lable_Logout.Click += Lable_Logout_Click;
            guna2Button5.Click += Guna2Button5_Click;
            guna2Button6.Click += Guna2Button6_Click;
            if (!NVbll.GetEmployeeRole(email))
            {
                guna2Button5.Visible = false;
                guna2Button8.Visible = false;
                btn_Product.Checked = true;
            }
            else
            {
                guna2Button8.Checked = true;
            }
            fAccount = new FormAccount(email);
        }

        private void Guna2Button6_Click(object sender, EventArgs e)
        {
            if (this.panel_content.Controls.Count > 0)
                this.panel_content.Controls[0].Dispose();
            fAccount.TopLevel = false;
            fAccount.FormBorderStyle = FormBorderStyle.None;
            fAccount.Dock = DockStyle.Fill;
            this.panel_content.Controls.Add(fAccount);
            this.panel_content.Tag = fAccount;
            fAccount.Show();
        }

        private void Guna2Button5_Click(object sender, EventArgs e)
        {
            if (this.panel_content.Controls.Count > 0)
                this.panel_content.Controls[0].Dispose();
            FormUser Form = new FormUser();
            Form.TopLevel = false;
            Form.FormBorderStyle = FormBorderStyle.None;
            Form.Dock = DockStyle.Fill;
            this.panel_content.Controls.Add(Form);
            this.panel_content.Tag = Form;
            Form.Show();
        }

        private void Lable_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            LoadWarehouse();
        }

        private void LoadWarehouse()
        {
            if (this.panel_content.Controls.Count > 0)
                this.panel_content.Controls[0].Dispose();
            FormWarehoues Form = new FormWarehoues();
            Form.TopLevel = false;
            Form.FormBorderStyle = FormBorderStyle.None;
            Form.Dock = DockStyle.Fill;
            this.panel_content.Controls.Add(Form);
            this.panel_content.Tag = Form;
            Form.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            LoadWarehouseList();
            
        }

        private void LoadWarehouseList()
        {
            if (this.panel_content.Controls.Count > 0)
                this.panel_content.Controls[0].Dispose();
            FormWarehouseList Form = new FormWarehouseList();
            Form.TopLevel = false;
            Form.FormBorderStyle = FormBorderStyle.None;
            Form.Dock = DockStyle.Fill;
            this.panel_content.Controls.Add(Form);
            this.panel_content.Tag = Form;
            Form.Show();
        }

        private void guna2Button5_Click_1(object sender, EventArgs e)
        {

        }
    }
}
