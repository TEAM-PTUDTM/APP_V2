using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI.UserGUI
{
    public partial class FormUser : Form
    {
        EmployeeBLL NVbll = new EmployeeBLL();
        private int id;
        private string name;
        private bool role;
        private bool status;
        public FormUser()
        {
            InitializeComponent();
            this.Load += FormUser_Load;
            this.btnInsert.Click += BtnInsert_Click;
            this.gvEmployee.CellClick += GvEmployee_CellClick;
            this.btnUpdate.Click += BtnUpdate_Click;
            this.btnDelete.Click += BtnDelete_Click;
            this.btnRefresh.Click += BtnRefresh_Click;
            this.txtSearch.TextChanged += TxtSearch_TextChanged;
            this.Shown += FormUser_Shown;
        }

        private void FormUser_Shown(object sender, EventArgs e)
        {
            txtName.Focus();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            name = txtSearch.Text.Trim();
            if (name == "")
            {
                FormUser_Load(sender, e);
                txtSearch.Focus();
            }
            else
            {
                DataTable data = NVbll.SearchEmployee(name);
                gvEmployee.DataSource = data;
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            txtMatkhau.Enabled = true;
            SetValue(true, false);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            id = int.Parse(gvEmployee.CurrentRow.Cells[0].Value.ToString());
            if (NVbll.DeleteEmployee(id))
            {
                SetValue(true, false);
                gvEmployee.DataSource = NVbll.ListOfEmployees();
                LoadGridView();
            }
            else
                MsgBox("Xóa nhân viên không thành công", true);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            txtMatkhau.Enabled = false;
            if (txtAddress.Text != "" && txtEmail.Text != "" && txtName.Text != ""
               && txtPhoneNumber.Text != "")
            {
                role = radAdmin.Checked;
                status = radActive.Checked;
                NhanVien dtoEmployee = new NhanVien(txtName.Text, txtAddress.Text, txtPhoneNumber.Text, txtEmail.Text, role, status);
                if (NVbll.UpdateEmployee(ConvertToDTO(dtoEmployee)))
                {
                    SetValue(true, false);
                    gvEmployee.DataSource = NVbll.ListOfEmployees();
                    LoadGridView();
                }
                else
                    MsgBox("Sửa nhân viên không thành công!", true);
            }
            else MsgBox("Thiếu trường thông tin!", true);
        }

        private void GvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMatkhau.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            radNonActive.Enabled = true;
            radActive.Enabled = true;
            radEmployee.Enabled = true;
            radAdmin.Enabled = true;
            txtEmail.ReadOnly = true;
            txtName.Text = gvEmployee.CurrentRow.Cells[1].Value.ToString();
            txtAddress.Text = gvEmployee.CurrentRow.Cells[2].Value.ToString();
            txtPhoneNumber.Text = gvEmployee.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = gvEmployee.CurrentRow.Cells[4].Value.ToString();
            role = bool.Parse(gvEmployee.CurrentRow.Cells[6].Value.ToString());
            status = bool.Parse(gvEmployee.CurrentRow.Cells[7].Value.ToString());
            if (role)
                radAdmin.Checked = true;
            else
                radEmployee.Checked = true;
            if (status)
                radActive.Checked = true;
            else
                radNonActive.Checked = true;
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text != "" && txtEmail.Text != "" && txtName.Text != ""
                && txtPhoneNumber.Text != "" && txtMatkhau.Text != "")
            {
                if (IsValidEmail(txtEmail.Text))
                {
                    role = radAdmin.Checked;
                    status = radActive.Checked;
                    NhanVien dtoEmployee = new NhanVien(txtName.Text, txtAddress.Text, txtPhoneNumber.Text, txtEmail.Text, role, status, txtMatkhau.Text);
                    if (NVbll.InsertEmployee(ConvertToDTO(dtoEmployee)))
                    {
                        SetValue(false, true);
                        gvEmployee.DataSource = NVbll.ListOfEmployees();
                        LoadGridView();
                    }
                    else
                        MsgBox("Không thêm nhân viên được!", true);
                }
                else MsgBox("Email không đúng định dạng!", true);
            }
            else MsgBox("Thiếu trường thông tin!", true);
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            gvEmployee.DataSource = NVbll.ListOfEmployees();
            LoadGridView();
            SetValue(true, false);
            txtName.Focus();
        }

        private void LoadGridView()
        {
            gvEmployee.Columns[0].HeaderText = "Mã nhân viên";
            gvEmployee.Columns[1].HeaderText = "Họ tên";
            gvEmployee.Columns[2].HeaderText = "Địa chỉ";
            gvEmployee.Columns[3].HeaderText = "Số điện thoại";
            gvEmployee.Columns[4].HeaderText = "Email";
            gvEmployee.Columns[5].HeaderText = "Mật khẩu";
            gvEmployee.Columns[6].HeaderText = "Vai trò";
            gvEmployee.Columns[7].HeaderText = "Tình trạng";
            foreach (DataGridViewColumn item in gvEmployee.Columns)
            {
                item.DividerWidth = 1;
            }
            gvEmployee.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gvEmployee.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
        private void SetValue(bool param, bool isLoad)
        {
            txtEmail.ReadOnly = false;
            txtEmail.Text = null;
            txtAddress.Text = null;
            txtPhoneNumber.Text = null;
            btnInsert.Enabled = param;
            txtName.Text = null;
            txtMatkhau.Text = null;
            radActive.Enabled = param;
            radNonActive.Enabled = param;
            radEmployee.Enabled = param;
            radAdmin.Enabled = param;
            txtName.Focus();
            if (isLoad)
            {
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                btnUpdate.Enabled = !param;
                btnDelete.Enabled = !param;
            }
            radEmployee.Checked = true;
            radActive.Checked = true;
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                MailAddress mail = new MailAddress(email);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void MsgBox(string message, bool isError = false)
        {
            if (isError)
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public class NhanVien
        {
            public int Id { get; set; } // ID tự động tăng, không cần truyền vào
            public string Name { get; set; }
            public string Address { get; set; }
            public string PhoneNumber { get; set; }
            public string Email { get; set; }
            public bool Role { get; set; }
            public bool Status { get; set; }
            public string Password { get; set; }

            // Constructor không có Id, vì Id tự động tăng
            public NhanVien(string name, string address, string phoneNumber, string email, bool role, bool status, string password)
            {
                Name = name;
                Address = address;
                PhoneNumber = phoneNumber;
                Email = email;
                Role = role;
                Status = status;
                Password = password;
            }
            public NhanVien(string name, string address, string phoneNumber, string email, bool role, bool status)
            {
                Name = name;
                Address = address;
                PhoneNumber = phoneNumber;
                Email = email;
                Role = role;
                Status = status;
            }
        }
        public DTO.NhanVien ConvertToDTO(GUI.UserGUI.FormUser.NhanVien guiNhanVien)
        {
            return new DTO.NhanVien
            {
                // Chuyển các thuộc tính của NhanVien từ GUI sang DTO
                Id = guiNhanVien.Id,
                Name = guiNhanVien.Name,
                Address = guiNhanVien.Address,
                PhoneNumber = guiNhanVien.PhoneNumber,
                Email = guiNhanVien.Email,
                Password = guiNhanVien.Password,
                Role = guiNhanVien.Role,
                Status = guiNhanVien.Status
            };
        }
    }
}
