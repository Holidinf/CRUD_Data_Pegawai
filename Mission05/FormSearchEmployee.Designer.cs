using System.Windows.Forms;

namespace Mission05
{
    partial class FormSearchEmployee
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridView dgvResults;

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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(30, 30);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(325, 26);
            this.txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(361, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(117, 34);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // dgvResults
            // 
            this.dgvResults.ColumnHeadersHeight = 34;
            this.dgvResults.Location = new System.Drawing.Point(30, 70);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.RowHeadersWidth = 62;
            this.dgvResults.Size = new System.Drawing.Size(448, 298);
            this.dgvResults.TabIndex = 2;
            this.dgvResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResults_CellContentClick);
            // 
            // FormSearchEmployee
            // 
            this.ClientSize = new System.Drawing.Size(499, 380);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvResults);
            this.Name = "FormSearchEmployee";
            this.Text = "Search Employee";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}