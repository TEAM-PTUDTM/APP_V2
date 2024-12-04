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
using DTO;
using component;
using System.Web.UI.WebControls;

namespace GUI.ProductGUI
{
    public partial class FormProductList : Form
    {
        ProductBLL productBLL = new ProductBLL();
        public FormProductList()
        {
            InitializeComponent();
            dgv_Product.DataSource = productBLL.getProduct();
            dgv_Product.SelectionChanged += Dgv_Product_SelectionChanged;
            dgv_Product.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
          
        }

        private void FormProductList_Load(object sender, EventArgs e)
        {
           

          
            
        }
        private void Dgv_Product_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Product.SelectedRows.Count > 0)
            {
                DataGridViewRow sl = dgv_Product.SelectedRows[0];
                string masp = sl.Cells["MaSP"].Value.ToString();

                //dgv_DetailProduct.DataSource = productBLL.GetChitietsanphams().Where(m=>m.MaSP==int.Parse(masp)).ToList<chitietsanpham>();
                dgv_DetailProduct.DataSource = productBLL.ShowProductDetailByID(int.Parse(masp));
                // Ẩn các cột theo chỉ số (nếu có)
                dgv_DetailProduct.Columns[7].Visible = false; // Cột kichthu
                dgv_DetailProduct.Columns[5].Visible = false; // Cột mausac
                dgv_DetailProduct.Columns[6].Visible = false; // Cột sanpha
            }
        }

        private void dgv_Product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_DetailProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
