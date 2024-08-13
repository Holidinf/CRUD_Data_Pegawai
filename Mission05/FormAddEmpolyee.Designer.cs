using System;
using System.Windows.Forms;

namespace Mission05
{
    partial class FormAddEmployee
    {
        private System.ComponentModel.IContainer components = null;
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
            this.txtName = new TextBox();
            this.txtPosition = new TextBox();
            this.txtSalary = new TextBox();
            this.btnSave = new Button();

            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(30, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.Text = "Enter Name";
            this.txtName.ForeColor = System.Drawing.Color.Gray;
            this.txtName.Enter += new System.EventHandler(this.TxtName_Enter);
            this.txtName.Leave += new System.EventHandler(this.TxtName_Leave);

            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(30, 70);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(200, 20);
            this.txtPosition.Text = "Enter Position";
            this.txtPosition.ForeColor = System.Drawing.Color.Gray;
            this.txtPosition.Enter += new System.EventHandler(this.TxtPosition_Enter);
            this.txtPosition.Leave += new System.EventHandler(this.TxtPosition_Leave);

            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(30, 110);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(200, 20);
            this.txtSalary.Text = "Enter Salary";
            this.txtSalary.ForeColor = System.Drawing.Color.Gray;
            this.txtSalary.Enter += new System.EventHandler(this.TxtSalary_Enter);
            this.txtSalary.Leave += new System.EventHandler(this.TxtSalary_Leave);

            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(30, 150);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 30);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);

            // 
            // FormAddEmployee
            // 
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.btnSave);
            this.Name = "FormAddEmployee";
            this.Text = "Add New Employee";
        }

        private void TxtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "Enter Name")
            {
                txtName.Text = "";
                txtName.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void TxtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "Enter Name";
                txtName.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void TxtPosition_Enter(object sender, EventArgs e)
        {
            if (txtPosition.Text == "Enter Position")
            {
                txtPosition.Text = "";
                txtPosition.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void TxtPosition_Leave(object sender, EventArgs e)
        {
            if (txtPosition.Text == "")
            {
                txtPosition.Text = "Enter Position";
                txtPosition.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void TxtSalary_Enter(object sender, EventArgs e)
        {
            if (txtSalary.Text == "Enter Salary")
            {
                txtSalary.Text = "";
                txtSalary.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void TxtSalary_Leave(object sender, EventArgs e)
        {
            if (txtSalary.Text == "")
            {
                txtSalary.Text = "Enter Salary";
                txtSalary.ForeColor = System.Drawing.Color.Gray;
            }
        }
    }
}