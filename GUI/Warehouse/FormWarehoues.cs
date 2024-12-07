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
using System.Numerics;

namespace GUI.Warehouse
{
    public partial class FormWarehoues : Form
    {
        ProductBLL productBLL = new ProductBLL();
        CategoryBLL categoryBLL = new CategoryBLL();
        ColorBLL colorBLL = new ColorBLL();
        SizeBLL sizeBLL = new SizeBLL();

        WarehouseBLL WarehouseBLL = new WarehouseBLL();
        public FormWarehoues()
        {
            InitializeComponent();
            InitializeDataGridViewNhapHang();

            var categories = categoryBLL.getCategory();
            var categoriesCbb = categoryBLL.getCategory();
            var colors = colorBLL.getColor();
            var sizes = sizeBLL.getSize();
            var ncc = categoryBLL.getAll_NCC();

            guna2ComboBox1.Items.Clear();
            cbb_Color.Items.Clear();
            cbb_Size.Items.Clear();
            cbb_ncc.Items.Clear();


            if (ncc != null && ncc.Any())
            {
                cbb_ncc.DataSource = ncc;
                cbb_ncc.DisplayMember = "TenNhaCungCap";
                cbb_ncc.ValueMember = "TenNhaCungCap";
            }
            cbb_ncc.SelectedIndex = -1;

            if (categoriesCbb != null && categoriesCbb.Any())
            {
                guna2ComboBox1.DataSource = categoriesCbb;
                guna2ComboBox1.DisplayMember = "TenDanhMuc";
                guna2ComboBox1.ValueMember = "MaDanhMuc";
            }

            if (colors != null && colors.Any())
            {
                cbb_Color.DataSource = colors;
                cbb_Color.DisplayMember = "TenMau";
                cbb_Color.ValueMember = "MaMau";
            }

            if (sizes != null && sizes.Any())
            {
                cbb_Size.DataSource = sizes;
                cbb_Size.DisplayMember = "TenKichThuoc";
                cbb_Size.ValueMember = "MaKichThuoc";
            }

            dgv_Product.DataSource = productBLL.getProduct();
            dgv_Product.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (dgv_Product.Columns.Count >= 8)
            {
                dgv_Product.Columns[3].Visible = false;
                dgv_Product.Columns[4].Visible = false;
                dgv_Product.Columns[6].Visible = false;
                dgv_Product.Columns[5].Visible = false;
                dgv_Product.Columns[7].Visible = false;
                dgv_Product.Columns[8].Visible = false;
            }

            //dgv_NhapHang.DataSource = WarehouseBLL.GetAllInvoices();
        }

        private void textBox_Search_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox_Search.Text.Trim().ToLower();
            var products = productBLL.getProduct();
            var filteredProducts = products.Where(product =>
                product.TenSP.ToLower().Contains(searchText)).ToList();
            dgv_Product.DataSource = filteredProducts;
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (guna2ComboBox1.SelectedValue is int selectedCategoryId)
            {
                dgv_Product.DataSource = productBLL.getProductByCategoryId(selectedCategoryId);
            }
        }
        private void dgv_SanPhamNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_SanPhamNhap.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    dgv_SanPhamNhap.Rows.RemoveAt(e.RowIndex); // Xóa dòng
                }
            }
        }

        private void dgv_Product_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Product.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow sl = dgv_Product.SelectedRows[0];

                    string masp = sl.Cells["MaSP"].Value?.ToString() ?? "";

                    if (int.TryParse(masp, out int productId))
                    {
                        dgv_DetailProduct.DataSource = productBLL.ShowProductDetailByID(productId);

                        dgv_DetailProduct.Columns[5].Visible = false;
                        dgv_DetailProduct.Columns[6].Visible = false;
                        dgv_DetailProduct.Columns[7].Visible = false;

                        var productDetails = productBLL.ShowProductDetailByID(productId);
                        if (productDetails != null && productDetails.Any())
                        {
                            var detail = productDetails.FirstOrDefault();
                            if (detail != null)
                            {

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void dgv_DetailProduct_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_DetailProduct.SelectedRows.Count > 0)
            {
                try
                {
                    // Lấy dòng chi tiết sản phẩm được chọn
                    DataGridViewRow selectedRow = dgv_DetailProduct.SelectedRows[0];

                    // Gán dữ liệu vào các TextBox
                    txt_MaChiTiet.Text = selectedRow.Cells["MaChiTiet"].Value?.ToString() ?? "";
                    txt_SLT.Text = selectedRow.Cells["SoLuongTon"].Value?.ToString() ?? "";


                    string sizeId = selectedRow.Cells["MaKichThuoc"].Value?.ToString() ?? "";
                    string colorId = selectedRow.Cells["MaMau"].Value?.ToString() ?? "";

                    // Hiển thị tên kích thước từ ComboBox
                    if (!string.IsNullOrEmpty(sizeId) && cbb_Size.Items.Count > 0)
                    {
                        var selectedSize = sizeBLL.getSize().FirstOrDefault(s => s.MaKichThuoc.ToString() == sizeId);
                        if (selectedSize != null)
                        {
                            cbb_Size.Text = selectedSize.TenKichThuoc;
                        }
                        else
                        {
                            cbb_Size.SelectedIndex = -1;
                        }
                    }

                    if (!string.IsNullOrEmpty(colorId) && cbb_Color.Items.Count > 0)
                    {
                        var selectedColor = colorBLL.getColor().FirstOrDefault(c => c.MaMau.ToString() == colorId);
                        if (selectedColor != null)
                        {
                            cbb_Color.Text = selectedColor.TenMau;
                        }
                        else
                        {
                            cbb_Color.SelectedIndex = -1;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                txt_MaChiTiet.Clear();
                txt_SLT.Clear();
                cbb_Size.SelectedIndex = -1;
                cbb_Color.SelectedIndex = -1;
            }
        }
        private void btn_Nhap_Click(object sender, EventArgs e)
        {
            try
            {
                string tenSP = dgv_Product.SelectedRows[0].Cells["TenSP"].Value?.ToString() ?? "";
                string size = cbb_Size.Text;
                string color = cbb_Color.Text;
                string maSize = cbb_Size.SelectedValue?.ToString() ?? "";
                string maColor = cbb_Color.SelectedValue?.ToString() ?? "";
                string maChiTiet = txt_MaChiTiet.Text;
                string soLuong = txt_SLN.Text;
                string giaNhap = txt_GiaNhap.Text;

                if (string.IsNullOrEmpty(tenSP) || string.IsNullOrEmpty(size) || string.IsNullOrEmpty(color) ||
                    string.IsNullOrEmpty(maSize) || string.IsNullOrEmpty(maColor) || string.IsNullOrEmpty(maChiTiet) ||
                    string.IsNullOrEmpty(soLuong) || string.IsNullOrEmpty(giaNhap))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(soLuong, out int soLuongInt) || soLuongInt <= 0)
                {
                    MessageBox.Show("Số lượng phải là số dương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(giaNhap, out decimal giaNhapDecimal) || giaNhapDecimal <= 0)
                {
                    MessageBox.Show("Giá nhập phải là số dương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool isUpdated = false;
                foreach (DataGridViewRow row in dgv_SanPhamNhap.Rows)
                {
                    if (row.Cells["MaChiTiet"]?.Value?.ToString() == maChiTiet)
                    {
                        int existingQuantity = int.Parse(row.Cells["SoLuong"].Value.ToString());
                        row.Cells["SoLuong"].Value = existingQuantity + soLuongInt;

                        BigInteger thanhTien = (BigInteger)(existingQuantity + soLuongInt) * (BigInteger)giaNhapDecimal;
                        row.Cells["ThanhTien"].Value = thanhTien;

                        isUpdated = true;
                        break;
                    }
                }

                if (!isUpdated)
                {
                    BigInteger thanhTienMoi = (BigInteger)soLuongInt * (BigInteger)giaNhapDecimal;
                    dgv_SanPhamNhap.Rows.Add(tenSP, size, color, maSize, maColor, maChiTiet, soLuongInt, giaNhapDecimal, thanhTienMoi);
                }

                UpdateTongTien();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void txt_TongTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateTongTien()
        {
            BigInteger tongTien = 0;

            foreach (DataGridViewRow row in dgv_SanPhamNhap.Rows)
            {
                if (row.Cells["ThanhTien"].Value != null)
                {
                    BigInteger thanhTien;
                    if (BigInteger.TryParse(row.Cells["ThanhTien"].Value.ToString(), out thanhTien))
                    {
                        tongTien += thanhTien;
                    }
                }
            }

            txt_TongTien.Text = tongTien.ToString("N0");
        }

        private void InitializeDataGridViewNhapHang()
        {
            dgv_SanPhamNhap.Columns.Clear();

            dgv_SanPhamNhap.Columns.Add("TenSP", "Tên Sản Phẩm");
            dgv_SanPhamNhap.Columns.Add("Size", "Kích Thước");
            dgv_SanPhamNhap.Columns.Add("Color", "Màu");
            dgv_SanPhamNhap.Columns.Add("MaSize", "Mã Kích Thước");
            dgv_SanPhamNhap.Columns.Add("MaColor", "Mã Màu");
            dgv_SanPhamNhap.Columns.Add("MaChiTiet", "Mã Chi Tiết");
            dgv_SanPhamNhap.Columns.Add("SoLuong", "Số Lượng");
            dgv_SanPhamNhap.Columns.Add("GiaNhap", "Giá Nhập");
            dgv_SanPhamNhap.Columns.Add("ThanhTien", "Thành Tiền");

            // Thêm cột xóa
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
            {
                Name = "Delete",
                HeaderText = "Xóa",
                Text = "Xóa",
                UseColumnTextForButtonValue = true,
            };
            dgv_SanPhamNhap.Columns.Add(deleteButtonColumn);

            dgv_SanPhamNhap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_SanPhamNhap.AllowUserToAddRows = false;
            dgv_SanPhamNhap.ColumnHeadersHeight = 40;

            
        }

        private void btn_TaoHoaDonNhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_SanPhamNhap.Rows.Count == 0)
                {
                    MessageBox.Show("Vui lòng thêm sản phẩm vào danh sách nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string nccId = cbb_ncc.SelectedValue?.ToString();
                if (string.IsNullOrEmpty(nccId))
                {
                    MessageBox.Show("Vui lòng chọn nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime ngayNhap = DateTime.Now;

                // Tạo mã nhập hàng ngẫu nhiên 6 chữ số
                Random random = new Random();
                int maNhapHang = random.Next(100000, 1000000);  // Tạo số ngẫu nhiên trong khoảng từ 100000 đến 999999

                NhapHang nhapHang = new NhapHang
                {
                    MaNhapHang = maNhapHang, 
                    NhaCungCap = nccId,
                    NgayNhap = ngayNhap,
                    NguoiNhap ="Nguyen Van Vuong",
                    GhiChu ="Đã nhập hàng",
                    TongTien= decimal.Parse(txt_TongTien.Text),
                };
                List<ChiTietNhapHang> chiTietNhapHangs = new List<ChiTietNhapHang>();
                foreach (DataGridViewRow row in dgv_SanPhamNhap.Rows)
                {
                    int soLuong = int.Parse(row.Cells["SoLuong"].Value.ToString());
                    decimal donGia = decimal.Parse(row.Cells["GiaNhap"].Value.ToString());

                    ChiTietNhapHang detail = new ChiTietNhapHang
                    {
                        MaNhapHang = maNhapHang,  
                        MaSanPham = int.Parse(row.Cells["MaChiTiet"].Value.ToString()), 
                        SoLuong = soLuong,  
                        DonGia = donGia, 
                        ThanhTien = soLuong * donGia  
                    };

                    chiTietNhapHangs.Add(detail);
                }


                bool result = WarehouseBLL.CreateInvoiceWithDetails(nhapHang, chiTietNhapHangs);

                if (result)
                {
                    MessageBox.Show("Tạo hoá đơn nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgv_SanPhamNhap.Rows.Clear();
                    txt_TongTien.Text = "";
                }
                else
                {
                    MessageBox.Show("Tạo hoá đơn nhập thất bại. Vui lòng kiểm tra log lỗi để biết thêm chi tiết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}\n{ex.ToString()}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }




        private void cbb_ncc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

     

        private void cbb_Color_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbb_Size_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txt_SLT_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txt_MaChiTiet_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txt_MaSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dgv_Product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void dgv_NhapHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
