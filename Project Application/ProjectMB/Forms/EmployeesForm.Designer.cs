namespace ProjectMB
{
    partial class EmployeesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.departmentCb = new System.Windows.Forms.ComboBox();
            this.showBtn = new System.Windows.Forms.Button();
            this.roleCb = new System.Windows.Forms.ComboBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.employeesLv = new System.Windows.Forms.ListView();
            this.idColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.emailColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phoneNumberColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.positionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.salaryColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.departmentColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(245)))));
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Location = new System.Drawing.Point(1106, 427);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(272, 81);
            this.addBtn.TabIndex = 5;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(245)))));
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Location = new System.Drawing.Point(13, 427);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(272, 81);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // departmentCb
            // 
            this.departmentCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.departmentCb.FormattingEnabled = true;
            this.departmentCb.Items.AddRange(new object[] {
            "Department"});
            this.departmentCb.Location = new System.Drawing.Point(667, 388);
            this.departmentCb.Name = "departmentCb";
            this.departmentCb.Size = new System.Drawing.Size(245, 40);
            this.departmentCb.TabIndex = 6;
            // 
            // showBtn
            // 
            this.showBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(245)))));
            this.showBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showBtn.Location = new System.Drawing.Point(535, 434);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(245, 32);
            this.showBtn.TabIndex = 7;
            this.showBtn.Text = "Show";
            this.showBtn.UseVisualStyleBackColor = false;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // roleCb
            // 
            this.roleCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.roleCb.FormattingEnabled = true;
            this.roleCb.Items.AddRange(new object[] {
            "Position",
            "Employee",
            "Stock",
            "Department",
            "Admin",
            "Manager",
            "All Employees",
            "All People"});
            this.roleCb.Location = new System.Drawing.Point(416, 388);
            this.roleCb.Name = "roleCb";
            this.roleCb.Size = new System.Drawing.Size(245, 40);
            this.roleCb.TabIndex = 8;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(245)))));
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Location = new System.Drawing.Point(1277, 363);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(101, 32);
            this.closeBtn.TabIndex = 9;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // employeesLv
            // 
            this.employeesLv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.employeesLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumn,
            this.firstNameColumn,
            this.lastNameColumn,
            this.emailColumn,
            this.phoneNumberColumn,
            this.positionColumn,
            this.salaryColumn,
            this.departmentColumn});
            this.employeesLv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employeesLv.Font = new System.Drawing.Font("Rockwell", 10F);
            this.employeesLv.FullRowSelect = true;
            this.employeesLv.HideSelection = false;
            this.employeesLv.Location = new System.Drawing.Point(0, 0);
            this.employeesLv.MultiSelect = false;
            this.employeesLv.Name = "employeesLv";
            this.employeesLv.Size = new System.Drawing.Size(1390, 357);
            this.employeesLv.TabIndex = 10;
            this.employeesLv.UseCompatibleStateImageBehavior = false;
            this.employeesLv.View = System.Windows.Forms.View.Details;
            this.employeesLv.Click += new System.EventHandler(this.employeesLv_Click);
            // 
            // idColumn
            // 
            this.idColumn.Text = "ID";
            this.idColumn.Width = 0;
            // 
            // firstNameColumn
            // 
            this.firstNameColumn.Text = "First Name";
            this.firstNameColumn.Width = 195;
            // 
            // lastNameColumn
            // 
            this.lastNameColumn.Text = "Last Name";
            this.lastNameColumn.Width = 197;
            // 
            // emailColumn
            // 
            this.emailColumn.Text = "Email";
            this.emailColumn.Width = 329;
            // 
            // phoneNumberColumn
            // 
            this.phoneNumberColumn.Text = "Phone Number";
            this.phoneNumberColumn.Width = 205;
            // 
            // positionColumn
            // 
            this.positionColumn.Text = "Position";
            this.positionColumn.Width = 156;
            // 
            // salaryColumn
            // 
            this.salaryColumn.Text = "Salary";
            this.salaryColumn.Width = 132;
            // 
            // departmentColumn
            // 
            this.departmentColumn.Text = "Department";
            this.departmentColumn.Width = 215;
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(162)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1390, 518);
            this.Controls.Add(this.employeesLv);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.roleCb);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.departmentCb);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.searchBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmployeesForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Employees";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployeesForm_FormClosing);
            this.Load += new System.EventHandler(this.EmployeesForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ComboBox departmentCb;
        private System.Windows.Forms.Button showBtn;
        private System.Windows.Forms.ComboBox roleCb;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.ListView employeesLv;
        private System.Windows.Forms.ColumnHeader firstNameColumn;
        private System.Windows.Forms.ColumnHeader lastNameColumn;
        private System.Windows.Forms.ColumnHeader emailColumn;
        private System.Windows.Forms.ColumnHeader phoneNumberColumn;
        private System.Windows.Forms.ColumnHeader positionColumn;
        private System.Windows.Forms.ColumnHeader salaryColumn;
        private System.Windows.Forms.ColumnHeader departmentColumn;
        private System.Windows.Forms.ColumnHeader idColumn;
    }
}