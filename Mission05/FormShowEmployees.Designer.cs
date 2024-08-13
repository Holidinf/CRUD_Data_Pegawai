using System.Windows.Forms;

namespace Mission05
{
    partial class FormShowEmployees
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvEmployees;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.ColumnHeadersHeight = 34;
            this.dgvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployees.Location = new System.Drawing.Point(0, 0);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.RowHeadersWidth = 62;
            this.dgvEmployees.Size = new System.Drawing.Size(400, 300);
            this.dgvEmployees.TabIndex = 0;
            this.dgvEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployees_CellContentClick);
            // 
            // FormShowEmployees
            // 
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.dgvEmployees);
            this.Name = "FormShowEmployees";
            this.Text = "Employee List";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);

        }
    }
}