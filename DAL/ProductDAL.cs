using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Data.Linq;
using DTO;
using System.ComponentModel;

namespace DAL
{
    public class ProductDAL
    {
        QLSHOPDataContext sql = new QLSHOPDataContext();

        public List<sanpham> getProductByCategoryId(int categoryId)
        {
            return sql.sanphams.Where(pro => pro.MaDanhMuc == categoryId).ToList();
        }

        public List<sanpham> getProduct()
        {
            return sql.sanphams.Select(pro => pro).ToList<sanpham>();
        }
        public List<chitietsanpham> GetChitietsanphams()
        {
            return sql.chitietsanphams.Select(pro => pro).ToList<chitietsanpham>();
        }
        public sanpham findByIdProduct(int id)
        {
            return sql.sanphams.Where(pro => pro.MaSP == id).FirstOrDefault();
        }
        public bool addProduct(sanpham sp)
        {
            try
            {
                sql.sanphams.InsertOnSubmit(sp);
                sql.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteProduct(int id)
        {
            try
            {
                var product = findByIdProduct(id);
                sql.sanphams.DeleteOnSubmit(product);
                sql.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool updateProduct(sanpham sp)
        {
            try
            {
                var product = findByIdProduct(sp.MaSP);
                product.TenSP = sp.TenSP;
                product.Gia = sp.Gia;
                product.PhanTramGiamGia = sp.PhanTramGiamGia;
                product.MoTa = sp.MoTa;
                product.MaDanhMuc = sp.MaDanhMuc;
                product.MaNhaCungCap = sp.MaNhaCungCap;
                product.TrinhTrang = sp.TrinhTrang;
                sql.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }


        public List<chitietsanpham> ShowProductDetail()
        {
            return sql.chitietsanphams.ToList();
        }

        public bool InsertChitietsanpham(chitietsanpham newChitiet)
        {
            try
            {
                sql.chitietsanphams.InsertOnSubmit(newChitiet);
                sql.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Có lỗi khi thêm: {ex.Message}");
                return false;
            }
        }
        public bool UpdateChitietsanpham(chitietsanpham updatedChitiet)
        {
            try
            {
                var existingChitiet = sql.chitietsanphams.FirstOrDefault(ct => ct.MaChiTiet == updatedChitiet.MaChiTiet);

                if (existingChitiet != null)
                {
                    existingChitiet.MaSP = updatedChitiet.MaSP;
                    existingChitiet.SoLuongTon = updatedChitiet.SoLuongTon;
                    existingChitiet.MaMau = updatedChitiet.MaMau;
                    existingChitiet.MaKichThuoc = updatedChitiet.MaKichThuoc;

                    sql.SubmitChanges(); // Lưu thay đổi
                    return true;
                }

                return false; // Không tìm thấy bản ghi
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Có lỗi khi cập nhật: {ex.Message}");
                return false;
            }
        }
        public bool DeleteChitietsanpham(int maChiTiet)
        {
            try
            {
                // Tìm sản phẩm cần xóa
                var existingChitiet = sql.chitietsanphams.FirstOrDefault(ct => ct.MaChiTiet == maChiTiet);

                if (existingChitiet != null)
                {
                    sql.chitietsanphams.DeleteOnSubmit(existingChitiet); // Xóa khỏi context
                    sql.SubmitChanges(); // Lưu thay đổi vào cơ sở dữ liệu
                    return true;
                }

                return false; // Không tìm thấy bản ghi
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Có lỗi khi xóa: {ex.Message}");
                return false;
            }
        }

    }
}


