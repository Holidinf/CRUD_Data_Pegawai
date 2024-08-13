using System.Windows.Forms;

namespace Mission05
{
    partial class FormEditEmployee
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox cmbEmployees;
        private TextBox txtName;
        private TextBox txtPosition;
        private TextBox txtSalary;
        private Button btnSave;

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
            this.cmbEmployees = new ComboBox();
            this.txtName = new TextBox();
            this.txtPosition = new TextBox();
            this.txtSalary = new TextBox();
            this.btnSave = new Button();

            // 
            // cmbEmployees
            // 
            this.cmbEmployees.Location = new System.Drawing.Point(30, 30);
            this.cmbEmployees.Name = "cmbEmployees";
            this.cmbEmployees.Size = new System.Drawing.Size(200, 21);
            this.cmbEmployees.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbEmployees.SelectedIndexChanged += new System.EventHandler(this.CmbEmployees_SelectedIndexChanged);

            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(30, 70);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);

            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(30, 110);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(200, 20);

            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(30, 150);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(200, 20);

            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(30, 190);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 30);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);

            // 
            // FormEditEmployee
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cmbEmployees);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.btnSave);
            this.Name = "FormEditEmployee";
            this.Text = "Edit Employee";
        }
    }
}