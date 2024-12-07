using System;
using System.Collections.Generic;
using System.Linq;
using DTO;
using System.Transactions;

namespace DAL
{
    public class WarehouseDAL
    {
        QLSHOPDataContext sql = new QLSHOPDataContext();


        public bool CreateInvoiceWithDetails(NhapHang nh, List<ChiTietNhapHang> nhDetails)
        {
            using (var transaction = new TransactionScope())
            {
                try
                {
                    sql.NhapHangs.InsertOnSubmit(nh);
                    sql.SubmitChanges();

                    int maNhapHang = nh.MaNhapHang;

                    foreach (var detail in nhDetails)
                    {
                        detail.MaNhapHang = maNhapHang; 
                        sql.ChiTietNhapHangs.InsertOnSubmit(detail);
                    }
                    sql.SubmitChanges();

                    transaction.Complete();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    return false;
                }
            }
        }



        public bool AddNewWarehouse(NhapHang nh)
        {
            try
            {
                sql.NhapHangs.InsertOnSubmit(nh);
                sql.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }

        public List<NhapHang> getAllInvoice()
        {
            return sql.NhapHangs.ToList();
        }

        public List<ChiTietNhapHang> getWarehouseDetailByWarehouse(int id)
        {
            return sql.ChiTietNhapHangs.Where(dt => dt.MaNhapHang == id).ToList();
        }

        public bool AddNewWarehouseDetail(ChiTietNhapHang nh)
        {
            try
            {
                sql.ChiTietNhapHangs.InsertOnSubmit(nh);
                sql.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }
        public bool SaveInvoiceDetails(List<ChiTietNhapHang> nhDetails)
        {
            try
            {
                foreach (var detail in nhDetails)
                {
                    sql.ChiTietNhapHangs.InsertOnSubmit(detail);
                }

                sql.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in SaveInvoiceDetails: {ex.Message}");
                return false;
            }
        }


        public List<NhapHang> GetInvoicesByDateRange(DateTime startDate, DateTime endDate)
        {
            return sql.NhapHangs
                      .Where(nh => nh.NgayNhap >= startDate && nh.NgayNhap <= endDate)
                      .ToList();
        }

        public List<NhapHang> GetInvoicesBySupplier(string supplierId)
        {
            return sql.NhapHangs
                      .Where(nh => nh.NhaCungCap == supplierId)
                      .ToList();
        }

        public List<NhapHang> GetFilteredInvoices(DateTime? startDate = null, DateTime? endDate = null, string supplierId = null)
        {
            var query = sql.NhapHangs.AsQueryable();

            if (startDate.HasValue && endDate.HasValue)
            {
                query = query.Where(nh => nh.NgayNhap >= startDate.Value && nh.NgayNhap <= endDate.Value);
            }

            if (!string.IsNullOrEmpty(supplierId))
            {
                query = query.Where(nh => nh.NhaCungCap == supplierId);
            }

            return query.ToList();
        }


    }
}
