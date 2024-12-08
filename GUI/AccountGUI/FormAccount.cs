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

namespace GUI.AccountGUI
{
    public partial class FormAccount : Form
    {
        EmployeeBLL NVbll = new EmployeeBLL();
        private string email, str;
        private string[] strlist;
        public FormAccount(string email)
        {
            InitializeComponent();
            this.email = email;
            this.btnChangePassword.Click += BtnChangePassword_Click;
            this.btnUpdate.Click += BtnUpdate_Click;
            this.btnRefresh.Click += BtnRefresh_Click;
            this.Load += FormAccount_Load;
        }

        private void FormAccount_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            NhanVien dtoEmployee = new NhanVien(txtAddress.Text, txtPhoneNumber.Text, txtEmail.Text);
            if (NVbll.UpdateEmployeeAddressPhoneNumber(ConvertToDTO(dtoEmployee)))
            {
                MessageBox.Show("Sửa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không sửa được thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            if (txtOldPassword.Text != "")
            {
                if (txtNewPassword.Text == txtRepeatPassword.Text)
                {
                    if (NVbll.ChangePassword(txtEmail.Text, txtOldPassword.Text, txtNewPassword.Text))
                    {
                        MessageBox.Show("Đổi mật khẩu thành công, vui lòng đăng nhập lại.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Properties.Settings.Default.password = "";
                        Properties.Settings.Default.Save();
                        Application.Restart();
                    }
                    else MessageBox.Show("Mật khẩu cũ không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Mật khẩu mới không trùng nhau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Vui lòng nhập mật khẩu cũ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LoadData()
        {
            str = NVbll.GetEmployeeIdName(email);
            if (string.IsNullOrEmpty(str))
            {
                MessageBox.Show("Không thể lấy thông tin ID và Tên nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int indexOfDash = str.IndexOf('-');
            if (indexOfDash > -1 && indexOfDash + 1 < str.Length)
            {
                // Lấy phần tên sau dấu "-"
                txtName.Text = str.Substring(indexOfDash + 1).Trim();
            }
            else
            {
                MessageBox.Show("Dữ liệu trả về không hợp lệ (không tìm thấy ký tự '-').", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            str = NVbll.GetEmployeeAddressPhoneNumber(email);
            if (string.IsNullOrEmpty(str))
            {
                MessageBox.Show("Không thể lấy thông tin Địa chỉ và Số điện thoại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tách địa chỉ và số điện thoại từ chuỗi "123 Nguyen Trai, Hanoi - 0123456789"
            indexOfDash = str.LastIndexOf('-');
            if (indexOfDash > -1 && indexOfDash + 1 < str.Length)
            {
                txtAddress.Text = str.Substring(0, indexOfDash).Trim(); // Phần trước dấu '-' là địa chỉ
                txtPhoneNumber.Text = str.Substring(indexOfDash + 1).Trim(); // Phần sau dấu '-' là số điện thoại
            }
            else
            {
                MessageBox.Show("Dữ liệu trả về không hợp lệ (không tìm thấy ký tự '-' trong địa chỉ và số điện thoại).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Gán Email vào textbox
            txtEmail.Text = email;
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
            public NhanVien(string address, string phoneNumber, string email)
            {
                Address = address;
                PhoneNumber = phoneNumber;
                Email = email;
            }
        }
        private DTO.NhanVien ConvertToDTO(NhanVien guiNhanVien)
        {
            return new DTO.NhanVien
            {
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
