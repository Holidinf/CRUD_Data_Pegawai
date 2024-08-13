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
    public partial class FormSearchEmployee : Form
    {
        public FormSearchEmployee()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;
            DataTable dt = DatabaseHelper.SearchEmployees(keyword);
            dgvResults.DataSource = dt;
        }

        private void dgvResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
