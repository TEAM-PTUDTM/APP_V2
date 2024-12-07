using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class WarehouseBLL
    {
        private WarehouseDAL warehouseDAL;

        public WarehouseBLL()
        {
            warehouseDAL = new WarehouseDAL();
        }
        public bool CreateInvoiceWithDetails(NhapHang nh, List<ChiTietNhapHang> nhDetails)
        {
            return warehouseDAL.CreateInvoiceWithDetails(nh, nhDetails);
        }

        public bool SaveInvoiceDetails(List<ChiTietNhapHang> nhDetails)
        {
            try
            {
                if (nhDetails == null || nhDetails.Count == 0)
                {
                    throw new ArgumentException("Danh sách chi tiết nhập hàng không hợp lệ.");
                }

                return warehouseDAL.SaveInvoiceDetails(nhDetails);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in SaveInvoiceDetails BLL: {ex.Message}");
                return false;
            }
        }


        public bool AddNewWarehouse(NhapHang nh)
        {
            try
            {
                if (nh == null)
                {
                    throw new ArgumentNullException(nameof(nh), "Thông tin nhập hàng không hợp lệ.");
                }

                return warehouseDAL.AddNewWarehouse(nh);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in AddNewWarehouse: {ex.Message}");
                return false;
            }
        }

        public List<NhapHang> GetAllInvoices()
        {
            try
            {
                return warehouseDAL.getAllInvoice();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetAllInvoices: {ex.Message}");
                return new List<NhapHang>(); 
            }
        }

        public List<ChiTietNhapHang> GetWarehouseDetailByWarehouse(int id)
        {
            try
            {
                if (id <= 0)
                {
                    throw new ArgumentException("Mã nhập hàng không hợp lệ.");
                }

                return warehouseDAL.getWarehouseDetailByWarehouse(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetWarehouseDetailByWarehouse: {ex.Message}");
                return new List<ChiTietNhapHang>(); 
            }
        }

        public bool AddNewWarehouseDetail(ChiTietNhapHang chiTietNhapHang)
        {
            try
            {
                if (chiTietNhapHang == null)
                {
                    throw new ArgumentNullException(nameof(chiTietNhapHang), "Thông tin chi tiết nhập hàng không hợp lệ.");
                }

                return warehouseDAL.AddNewWarehouseDetail(chiTietNhapHang);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in AddNewWarehouseDetail: {ex.Message}");
                return false;
            }
        }

        public List<NhapHang> GetInvoicesByDateRange(DateTime startDate, DateTime endDate)
        {
            try
            {
                return warehouseDAL.GetInvoicesByDateRange(startDate, endDate);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetInvoicesByDateRange BLL: {ex.Message}");
                return new List<NhapHang>();
            }
        }

        public List<NhapHang> GetInvoicesBySupplier(string supplierId)
        {
            try
            {
                return warehouseDAL.GetInvoicesBySupplier(supplierId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetInvoicesBySupplier BLL: {ex.Message}");
                return new List<NhapHang>();
            }
        }

        public List<NhapHang> GetFilteredInvoices(DateTime? startDate = null, DateTime? endDate = null, string supplierId = null)
        {
            try
            {
                return warehouseDAL.GetFilteredInvoices(startDate, endDate, supplierId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetFilteredInvoices BLL: {ex.Message}");
                return new List<NhapHang>();
            }
        }

    }
}
