using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class ProductBLL
    {
        ProductDAL productDAL = new ProductDAL();
        public List<sanpham> getProduct()
        {
            return productDAL.getProduct();
        }

        public List<sanpham> getProductByCategoryId(int categoryId)
        {
            return productDAL.getProductByCategoryId(categoryId);
        }

        public List<chitietsanpham> GetChitietsanphams()
        {
            return productDAL.GetChitietsanphams();
        }

        public bool addProduct(sanpham sp)
        {
                return productDAL.addProduct(sp);
        }

        public bool deleteProduct(int id)
        {
            return productDAL.deleteProduct(id);
        }
        public bool updateProduct(sanpham sanpham)
        {
            return productDAL.updateProduct(sanpham);
        }
        public bool checkPrymaryID(int id)
        {
            var pro = productDAL.findByIdProduct(id);
            if (pro != null)
                return true;
            return false;
        }
        public List<chitietsanpham> ShowProductDetailByID(int masp)
        {
            return productDAL.ShowProductDetail()
                             .Where(m => m.MaSP == masp)
                             .Select(m => new chitietsanpham
                             {
                                 MaChiTiet = m.MaChiTiet,
                                 MaSP = m.MaSP,
                                 MaKichThuoc = m.MaKichThuoc,
                                 MaMau = m.MaMau,
                                 SoLuongTon = m.SoLuongTon
                             })
                             .ToList(); 
        }

        public bool AddProductDetail(chitietsanpham newDetail)
        {
            return productDAL.InsertChitietsanpham(newDetail);
        }

        public bool UpdateProductDetail(chitietsanpham updatedDetail)
        {
            return productDAL.UpdateChitietsanpham(updatedDetail);
        }

        public bool DeleteProductDetail(int maChiTiet)
        {
            return productDAL.DeleteChitietsanpham(maChiTiet);
        }

    }
}
