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
        CategoryBLL categoryBLL = new CategoryBLL();
        ColorBLL colorBLL = new ColorBLL();
        SizeBLL sizeBLL = new SizeBLL();

        public FormProductList()
        {
            InitializeComponent();
            var categories = categoryBLL.getCategory();
            var categoriesCbb = categoryBLL.getCategory();
            var colors = colorBLL.getColor(); 
            var sizes = sizeBLL.getSize();

            guna2ComboBox1.Items.Clear(); 
            cbb_DanhMuc.Items.Clear(); 
            cbb_Color.Items.Clear(); 
            cbb_Size.Items.Clear();

            if (categories != null && categories.Any())
            {
                cbb_DanhMuc.DataSource = categories;
                cbb_DanhMuc.DisplayMember = "TenDanhMuc";
                cbb_DanhMuc.ValueMember = "MaDanhMuc";
            }

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
            dgv_Product.SelectionChanged += Dgv_Product_SelectionChanged;
            dgv_Product.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LoadTrinhTrang();
            if (dgv_Product.Columns.Count >= 8) 
            {
                dgv_Product.Columns[5].Visible = false; 
                dgv_Product.Columns[7].Visible = false; 
                dgv_Product.Columns[8].Visible = false;
            }
        }
        private void textBox_Search_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox_Search.Text.Trim().ToLower();
            var products = productBLL.getProduct();
            var filteredProducts = products.Where(product =>
                product.TenSP.ToLower().Contains(searchText)).ToList();
            dgv_Product.DataSource = filteredProducts;
        }
        private void FormProductList_Load(object sender, EventArgs e)
        {
            
        }
        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (guna2ComboBox1.SelectedValue is int selectedCategoryId)
            {
                dgv_Product.DataSource = productBLL.getProductByCategoryId(selectedCategoryId);
            }
            
        }
        private void Dgv_Product_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Product.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow sl = dgv_Product.SelectedRows[0];

                    string masp = sl.Cells["MaSP"].Value?.ToString() ?? "";
                    string tensp = sl.Cells["TenSP"].Value?.ToString() ?? "";
                    string mota = sl.Cells["MoTa"].Value?.ToString() ?? "";
                    string gia = sl.Cells["Gia"].Value?.ToString() ?? "";
                    string giamgia = sl.Cells["PhanTramGiamGia"].Value?.ToString() ?? "";
                    string ncc = sl.Cells["NhaCungCap"].Value?.ToString() ?? "";
                    string trinhTrang = sl.Cells["TrinhTrang"].Value?.ToString() ?? "";
                    string danhmuc = sl.Cells["MaDanhMuc"].Value?.ToString() ?? "";

                    TxtMaSP.Text = masp;
                    Txt_TenSP.Text = tensp;
                    txt_moTa.Text = mota;
                    txt_gia.Text = gia;
                    Txt_giamGia.Text = giamgia;
                    cbb_DanhMuc.Text = danhmuc; 
                    txt_MaSP.Text = masp;

                    if (!string.IsNullOrEmpty(trinhTrang) && cbb_TrinhTrang.Items.Contains(trinhTrang))
                    {
                        cbb_TrinhTrang.SelectedItem = trinhTrang;
                    }
                    else
                    {
                        cbb_TrinhTrang.SelectedIndex = -1; 
                    }

                    if (!string.IsNullOrEmpty(danhmuc))
                    {
                        int categoryId;
                        if (int.TryParse(danhmuc, out categoryId))
                        {
                            cbb_DanhMuc.SelectedValue = categoryId;
                        }
                        else
                        {
                            cbb_DanhMuc.SelectedIndex = -1;
                        }
                    }

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
                               txt_MaSP.Text = productId.ToString();
                            }
                        }
                    }


                    btn_Update.Enabled = true;
                    btn_Delete.Enabled = true;
                    btn_Save.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                btn_Update.Enabled = false;
                btn_Delete.Enabled = false;
                btn_Save.Enabled = false;
            }
        }
        private void LoadDataGrid()
        {
            if (int.TryParse(txt_MaSP.Text, out int productId))
            {
                dgv_DetailProduct.DataSource = productBLL.ShowProductDetailByID(productId);
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
        private void btn_UpdateDetail_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo đối tượng cập nhật
                var updatedDetail = new chitietsanpham
                {
                    MaChiTiet = int.Parse(txt_MaChiTiet.Text),
                    MaSP = int.Parse(txt_MaSP.Text),
                    SoLuongTon = int.Parse(txt_SLT.Text),
                    MaKichThuoc = int.Parse(cbb_Size.SelectedValue.ToString()),
                    MaMau = int.Parse(cbb_Color.SelectedValue.ToString())
                };

                // Gọi BLL để cập nhật
                bool result = productBLL.UpdateProductDetail(updatedDetail);
                if (result)
                {
                    MessageBox.Show("Cập nhật chi tiết sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGrid(); // Load lại dữ liệu DataGridView
                }
                else
                {
                    MessageBox.Show("Cập nhật chi tiết sản phẩm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_deleteDetail_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy mã chi tiết sản phẩm từ TextBox
                int maChiTiet = int.Parse(txt_MaChiTiet.Text);

                // Hỏi người dùng trước khi xóa
                var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa chi tiết sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    // Gọi BLL để xóa
                    bool result = productBLL.DeleteProductDetail(maChiTiet);
                    if (result)
                    {
                        MessageBox.Show("Xóa chi tiết sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataGrid(); // Load lại dữ liệu DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Xóa chi tiết sản phẩm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_AddNewProductDetail_Click(object sender, EventArgs e)
        {
            try
            {
                var newDetail = new chitietsanpham
                {
                    MaSP = int.Parse(TxtMaSP.Text),
                    SoLuongTon = int.Parse(txt_SLT.Text),
                    MaKichThuoc = int.Parse(cbb_Size.SelectedValue.ToString()), 
                    MaMau = int.Parse(cbb_Color.SelectedValue.ToString())      // Giá trị mã màu
                };

                // Gọi BLL để thêm
                bool result = productBLL.AddProductDetail(newDetail);
                if (result)
                {
                    MessageBox.Show("Thêm mới chi tiết sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGrid(); // Load lại dữ liệu DataGridView
                }
                else
                {
                    MessageBox.Show("Thêm mới chi tiết sản phẩm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtMaSP.Text))
            {
                MessageBox.Show("Mã sản phẩm không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Lấy mã danh mục từ SelectedValue (chứ không phải tên danh mục)
                int maDanhMuc = (int)cbb_DanhMuc.SelectedValue;
                sanpham updatedProduct = new sanpham
                {
                    MaSP = int.Parse(TxtMaSP.Text),
                    TenSP = Txt_TenSP.Text, 
                    Gia = double.Parse(txt_gia.Text),
                    PhanTramGiamGia = double.Parse(Txt_giamGia.Text), 
                    MoTa = txt_moTa.Text, 
                    MaDanhMuc = maDanhMuc,
                    TrinhTrang = cbb_TrinhTrang.SelectedItem.ToString() 
                };

                bool isUpdated = productBLL.updateProduct(updatedProduct);

                if (isUpdated)
                {
                    MessageBox.Show("Cập nhật sản phẩm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật sản phẩm thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbb_DanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void txt_danhMuc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_TenSP.Text) || string.IsNullOrEmpty(txt_gia.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            double gia, giamGia;
            int maDanhMuc;

            if (!double.TryParse(txt_gia.Text, out gia))
            {
                MessageBox.Show("Giá sản phẩm không hợp lệ. Vui lòng nhập số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(Txt_giamGia.Text, out giamGia))
            {
                MessageBox.Show("Phần trăm giảm giá không hợp lệ. Vui lòng nhập số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(cbb_DanhMuc.SelectedValue?.ToString(), out maDanhMuc))
            {
                MessageBox.Show("Mã danh mục không hợp lệ. Vui lòng chọn một giá trị hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                

                sanpham newProduct = new sanpham
                {
                    TenSP = Txt_TenSP.Text,
                    Gia = gia,
                    PhanTramGiamGia = giamGia,
                    MoTa = txt_moTa.Text,
                    MaDanhMuc = maDanhMuc,
                    TrinhTrang = cbb_TrinhTrang.SelectedItem?.ToString()
                };

                bool isSaved = productBLL.addProduct(newProduct);


                if (isSaved)
                {
                    MessageBox.Show("Sản phẩm đã được lưu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_Save.Enabled = false; 
                }
                else
                {
                    MessageBox.Show("Có lỗi khi lưu sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }
        private void btn_addNew_Click_1(object sender, EventArgs e)
        {
            TxtMaSP.Text = "";
            Txt_TenSP.Text = "";
            txt_moTa.Text = "";
            txt_gia.Text = "";
            Txt_giamGia.Text = "";
            cbb_DanhMuc.Text = "";
            cbb_TrinhTrang.SelectedIndex = -1;

            btn_Save.Enabled = true;
            btn_Update.Enabled = false;
            btn_Delete.Enabled = false;
        }
        private void LoadTrinhTrang()
        {
            List<string> trinhTrangList = new List<string>
            {
                "conhang",
                "Hết hàng",
                "Đang nhập",
                "Ngừng kinh doanh"
            };
            cbb_TrinhTrang.DataSource = trinhTrangList;

            if (trinhTrangList.Count > 0)
            {
                cbb_TrinhTrang.SelectedIndex = 0;
            }
        }
        private void btn_IMG_Click(object sender, EventArgs e)
        {
            FormProductDetail f = new FormProductDetail(int.Parse(TxtMaSP.Text));
            f.Show();
        }
        private void cbb_TrinhTrang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtMaSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_TenSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_moTa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_gia_TextChanged(object sender, EventArgs e)
        {

        }
        private void txt_MaChiTiet_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_SLT_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbb_Size_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbb_Color_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Txt_giamGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_NCC_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_DetailProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_Product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_MaSP_TextChanged(object sender, EventArgs e)
        {

        }

      
    }
}
