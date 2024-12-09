using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class InvoiceDAL
    { 
        QLSHOPDataContext sql = new QLSHOPDataContext();
        // Thêm đơn hàng mới
        public bool AddInvoice(donhang invoice)
        {
            try
            {
                sql.donhangs.InsertOnSubmit(invoice);
                sql.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }

        public List<chitietdonhang> getInvoiceDetailByIDInvoice(int id) { 
            return sql.chitietdonhangs.Where(dt=>dt.MaDonHang == id).ToList();
        }

        // Xóa đơn hàng
        public bool DeleteInvoice(int invoiceId)
        {
            try
            {
                var invoice = sql.donhangs.FirstOrDefault(dh => dh.MaDonHang == invoiceId);
                if (invoice != null)
                {
                    sql.donhangs.DeleteOnSubmit(invoice);
                    sql.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }

        // Cập nhật thông tin đơn hàng
        public bool UpdateInvoice(donhang updatedInvoice)
        {
            try
            {
                var existingInvoice = sql.donhangs.FirstOrDefault(dh => dh.MaDonHang == updatedInvoice.MaDonHang);
                if (existingInvoice != null)
                {
                    //existingInvoice.MaKhachHang = updatedInvoice.MaKhachHang;
                    //existingInvoice.NgayDat = updatedInvoice.NgayDat;
                    //existingInvoice.NgayDuKienGiaoHang = updatedInvoice.NgayDuKienGiaoHang;
                    //existingInvoice.TongGia = updatedInvoice.TongGia;
                    //existingInvoice.TongTienSauKhiGiamGia = updatedInvoice.TongTienSauKhiGiamGia;
                    //existingInvoice.PhiVanChuyen = updatedInvoice.PhiVanChuyen;
                    existingInvoice.TrangThaiThanhToan = updatedInvoice.TrangThaiThanhToan;
                    //existingInvoice.HinhThucThanhToan = updatedInvoice.HinhThucThanhToan;
                    existingInvoice.TrangThaiDonHang = updatedInvoice.TrangThaiDonHang;
                    //existingInvoice.DiaChiGiaoHang = updatedInvoice.DiaChiGiaoHang;
                    //existingInvoice.MaVoucher = updatedInvoice.MaVoucher;
                    //existingInvoice.RecipientPhone = updatedInvoice.RecipientPhone;

                    sql.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }

        // Hiển thị đơn hàng theo khoảng thời gian (từ ngày này đến ngày kia)
        public List<donhang> ShowInvoicesByDateRange(DateTime startDate, DateTime endDate)
        {
            return sql.donhangs
                      .Where(dh => dh.NgayDat >= startDate && dh.NgayDat <= endDate)
                      .ToList();
        }

        // Hiển thị đơn hàng theo trạng thái đơn hàng
        public List<donhang> ShowInvoicesByStatus(string orderStatus)
        {
            return sql.donhangs
                      .Where(dh => dh.TrangThaiDonHang == orderStatus)
                      .ToList();
        }

        public List<donhang> getAllInvoice()
        {
            return sql.donhangs.ToList();
        }


        // Hiển thị đơn hàng theo hình thức thanh toán
        public List<donhang> ShowInvoicesByPaymentMethod(string paymentMethod)
        {
            return sql.donhangs
                      .Where(dh => dh.HinhThucThanhToan == paymentMethod)
                      .ToList();
        }



        //Thống kê
        // Phương thức lọc theo tháng và từ khóa tìm kiếm
        // Phương thức lọc theo tháng và từ khóa tìm kiếm
        public List<donhang> GetFilteredInvoices(int month, string searchKeyword)
        {
            try
            {
                return sql.donhangs
                          .Where(dh => dh.TrangThaiThanhToan == "Ðã Thanh Toán" // Lọc theo trạng thái thanh toán
                                      && dh.NgayDat.HasValue // Kiểm tra NgayDat có giá trị không
                                      && dh.NgayDat.Value.Month == month // Lọc theo tháng
                                      && (dh.MaDonHang.ToString().Contains(searchKeyword)
                                           || dh.TrangThaiDonHang.Contains(searchKeyword)) // Lọc theo mã đơn hàng hoặc trạng thái đơn hàng
                          )
                          .ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return new List<donhang>(); // Trả về danh sách rỗng trong trường hợp có lỗi
            }
        }

        //Thống kê
        // Thống kê: Hiển thị đơn hàng theo khoảng thời gian và trạng thái thanh toán
        public List<donhang> ShowInvoicesByDateRangeAndStatus(DateTime fromDate, DateTime toDate, string status)
        {
            try
            {
                // Truy vấn lọc các đơn hàng theo khoảng thời gian và trạng thái thanh toán
                var query = sql.donhangs.Where(invoice =>
                    invoice.NgayDat >= fromDate && invoice.NgayDat <= toDate &&
                    (string.IsNullOrEmpty(status) || invoice.TrangThaiThanhToan.Contains(status))
                ).ToList();

                return query;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return new List<donhang>(); // Trả về danh sách rỗng nếu có lỗi
            }
        }
    }
}
