using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class EmployeeDAL
    {
        QLSHOPDataContext sql = new QLSHOPDataContext();
        public EmployeeDAL() { }

        public bool Login(string email, string password)
        {
            try
            {
                var employee = sql.NhanViens
                                      .FirstOrDefault(e => e.Email == email && e.Password == password);
                return employee != null;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Kiểm tra tồn tại email bằng LINQ
        public bool IsExistEmail(string email)
        {
            try
            {
                return sql.NhanViens.Any(e => e.Email == email);
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Cập nhật mật khẩu bằng LINQ
        public bool UpdatePassword(string email, string password)
        {
            try
            {
                var employee = sql.NhanViens.FirstOrDefault(e => e.Email == email);
                if (employee != null)
                {
                    employee.Password = password;
                    sql.SubmitChanges();  // Đảm bảo thay đổi được lưu vào cơ sở dữ liệu
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Lấy vai trò của nhân viên
        public bool GetEmployeeRole(string email)
        {
            try
            {
                var employee = sql.NhanViens.FirstOrDefault(e => e.Email == email);
                return employee?.Role ?? false;  // Trả về false nếu không tìm thấy
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Đổi mật khẩu bằng LINQ
        public bool ChangePassword(string email, string oldPassword, string newPassword)
        {
            try
            {
                var employee = sql.NhanViens.FirstOrDefault(e => e.Email == email && e.Password == oldPassword);
                if (employee != null)
                {
                    employee.Password = newPassword;
                    sql.SubmitChanges();  // Đảm bảo thay đổi được lưu vào cơ sở dữ liệu
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Lấy danh sách nhân viên bằng LINQ
        

        // Thêm nhân viên mới bằng LINQ
        public bool InsertEmployee(NhanVien employee)
        {
            try
            {
                sql.NhanViens.InsertOnSubmit(new NhanVien
                {
                    Name = employee.Name,
                    Address = employee.Address,
                    PhoneNumber = employee.PhoneNumber,
                    Email = employee.Email,
                    Role = employee.Role,
                    Status = employee.Status,
                    Password = employee.Password
                });
                sql.SubmitChanges();  // Lưu thay đổi vào cơ sở dữ liệu
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Cập nhật thông tin nhân viên bằng LINQ
        public bool UpdateEmployee(NhanVien employee)
        {
            try
            {
                var existingEmployee = sql.NhanViens.FirstOrDefault(e => e.Email == employee.Email);
                if (existingEmployee != null)
                {
                    existingEmployee.Name = employee.Name;
                    existingEmployee.Address = employee.Address;
                    existingEmployee.PhoneNumber = employee.PhoneNumber;
                    existingEmployee.Role = employee.Role;
                    existingEmployee.Status = employee.Status;
                    sql.SubmitChanges();  // Lưu thay đổi vào cơ sở dữ liệu
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Cập nhật địa chỉ và số điện thoại bằng LINQ
        public bool UpdateEmployeeAddressPhoneNumber(NhanVien employee)
        {
            try
            {
                var existingEmployee = sql.NhanViens.FirstOrDefault(e => e.Email == employee.Email);
                if (existingEmployee != null)
                {
                    existingEmployee.Address = employee.Address;
                    existingEmployee.PhoneNumber = employee.PhoneNumber;
                    sql.SubmitChanges();  // Lưu thay đổi vào cơ sở dữ liệu
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Xóa nhân viên bằng LINQ
        public bool DeleteEmployee(int id)
        {
            try
            {
                var employee = sql.NhanViens.FirstOrDefault(e => e.Id == id);
                if (employee != null)
                {
                    sql.NhanViens.DeleteOnSubmit(employee);  // Xóa nhân viên khỏi danh sách
                    sql.SubmitChanges();  // Lưu thay đổi vào cơ sở dữ liệu
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Tìm kiếm nhân viên theo tên bằng LINQ
        public DataTable SearchEmployee(string name)
        {
            try
            {
                // Get the employees matching the search criteria
                var employees = sql.NhanViens.Where(e => e.Name.Contains(name)).ToList();

                // Create a new DataTable to hold the employee data
                DataTable dt = new DataTable();

                // Define the columns for the DataTable
                dt.Columns.Add("Id", typeof(int));
                dt.Columns.Add("Name", typeof(string));
                dt.Columns.Add("Address", typeof(string));
                dt.Columns.Add("PhoneNumber", typeof(string));
                dt.Columns.Add("Email", typeof(string));
                dt.Columns.Add("Password", typeof(string));
                dt.Columns.Add("Role", typeof(bool));
                dt.Columns.Add("Status", typeof(bool));

                // Loop through the results and add rows to the DataTable
                foreach (var emp in employees)
                {
                    dt.Rows.Add(emp.Id, emp.Name, emp.Address, emp.PhoneNumber, emp.Email, emp.Password, emp.Role, emp.Status);
                }

                // Return the populated DataTable
                return dt;
            }
            catch (Exception)
            {
                // In case of an error, return an empty DataTable
                return new DataTable();
            }
        }


        // Lấy Id và Name của nhân viên bằng LINQ
        public string GetEmployeeIdName(string email)
        {
            try
            {
                var employee = sql.NhanViens.FirstOrDefault(e => e.Email == email);
                return employee != null ? $"{employee.Id} - {employee.Name}" : null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        // Lấy địa chỉ và số điện thoại của nhân viên bằng LINQ
        public string GetEmployeeAddressPhoneNumber(string email)
        {
            try
            {
                var employee = sql.NhanViens.FirstOrDefault(e => e.Email == email);
                return employee != null ? $"{employee.Address} - {employee.PhoneNumber}" : null;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable ListOfEmployees()
        {
            // Assuming you're using LINQ to retrieve data from your database
            List<NhanVien> employees = sql.NhanViens.ToList();

            DataTable dt = new DataTable();

            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Address", typeof(string));
            dt.Columns.Add("PhoneNumber", typeof(string));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("Password", typeof(string));
            dt.Columns.Add("Role", typeof(bool));
            dt.Columns.Add("Status", typeof(bool));

            foreach (var emp in employees)
            {
                dt.Rows.Add(emp.Id, emp.Name, emp.Address, emp.PhoneNumber, emp.Email, emp.Password, emp.Role, emp.Status);
            }

            return dt;
        }




    }
}
