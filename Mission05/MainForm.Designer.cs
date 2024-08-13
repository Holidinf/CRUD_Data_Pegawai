using System.Windows.Forms;

namespace Mission05
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnAddEmployee;
        private Button btnEditEmployee;
        private Button btnShowEmployees;
        private Button btnSearchEmployee;

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
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.btnShowEmployees = new System.Windows.Forms.Button();
            this.btnSearchEmployee = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(75, 46);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(300, 46);
            this.btnAddEmployee.TabIndex = 0;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.BtnAddEmployee_Click);
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.Location = new System.Drawing.Point(75, 123);
            this.btnEditEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(300, 46);
            this.btnEditEmployee.TabIndex = 1;
            this.btnEditEmployee.Text = "Edit Employee";
            this.btnEditEmployee.UseVisualStyleBackColor = true;
            this.btnEditEmployee.Click += new System.EventHandler(this.BtnEditEmployee_Click);
            // 
            // btnShowEmployees
            // 
            this.btnShowEmployees.Location = new System.Drawing.Point(75, 200);
            this.btnShowEmployees.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowEmployees.Name = "btnShowEmployees";
            this.btnShowEmployees.Size = new System.Drawing.Size(300, 46);
            this.btnShowEmployees.TabIndex = 2;
            this.btnShowEmployees.Text = "Show Employees";
            this.btnShowEmployees.UseVisualStyleBackColor = true;
            this.btnShowEmployees.Click += new System.EventHandler(this.BtnShowEmployees_Click);
            // 
            // btnSearchEmployee
            // 
            this.btnSearchEmployee.Location = new System.Drawing.Point(75, 277);
            this.btnSearchEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchEmployee.Name = "btnSearchEmployee";
            this.btnSearchEmployee.Size = new System.Drawing.Size(300, 46);
            this.btnSearchEmployee.TabIndex = 3;
            this.btnSearchEmployee.Text = "Search Employee";
            this.btnSearchEmployee.UseVisualStyleBackColor = true;
            this.btnSearchEmployee.Click += new System.EventHandler(this.BtnSearchEmployee_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(75, 355);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(300, 46);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Keluar";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 458);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearchEmployee);
            this.Controls.Add(this.btnShowEmployees);
            this.Controls.Add(this.btnEditEmployee);
            this.Controls.Add(this.btnAddEmployee);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Employee Management System";
            this.ResumeLayout(false);

        }

        private Button btnExit;
    }
}