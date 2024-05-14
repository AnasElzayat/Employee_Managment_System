using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveDataObject
{
    internal class DataAccessLayer
    {
        static SqlConnection sqlConnection=new SqlConnection(@"Data Source=(local);Initial Catalog=Company_SD;Integrated Security=True;");
        static SqlCommand sqlCommand = new SqlCommand();

        static DataAccessLayer()
        {
            sqlCommand.Connection = sqlConnection;
        }

        public static DataTable GetDepartments()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            sqlCommand.CommandText = "select Dnum as ID, Dname as Name from dbo.Departments";
            adapter.Fill(dataTable);

            return dataTable;
        }
        public static DataTable GetDepartmentEmployees(int DeptId)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            sqlCommand.CommandText = $"select SSN as ID , Fname ,Lname ,Salary, Sex,Dno as DeptId from dbo.Employee where Dno = {DeptId}";
            adapter.Fill(dataTable);

            return dataTable;
        }
        public static DataTable GetEmployee(int id)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter( sqlCommand);
            sqlCommand.CommandText = $"select SSN as ID , Fname ,Lname ,Salary, Sex,Dno as DeptId from dbo.Employee where SSn = {id}";
            adapter.Fill(dataTable);
            return dataTable;
        }
    }
}
