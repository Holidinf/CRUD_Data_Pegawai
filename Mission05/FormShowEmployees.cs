using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mission05
{
    public partial class FormShowEmployees : Form
    {
        public FormShowEmployees()
        {
            InitializeComponent();
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            DataTable dt = DatabaseHelper.GetAllEmployees();
            dgvEmployees.DataSource = dt;
        }
        private void SetColumnWidths()
        {
            // Pastikan kolom-kolom dengan nama yang tepat ada di DataGridView
            dgvEmployees.Columns["kolom1"].Width = 150;  // Set lebar kolom "kolom1" menjadi 70
            dgvEmployees.Columns["kolom2"].Width = 150;  // Set lebar kolom "kolom2" menjadi 70
            dgvEmployees.Columns["kolom3"].Width = 210; // Set lebar kolom "kolom3" menjadi 210
        }

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SetColumnWidths();
        }
    }
}