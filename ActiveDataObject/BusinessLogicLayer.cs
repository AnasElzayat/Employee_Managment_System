using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActiveDataObject
{
    internal class BusinessLogicLayer
    {
        public static List<Department> GetDepartments()
        {
            DataTable dataTable = DataAccessLayer.GetDepartments();
            List<Department> departments = new List<Department>();

            foreach (DataRow row in dataTable.Rows)
            {
                departments.Add(new Department
                {
                    ID = (int)row["ID"],
                    Name = row["Name"] == DBNull.Value ? "" : (string)row["Name"]
                });
            }
            return departments;
        }
        public static List<Employee> GetEmployees(int DeptId)
        {
            DataTable dataTable = DataAccessLayer.GetDepartmentEmployees(DeptId);
            List<Employee> employees = new List<Employee>();
            foreach (DataRow row in dataTable.Rows)
            {
                employees.Add(new Employee
                {
                    ID = (int)row["ID"],
                    Fname = row["Fname"]==DBNull.Value?"": (string)row["Fname"],
                    Lname = row["Lname"] == DBNull.Value ? "" : (string)row["Lname"],
                    Salary = row["Salary"] == DBNull.Value ? -1 : (int)row["Salary"],
                    Sex = row["Sex"]==DBNull.Value ? "" : (string)row["Sex"],
                    DeptId = row["DeptId"]==DBNull.Value ? -1 : (int)row["DeptId"]
                });
            }
            return employees;
        }
        public static Employee GetEmployee(int EmployeeId)
        {
            DataTable dataTable= DataAccessLayer.GetEmployee(EmployeeId);
            Employee employee= new Employee() ;
            foreach (DataRow row in dataTable.Rows)
            {
                employee= new Employee
                {
                    ID = (int)row["ID"],
                    Fname = row["Fname"] == DBNull.Value ? "" : (string)row["Fname"],
                    Lname = row["Lname"] == DBNull.Value ? "" : (string)row["Lname"],
                    Salary = row["Salary"] == DBNull.Value ? -1 : (int)row["Salary"],
                    Sex = row["Sex"] == DBNull.Value ? "" : (string)row["Sex"],
                    DeptId = row["DeptId"] == DBNull.Value ? -1 : (int)row["DeptId"]
                };
            }
            return employee;
        }
    }
}
