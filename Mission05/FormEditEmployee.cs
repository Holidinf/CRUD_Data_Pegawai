using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Mission05
{
    public partial class FormEditEmployee : Form
    {
        public FormEditEmployee()
        {
            InitializeComponent();
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            DataTable dt = DatabaseHelper.GetAllEmployees();
            cmbEmployees.DataSource = dt;
            cmbEmployees.DisplayMember = "Name";
            cmbEmployees.ValueMember = "Id";
        }

        private void CmbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEmployees.SelectedItem != null)
            {
                DataRowView drv = (DataRowView)cmbEmployees.SelectedItem;
                txtName.Text = drv["Name"].ToString();
                txtPosition.Text = drv["Position"].ToString();
                txtSalary.Text = drv["Salary"].ToString();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee
            {
                Id = (int)cmbEmployees.SelectedValue,
                Name = txtName.Text,
                Position = txtPosition.Text,
                Salary = decimal.Parse(txtSalary.Text)
            };

            DatabaseHelper.UpdateEmployee(employee);
            MessageBox.Show("Employee updated successfully!");
            this.Close();
        }
    }
}