using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class InvoiceBLL
    {
        private InvoiceDAL invoiceDAL = new InvoiceDAL();
        public bool AddInvoice(donhang invoice)
        {
            if (invoice == null)
            {
                throw new ArgumentNullException("invoice", "Đơn hàng không hợp lệ");
            }

            return invoiceDAL.AddInvoice(invoice);
        }

        public List<chitietdonhang> getInvoiceDetailByIDInvoice(int id)
        {
            return invoiceDAL.getInvoiceDetailByIDInvoice(id);
        }


        public bool DeleteInvoice(int invoiceId)
        {
            var invoice = invoiceDAL.ShowInvoicesByStatus("All").FirstOrDefault(dh => dh.MaDonHang == invoiceId);
            if (invoice == null)
            {
                throw new InvalidOperationException("Đơn hàng không tồn tại");
            }

            return invoiceDAL.DeleteInvoice(invoiceId);
        }

        public bool UpdateInvoice(donhang updatedInvoice)
        {
            if (updatedInvoice == null)
            {
                throw new ArgumentNullException("updatedInvoice", "Thông tin đơn hàng không hợp lệ");
            }

            return invoiceDAL.UpdateInvoice(updatedInvoice);
        }

        public List<donhang> ShowInvoicesByDateRange(DateTime startDate, DateTime endDate)
        {
            if (startDate > endDate)
            {
                throw new ArgumentException("Ngày bắt đầu không thể lớn hơn ngày kết thúc");
            }

            return invoiceDAL.ShowInvoicesByDateRange(startDate, endDate);
        }

        public List<donhang> ShowInvoicesByStatus(string orderStatus)
        {
            if (string.IsNullOrEmpty(orderStatus))
            {
                throw new ArgumentException("Trạng thái đơn hàng không thể rỗng");
            }

            return invoiceDAL.ShowInvoicesByStatus(orderStatus);
        }
        public List<donhang> getAllInvoice()
        {
            return invoiceDAL.getAllInvoice();
        }

        public List<donhang> ShowInvoicesByPaymentMethod(string paymentMethod)
        {
            if (string.IsNullOrEmpty(paymentMethod))
            {
                throw new ArgumentException("Hình thức thanh toán không thể rỗng");
            }

            return invoiceDAL.ShowInvoicesByPaymentMethod(paymentMethod);
        }
    }
}
