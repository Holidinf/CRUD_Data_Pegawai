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
    public partial class FormAddEmployee : Form
    {
        public FormAddEmployee()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee
            {
                Name = txtName.Text,
                Position = txtPosition.Text,
                Salary = decimal.Parse(txtSalary.Text)
            };

            DatabaseHelper.AddEmployee(employee);
            MessageBox.Show("Employee added successfully!");
            this.Close();
        }
    }
}