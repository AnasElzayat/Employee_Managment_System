using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActiveDataObject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DeptsComboBox.DisplayMember = "Name";
            DeptsComboBox.ValueMember = "ID";
            DeptsComboBox.DataSource = BusinessLogicLayer.GetDepartments();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void EmpsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MaleCheckBox.Checked = false;
            FemaleCheckBox.Checked = false;
            Employee employee = BusinessLogicLayer.GetEmployee((int)EmpsListBox.SelectedValue);
            EmpIdNumericUpDown.Value = employee.ID;
            EmpFNameTextBox.Text=employee.Fname.ToString();
            EmpLNameTextBox.Text=employee.Lname.ToString();
            if (employee.Sex == "M")
            {
                MaleCheckBox.Checked = true;
            }else if (employee.Sex == "F")
            {
                FemaleCheckBox.Checked = true;
            }
            SalaryNumericUpDown.Value = employee.Salary;
            DeptIdNumericUpDown.Value = employee.DeptId;
        }

        private void DeptsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmpsListBox.DisplayMember = "Fname";
            EmpsListBox.ValueMember = "ID";
            EmpsListBox.DataSource = BusinessLogicLayer.GetEmployees((int)DeptsComboBox.SelectedValue);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
