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
using ClosedXML.Excel;

namespace GUI.Warehouse
{
    public partial class FormWarehouseList : Form
    {
        private WarehouseBLL warehouseBLL;
        private CategoryBLL categoryBLL;
        public FormWarehouseList()
        {
            InitializeComponent();
            warehouseBLL = new WarehouseBLL();
            categoryBLL = new CategoryBLL();
        }
       
        private void FormWarehouseList_Load(object sender, EventArgs e)
        {
            LoadWarehouseData();

            dgv_warehouse.ColumnHeadersHeight = 40;
            dgv_warehouseDetail.ColumnHeadersHeight = 40;

            if (dgv_warehouseDetail.Columns.Count > 3)
            {
               
            }

            var ncc = categoryBLL.getAll_NCC();
            cbb_NCC.Items.Clear();

            if (ncc != null && ncc.Any())
            {
                cbb_NCC.DataSource = ncc;
                cbb_NCC.DisplayMember = "TenNhaCungCap";
                cbb_NCC.ValueMember = "TenNhaCungCap";
            }
            cbb_NCC.SelectedIndex = -1;

        }

        private void dgv_warehouse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           try
            {
                if (e.RowIndex >= 0)
                {
                    int warehouseId = Convert.ToInt32(dgv_warehouse.Rows[e.RowIndex].Cells["MaNhapHang"].Value);
                    LoadWarehouseDetails(warehouseId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading warehouse details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadWarehouseDetails(int warehouseId)
        {

            try
            {
                List<ChiTietNhapHang> warehouseDetails = warehouseBLL.GetWarehouseDetailByWarehouse(warehouseId);
                dgv_warehouseDetail.DataSource = warehouseDetails;
                dgv_warehouseDetail.Columns[6].Visible = false;
                dgv_warehouseDetail.Columns[7].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading warehouse details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgv_warehouseDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void LoadWarehouseData()
        {
            try
            {
                List<NhapHang> warehouses = warehouseBLL.GetAllInvoices();
                dgv_warehouse.DataSource = warehouses;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading warehouse data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ExportToExcel_Click(object sender, EventArgs e)
        {
            try
            {
                var workbook = new XLWorkbook();
                var worksheet = workbook.Worksheets.Add("Warehouse Data");

                for (int col = 0; col < dgv_warehouse.Columns.Count; col++)
                {
                    var headerCell = worksheet.Cell(1, col + 1);
                    headerCell.Value = dgv_warehouse.Columns[col].HeaderText;
                    headerCell.Style.Fill.SetBackgroundColor(XLColor.Amber); 
                    headerCell.Style.Font.Bold = true; 
                    headerCell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center; 
                    headerCell.Style.Border.BottomBorder = XLBorderStyleValues.Thin; 
                }

                for (int row = 0; row < dgv_warehouse.Rows.Count; row++)
                {
                    for (int col = 0; col < dgv_warehouse.Columns.Count; col++)
                    {
                        var cell = worksheet.Cell(row + 2, col + 1);
                        var cellValue = dgv_warehouse.Rows[row].Cells[col].Value?.ToString() ?? ""; 
                        cell.Value = cellValue;

                        cell.Style.Border.TopBorder = XLBorderStyleValues.Thin;
                        cell.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                        cell.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                        cell.Style.Border.RightBorder = XLBorderStyleValues.Thin;

                        cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        cell.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                    }
                }
                worksheet.Columns().AdjustToContents();

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("Data exported successfully!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting to Excel: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void guna2DateTimePicker_end_ValueChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void guna2DateTimePicker_Start_ValueChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void cbb_NCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void FilterData()
        {
            DateTime startDate = guna2DateTimePicker_Start.Value.Date;
            DateTime endDate = guna2DateTimePicker_end.Value.Date;
            var selectedSupplier = cbb_NCC.SelectedItem as NhaCungCap;


            try
            {
                List<NhapHang> filteredWarehouses;
                if (selectedSupplier != null)
                {
                    string supplierId = selectedSupplier.TenNhaCungCap;  
                    filteredWarehouses = warehouseBLL.GetFilteredInvoices(startDate, endDate, supplierId);
                }
                else
                {
                    filteredWarehouses = warehouseBLL.GetFilteredInvoices(startDate, endDate);
                }

                dgv_warehouse.DataSource = filteredWarehouses; 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error filtering data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_reset_Click(object sender, EventArgs e)
        {
            guna2DateTimePicker_Start.Value = DateTime.Now;
            guna2DateTimePicker_end.Value = DateTime.Now;
            cbb_NCC.SelectedIndex = -1; 

            LoadWarehouseData();
        }

        private void btn_loc_Click(object sender, EventArgs e)
        {
            FilterData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
