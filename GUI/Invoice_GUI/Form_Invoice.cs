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
using Guna.UI2.WinForms;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;

namespace GUI.Invoice_GUI
{
    public partial class Form_Invoice : Form
    {
        private InvoiceBLL invoiceBLL;
        public Form_Invoice()
        {
            InitializeComponent();
            invoiceBLL = new InvoiceBLL();
        }

        private void Form_Invoice_Load(object sender, EventArgs e)
        {
            LoadInvoices();
            LoadCategory();
        }

        private void LoadInvoices()
        {
            try
            {
                var invoices = invoiceBLL.getAllInvoice();
                dgv_invoice.DataSource = invoices;
                dgv_invoice.ColumnHeadersHeight = 40;
                dgv_invoice.Columns[6].Visible = false;
                dgv_invoice.Columns[5].Visible = false;
                //dgv_invoice.Columns[9].Visible = false;
                dgv_invoice.Columns[11].Visible = false;
                dgv_invoice.Columns[12].Visible = false;
                dgv_invoice.Columns[13].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải hóa đơn: " + ex.Message);
            }
        }

        private void LoadCategory()
        {
            guna2ComboBox1.Items.Clear();
            guna2ComboBox1.Items.Add("Ðã đặt hàng");
            guna2ComboBox1.Items.Add("Đã xác nhận");
            guna2ComboBox1.Items.Add("Đang giao");
            guna2ComboBox1.Items.Add("Đã giao");
            guna2ComboBox1.Items.Add("Đã hủy");

            guna2ComboBox1.SelectedIndex = 0;

            cbb_order.Items.Clear();
            cbb_order.Items.Add("Ðã đặt hàng");
            cbb_order.Items.Add("Đã xác nhận");
            cbb_order.Items.Add("Đang giao");
            cbb_order.Items.Add("Đã giao");
            cbb_order.Items.Add("Đã hủy");
            
            cbb_Payment.Items.Clear();
            cbb_Payment.Items.Add("Đã Thanh Toán");
            cbb_Payment.Items.Add("Chưa thanh toán");
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStatus = guna2ComboBox1.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedStatus))
            {
                MessageBox.Show("Vui lòng chọn trạng thái đơn hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                List<donhang> invoiceList = invoiceBLL.getAllInvoice();

                if (invoiceList == null || !invoiceList.Any())
                {
                    MessageBox.Show("Không có hóa đơn nào để lọc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var filteredInvoices = invoiceList.Where(invoice => invoice.TrangThaiDonHang == selectedStatus).ToList();

                if (!filteredInvoices.Any())
                {
                    MessageBox.Show("Không có hóa đơn nào với trạng thái này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dgv_invoice.DataSource = filteredInvoices;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lọc hóa đơn theo trạng thái: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btn_UpdateInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra người dùng đã chọn hóa đơn nào trong DataGridView chưa
                if (dgv_invoice.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn một hóa đơn để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy dữ liệu từ các ô được chọn trong DataGridView
                var selectedRow = dgv_invoice.SelectedRows[0];
                var updatedInvoice = new donhang
                {
                    MaDonHang = int.Parse(txtOrderID.Text),
                    //NgayDuKienGiaoHang = dtpNgayDuKien.Value,
                    //TongTienSauKhiGiamGia = decimal.Parse(txtTongTienSauGiamGia.Text.Trim()),
                    //PhiVanChuyen = decimal.Parse(txtPhiVanChuyen.Text.Trim()),
                    TrangThaiThanhToan = cbb_Payment.SelectedItem.ToString(),
                    //HinhThucThanhToan = txtHinhThucThanhToan.Text.Trim(),
                    TrangThaiDonHang = cbb_order.SelectedItem.ToString(),
                    //DiaChiGiaoHang = txtDiaChi.Text.Trim(),
                    //MaVoucher = txtMaVoucher.Text.Trim(),
                    //RecipientPhone = txtPhone.Text.Trim()
                };

                // Gọi phương thức Update từ BLL
                bool isUpdated = invoiceBLL.UpdateInvoice(updatedInvoice);

                if (isUpdated)
                {
                    MessageBox.Show("Cập nhật hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadInvoices(); // Tải lại danh sách hóa đơn sau khi cập nhật
                }
                else
                {
                    MessageBox.Show("Cập nhật hóa đơn không thành công. Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_invoice_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_invoice.Rows[e.RowIndex];

                txtOrderID.Text = row.Cells["MaDonHang"].Value?.ToString() ?? string.Empty;
                txt_Phone.Text = row.Cells["RecipientPhone"].Value?.ToString() ?? string.Empty;
                txt_address.Text = row.Cells["DiaChiGiaoHang"].Value?.ToString() ?? string.Empty;

                if (dgv_invoice.Columns.Contains("MaVoucher"))
                {
                    txt_Voucher.Text = row.Cells["MaVoucher"]?.Value?.ToString() ?? string.Empty;
                }
                else
                {
                    txt_Voucher.Text = string.Empty;
                }

                txt_AmoutPrice.Text = row.Cells["TongGia"]?.Value?.ToString() ?? string.Empty;

                if (dgv_invoice.Columns.Contains("PhiVanChuyen"))
                {
                    txt_PriceShipp.Text = row.Cells["PhiVanChuyen"]?.Value?.ToString() ?? string.Empty;
                }
                else
                {
                    txt_PriceShipp.Text = string.Empty;
                }



                if (cbb_order.Items.Contains(row.Cells["TrangThaiDonHang"].Value?.ToString()))
                {
                    cbb_order.SelectedItem = row.Cells["TrangThaiDonHang"].Value?.ToString();
                }
                else
                {
                    cbb_order.SelectedIndex = -1;
                }

                if (cbb_Payment.Items.Contains(row.Cells["TrangThaiThanhToan"].Value?.ToString()))
                {
                    cbb_Payment.SelectedItem = row.Cells["TrangThaiThanhToan"].Value?.ToString();
                }
                else
                {
                    cbb_Payment.SelectedIndex = -1;
                }



            }

            // Lấy ID hóa đơn để hiển thị chi tiết
            int invoiceID = int.Parse(txtOrderID.Text);
            ShowInvoiceDetails(invoiceID);
        }
        private void dgv_InvoiceDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ShowInvoiceDetails(int invoiceID)
        {
            try
            {
                // Gọi BLL để lấy chi tiết hóa đơn
                var invoiceDetails = invoiceBLL.getInvoiceDetailByIDInvoice(invoiceID);

                if (invoiceDetails != null && invoiceDetails.Any())
                {
                    dgv_InvoiceDetail.DataSource = invoiceDetails;

                }
                else
                {
                    dgv_InvoiceDetail.DataSource = null;
                    MessageBox.Show("Không có chi tiết nào cho hóa đơn này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải chi tiết hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }


        private void textBox_Search_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox_Search.Text.Trim();
            try
            {
                if (string.IsNullOrEmpty(searchText))
                {
                    LoadInvoices();
                    return;
                }

                if (dgv_invoice.DataSource is List<donhang> invoiceList)
                {
                    var filteredInvoices = invoiceList.Where(invoice =>
                        (invoice.RecipientPhone != null && invoice.RecipientPhone.Contains(searchText)) ||
                        (invoice.DiaChiGiaoHang != null && invoice.DiaChiGiaoHang.Contains(searchText))
                    ).ToList();

                    dgv_invoice.DataSource = filteredInvoices;
                }
                else
                {
                    MessageBox.Show("Dữ liệu không phải là List<donhang>.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm hóa đơn: " + ex.Message);
            }
        }






        private void guna2DateTimePicker_To_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_FilterByDate_Click(object sender, EventArgs e)
        {
            DateTime fromDate = guna2DateTimePicker_From.Value.Date;
            DateTime toDate = guna2DateTimePicker_To.Value.Date;

            if (fromDate > toDate)
            {
                MessageBox.Show("Ngày bắt đầu không thể lớn hơn ngày kết thúc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var filteredInvoices = invoiceBLL.ShowInvoicesByDateRange(fromDate, toDate);
                dgv_invoice.DataSource = filteredInvoices;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lọc hóa đơn theo thời gian: " + ex.Message);
            }
        }
        private void btn_ExportToExcel_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu đã lọc từ DataGridView
                var filteredInvoices = dgv_invoice.DataSource as List<donhang>;

                if (filteredInvoices == null || !filteredInvoices.Any())
                {
                    MessageBox.Show("Không có dữ liệu để xuất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Tạo workbook và worksheet mới
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Invoices");

                    // Thêm tiêu đề cột từ DataGridView (bao gồm cả cột ẩn)
                    for (int colIndex = 0; colIndex < dgv_invoice.Columns.Count; colIndex++)
                    {
                        // Lấy tên cột bất kể cột có hiển thị hay không
                        worksheet.Cell(1, colIndex + 1).Value = dgv_invoice.Columns[colIndex].HeaderText;
                    }

                    // Thêm dữ liệu vào worksheet
                    for (int i = 0; i < filteredInvoices.Count; i++)
                    {
                        var invoice = filteredInvoices[i];
                        for (int colIndex = 0; colIndex < dgv_invoice.Columns.Count; colIndex++)
                        {
                            var columnName = dgv_invoice.Columns[colIndex].Name;
                            var value = invoice.GetType().GetProperty(columnName)?.GetValue(invoice, null);

                            // Chuyển giá trị của 'value' thành kiểu dữ liệu tương thích với Excel
                            if (value != null)
                            {
                                if (value is DateTime)
                                {
                                    worksheet.Cell(i + 2, colIndex + 1).Value = (DateTime)value;
                                }
                                else if (value is int)
                                {
                                    worksheet.Cell(i + 2, colIndex + 1).Value = (int)value;
                                }
                                else if (value is decimal)
                                {
                                    worksheet.Cell(i + 2, colIndex + 1).Value = (decimal)value;
                                }
                                else
                                {
                                    worksheet.Cell(i + 2, colIndex + 1).Value = value.ToString();
                                }
                            }
                            else
                            {
                                worksheet.Cell(i + 2, colIndex + 1).Value = string.Empty; // Nếu giá trị là null thì gán ô trống
                            }
                        }
                    }

                    // Định dạng cột cho dễ đọc
                    worksheet.Columns().AdjustToContents();

                    // Lưu file Excel
                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "Excel Files|*.xlsx",
                        Title = "Lưu Hóa Đơn Dưới Dạng Excel"
                    };

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        workbook.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Dữ liệu đã được xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất file Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void btn_ExportToExcel_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        // Lấy dữ liệu đã lọc từ DataGridView
        //        var filteredInvoices = dgv_invoice.DataSource as List<donhang>;

        //        if (filteredInvoices == null || !filteredInvoices.Any())
        //        {
        //            MessageBox.Show("Không có dữ liệu để xuất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            return;
        //        }

        //        // Tạo workbook và worksheet mới
        //        using (var workbook = new XLWorkbook())
        //        {
        //            var worksheet = workbook.Worksheets.Add("Invoices");

        //            // Thêm tiêu đề cột
        //            worksheet.Cell(1, 1).Value = "Mã Đơn Hàng";
        //            worksheet.Cell(1, 2).Value = "Mã Khách Hàng";
        //            worksheet.Cell(1, 3).Value = "Số Điện Thoại";
        //            worksheet.Cell(1, 4).Value = "Địa Chỉ Giao Hàng";
        //            worksheet.Cell(1, 5).Value = "Trạng Thái Đơn Hàng";
        //            worksheet.Cell(1, 6).Value = "Ngày Đặt Hàng";
        //            worksheet.Cell(1, 7).Value = "Tổng Giá";

        //            // Thêm dữ liệu vào worksheet
        //            for (int i = 0; i < filteredInvoices.Count; i++)
        //            {
        //                var invoice = filteredInvoices[i];
        //                worksheet.Cell(i + 2, 1).Value = invoice.MaDonHang;
        //                worksheet.Cell(i + 2, 2).Value = invoice.MaKhachHang;
        //                worksheet.Cell(i + 2, 3).Value = invoice.RecipientPhone;
        //                worksheet.Cell(i + 2, 4).Value = invoice.DiaChiGiaoHang;
        //                worksheet.Cell(i + 2, 5).Value = invoice.TrangThaiDonHang;
        //                worksheet.Cell(i + 2, 6).Value = invoice.NgayDat;
        //                worksheet.Cell(i + 2, 7).Value = invoice.TongGia;
        //            }

        //            // Định dạng cột cho dễ đọc
        //            worksheet.Columns().AdjustToContents();

        //            // Lưu file Excel
        //            SaveFileDialog saveFileDialog = new SaveFileDialog
        //            {
        //                Filter = "Excel Files|*.xlsx",
        //                Title = "Lưu Hóa Đơn Dưới Dạng Excel"
        //            };

        //            if (saveFileDialog.ShowDialog() == DialogResult.OK)
        //            {
        //                workbook.SaveAs(saveFileDialog.FileName);
        //                MessageBox.Show("Dữ liệu đã được xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi khi xuất file Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void btn_ResetFilter_Click(object sender, EventArgs e)
        {
            try
            {
                LoadInvoices(); // Hàm hiển thị tất cả hóa đơn
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi làm mới danh sách hóa đơn: " + ex.Message);
            }
        }


        private void cbb_order_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbb_Payment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void txt_address_TextChanged(object sender, EventArgs e)
        {

        }

 

        private void txt_Voucher_TextChanged(object sender, EventArgs e)
        {

        }

  
        private void txt_AmoutPrice_TextChanged(object sender, EventArgs e)
        {

        }

  
        private void txt_PriceShipp_TextChanged(object sender, EventArgs e)
        {

        }

   

        private void txt_OrderStatus_TextChanged(object sender, EventArgs e)
        {
                    }

  

        private void txt_Payment_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOrderID_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbb_Payment_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker_From_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
