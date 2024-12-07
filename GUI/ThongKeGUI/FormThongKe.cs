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
using System.Windows.Forms.DataVisualization.Charting;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Runtime.InteropServices.ComTypes;

namespace GUI.ThongKeGUI
{
    public partial class FormThongKe : Form
    {
        private InvoiceBLL invoiceBLL;
        public FormThongKe()
        {
            InitializeComponent();
            invoiceBLL = new InvoiceBLL();
            LoadInvoices();
            LoadCategory();
            guna2ComboBox1.SelectedIndexChanged += Guna2ComboBox1_SelectedIndexChanged;
            LoadInvoicesWithChart();


        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            //LoadInvoices();
            //LoadCategory();
            //guna2ComboBox1.SelectedIndexChanged += Guna2ComboBox1_SelectedIndexChanged;
        }

        private void Guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStatus = guna2ComboBox1.SelectedItem.ToString().Trim();

            // Kiểm tra và lọc theo trạng thái thanh toán
            if (selectedStatus == "Ðã Thanh Toán")
            {
                LoadInvoices("Ðã Thanh Toán");
            }
            else if (selectedStatus == "Chua thanh toán")
            {
                LoadInvoices("Chua thanh toán");
            }
            else if (selectedStatus == "Tất cả")
            {
                // Nếu không có lựa chọn, tải lại tất cả hóa đơn
                LoadInvoices();
            }
        }

        private void LoadInvoices(string paymentStatus = null)
        {
            try
            {
                // Lấy dữ liệu từ phương thức getAllHoaDon và chọn các trường cần thiết
                var invoices = invoiceBLL.getAllHoaDon()
                                          .Select(invoice => new
                                          {
                                              invoice.MaDonHang,
                                              invoice.MaKhachHang,
                                              invoice.NgayDat,
                                              TongGia = invoice.TongGia ?? 0,  // Giả sử TongGia có thể null
                                              invoice.TrangThaiThanhToan
                                          }).ToList();

                // Nếu có trạng thái thanh toán được chỉ định, lọc dữ liệu theo trạng thái đó
                if (!string.IsNullOrEmpty(paymentStatus))
                {
                    invoices = invoices.Where(invoice =>
                        !string.IsNullOrEmpty(invoice.TrangThaiThanhToan) &&
                        invoice.TrangThaiThanhToan.Trim().Equals(paymentStatus, StringComparison.OrdinalIgnoreCase)
                    ).ToList();
                }

                // Chuyển dữ liệu từ kiểu ẩn danh thành kiểu DTO.donhang
                var result = invoices.Select(invoice => new DTO.donhang
                {
                    MaDonHang = invoice.MaDonHang,
                    MaKhachHang = invoice.MaKhachHang,
                    NgayDat = invoice.NgayDat,
                    TongGia = invoice.TongGia,
                    TrangThaiThanhToan = invoice.TrangThaiThanhToan
                }).ToList();

                // Gán dữ liệu vào DataGridView
                dgv_thongke.DataSource = result;
                dgv_thongke.ColumnHeadersHeight = 40;

                // Chỉ giữ lại các cột bạn muốn hiển thị (Ẩn các cột không cần thiết)
                dgv_thongke.Columns["MaDonHang"].Visible = true;
                dgv_thongke.Columns["MaKhachHang"].Visible = true;
                dgv_thongke.Columns["NgayDat"].Visible = true;
                dgv_thongke.Columns["TongGia"].Visible = true;
                dgv_thongke.Columns["TrangThaiThanhToan"].Visible = true;

                // Ẩn các cột không cần thiết, ví dụ cột không có trong dữ liệu
                foreach (DataGridViewColumn column in dgv_thongke.Columns)
                {
                    if (column.Index != dgv_thongke.Columns["MaDonHang"].Index &&
                        column.Index != dgv_thongke.Columns["MaKhachHang"].Index &&
                        column.Index != dgv_thongke.Columns["NgayDat"].Index &&
                        column.Index != dgv_thongke.Columns["TongGia"].Index &&
                        column.Index != dgv_thongke.Columns["TrangThaiThanhToan"].Index)
                    {
                        column.Visible = false;
                    }
                }

                // Tính tổng giá trị của cột TongGia và hiển thị vào txt_AmoutPrice
                UpdateAmountPrice(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải hóa đơn: " + ex.Message);
            }
        }

        //    UpdateAmountPrice(invoices);

        private void LoadCategory()
        {
            guna2ComboBox1.Items.Clear();
            guna2ComboBox1.Items.Add("Tất cả");
            guna2ComboBox1.Items.Add("Ðã Thanh Toán"); // Chú ý chính tả, dấu trong "Ðã Thanh Toán"
            guna2ComboBox1.Items.Add("Chua thanh toán");

            // Chọn mặc định là "Ðã Thanh Toán"
            guna2ComboBox1.SelectedIndex = 0;

            //        guna2ComboBox1.SelectedIndex = 0;

            //cbb_order.Items.Clear();
            //cbb_order.Items.Add("Ðã đặt hàng");
            //cbb_order.Items.Add("Đã xác nhận");
            //cbb_order.Items.Add("Đang giao");
            //cbb_order.Items.Add("Đã giao");
            //cbb_order.Items.Add("Đã hủy");

            //cbb_Payment.Items.Clear();
            //cbb_Payment.Items.Add("Đã Thanh Toán");
            //cbb_Payment.Items.Add("Chưa thanh toán");
        }


        private void btn_ResetFilter_Click(object sender, EventArgs e)
        {
            textBox_Search.Clear(); // Xóa từ khóa tìm kiếm
            guna2ComboBox1.SelectedIndex = 0; // Chọn lại tháng mặc định (ví dụ tháng đầu tiên trong danh sách)

            LoadInvoices(); // Lấy lại tất cả hóa đơn
        }

        private void textBox_Search_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox_Search.Text.Trim();
            string selectedStatus = guna2ComboBox1.SelectedItem?.ToString().Trim();

            try
            {
                if (string.IsNullOrEmpty(searchText) && string.IsNullOrEmpty(selectedStatus))
                {
                    LoadInvoices();
                    return;
                }

                if (dgv_thongke.DataSource is List<donhang> invoiceList)
                {
                    var filteredInvoices = invoiceList.Where(invoice =>
                        (string.IsNullOrEmpty(selectedStatus) || invoice.TrangThaiThanhToan.Contains(selectedStatus)) &&
                        (string.IsNullOrEmpty(searchText) ||
                         (invoice.RecipientPhone != null && invoice.RecipientPhone.Contains(searchText)) ||
                         (invoice.DiaChiGiaoHang != null && invoice.DiaChiGiaoHang.Contains(searchText))
                        )
                    ).ToList();

                    dgv_thongke.DataSource = filteredInvoices;

                    // Tính tổng giá trị của cột TongGia và hiển thị vào txt_AmoutPrice
                    UpdateAmountPrice(filteredInvoices);
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

        private void guna2DateTimePicker_From_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_FilterByDate_Click(object sender, EventArgs e)
        {
            DateTime fromDate = guna2DateTimePicker_From.Value.Date;
            DateTime toDate = guna2DateTimePicker_To.Value.Date;
            string selectedStatus = guna2ComboBox1.SelectedItem?.ToString().Trim(); // Lấy trạng thái thanh toán từ ComboBox

            if (fromDate > toDate)
            {
                MessageBox.Show("Ngày bắt đầu không thể lớn hơn ngày kết thúc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                List<donhang> filteredInvoices;

                // Kiểm tra xem có trạng thái nào được chọn không
                if (selectedStatus == "Tất cả")
                {
                    // Nếu "Tất cả" được chọn, chỉ lọc theo thời gian
                    filteredInvoices = invoiceBLL.ShowInvoicesByDateRange(fromDate, toDate);

                }
                else
                {
                    // Nếu có trạng thái cụ thể, lọc theo thời gian và trạng thái thanh toán
                    filteredInvoices = invoiceBLL.ShowInvoicesByDateRangeAndStatus(fromDate, toDate, selectedStatus);
                }

                dgv_thongke.DataSource = filteredInvoices;


                // Tính tổng giá trị của cột TongGia và hiển thị vào txt_AmoutPrice
                UpdateAmountPrice(filteredInvoices);

                // Cập nhật lại biểu đồ theo dữ liệu lọc được
                LoadInvoicesWithChart(fromDate, toDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lọc hóa đơn theo thời gian và trạng thái: " + ex.Message);
            }
        }

        private void btn_ExportToExcel_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu đã lọc từ DataGridView
                var filteredInvoices = dgv_thongke.DataSource as List<donhang>;

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
                    for (int colIndex = 0; colIndex < dgv_thongke.Columns.Count; colIndex++)
                    {
                        // Lấy tên cột bất kể cột có hiển thị hay không
                        worksheet.Cell(1, colIndex + 1).Value = dgv_thongke.Columns[colIndex].HeaderText;
                    }

                    // Thêm dữ liệu vào worksheet
                    for (int i = 0; i < filteredInvoices.Count; i++)
                    {
                        var invoice = filteredInvoices[i];
                        for (int colIndex = 0; colIndex < dgv_thongke.Columns.Count; colIndex++)
                        {
                            var columnName = dgv_thongke.Columns[colIndex].Name;
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void UpdateAmountPrice(List<donhang> invoices)
        {
            // Tính tổng giá trị của cột TongGia, sử dụng giá trị mặc định 0 nếu TongGia là null
            decimal totalAmount = invoices.Sum(invoice => invoice.TongGia ?? 0);

            // Cập nhật giá trị vào txt_AmoutPrice
            txt_AmoutPrice.Text = totalAmount.ToString("C"); // Định dạng tiền tệ
        }

        private void LoadInvoicesWithChart(DateTime? startDate = null, DateTime? endDate = null)
        {
            try
            {
                // Lấy tất cả hóa đơn
                var invoices = invoiceBLL.getAllHoaDon()
                    .Select(invoice => new
                    {
                        invoice.NgayDat,  // Ngày đặt hóa đơn
                        TongGia = invoice.TongGia ?? 0  // Kiểm tra giá trị hợp lệ cho tổng giá
                    }).ToList();

                // Kiểm tra nếu không có dữ liệu
                if (invoices == null || !invoices.Any())
                {
                    MessageBox.Show("Không có dữ liệu hóa đơn.");
                    return;
                }

                // Lọc theo khoảng thời gian nếu có
                if (startDate.HasValue)
                {
                    invoices = invoices.Where(invoice => invoice.NgayDat >= startDate.Value).ToList();
                }
                if (endDate.HasValue)
                {
                    invoices = invoices.Where(invoice => invoice.NgayDat <= endDate.Value).ToList();
                }

                // Kiểm tra lại dữ liệu sau khi lọc
                if (!invoices.Any())
                {
                    MessageBox.Show("Không có hóa đơn thỏa mãn điều kiện lọc.");
                    return;
                }

                // Tổng hợp dữ liệu theo ngày
                var groupedData = invoices
                 .Where(invoice => invoice.NgayDat.HasValue)  // Đảm bảo NgayDat có giá trị
                 .GroupBy(invoice => invoice.NgayDat.Value.Date)  // Lấy chỉ phần ngày (Date) của NgayDat
                 .Select(group => new
                 {
                     Date = group.Key,  // Ngày
                     TotalAmount = group.Sum(invoice => invoice.TongGia)  // Tổng tiền của các hóa đơn trong ngày
                 }).OrderBy(data => data.Date)  // Sắp xếp theo ngày
                 .ToList();


                // Cập nhật biểu đồ
                chartThongKe.Series.Clear();

                // Tạo và thêm series mới vào biểu đồ
                var series = new Series("Tổng Tiền Hóa Đơn")
                {
                    ChartType = SeriesChartType.Line,  // Chọn kiểu biểu đồ Line
                    BorderWidth = 3                    // Tùy chọn độ dày đường biểu đồ
                };

                // Gắn dữ liệu vào series
                var xValues = groupedData.Select(data => data.Date).ToList();  // Lấy ngày là trục X
                var yValues = groupedData.Select(data => data.TotalAmount).ToList();  // Lấy tổng tiền là trục Y

                if (xValues.Any() && yValues.Any())
                {
                    series.Points.DataBindXY(xValues, yValues);  // Gắn dữ liệu vào biểu đồ
                }
                else
                {
                    MessageBox.Show("Dữ liệu không hợp lệ hoặc không có dữ liệu để hiển thị.");
                    return;
                }

                // Thêm series vào biểu đồ
                chartThongKe.Series.Add(series);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu cho biểu đồ: " + ex.Message);
            }
        }


    }
}
