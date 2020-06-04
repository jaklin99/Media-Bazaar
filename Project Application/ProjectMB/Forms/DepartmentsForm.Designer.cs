namespace ProjectMB
{
    partial class DepartmentsForm
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
            this.addDepartmentBtn = new System.Windows.Forms.Button();
            this.searchDepartmentBtn = new System.Windows.Forms.Button();
            this.departmentsLb = new System.Windows.Forms.ListBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addDepartmentBtn
            // 
            this.addDepartmentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(245)))));
            this.addDepartmentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDepartmentBtn.Location = new System.Drawing.Point(142, 528);
            this.addDepartmentBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addDepartmentBtn.Name = "addDepartmentBtn";
            this.addDepartmentBtn.Size = new System.Drawing.Size(366, 65);
            this.addDepartmentBtn.TabIndex = 5;
            this.addDepartmentBtn.Text = "Add New Department";
            this.addDepartmentBtn.UseVisualStyleBackColor = false;
            this.addDepartmentBtn.Click += new System.EventHandler(this.addDepartmentBtn_Click);
            // 
            // searchDepartmentBtn
            // 
            this.searchDepartmentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(245)))));
            this.searchDepartmentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchDepartmentBtn.Location = new System.Drawing.Point(142, 456);
            this.searchDepartmentBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchDepartmentBtn.Name = "searchDepartmentBtn";
            this.searchDepartmentBtn.Size = new System.Drawing.Size(366, 62);
            this.searchDepartmentBtn.TabIndex = 4;
            this.searchDepartmentBtn.Text = "Search for a Department";
            this.searchDepartmentBtn.UseVisualStyleBackColor = false;
            this.searchDepartmentBtn.Click += new System.EventHandler(this.searchDepartmentBtn_Click);
            // 
            // departmentsLb
            // 
            this.departmentsLb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.departmentsLb.Dock = System.Windows.Forms.DockStyle.Top;
            this.departmentsLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentsLb.FormattingEnabled = true;
            this.departmentsLb.ItemHeight = 29;
            this.departmentsLb.Location = new System.Drawing.Point(0, 0);
            this.departmentsLb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.departmentsLb.Name = "departmentsLb";
            this.departmentsLb.Size = new System.Drawing.Size(632, 435);
            this.departmentsLb.TabIndex = 3;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(245)))));
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Location = new System.Drawing.Point(142, 603);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(366, 62);
            this.closeBtn.TabIndex = 6;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // DepartmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(162)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(632, 687);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.addDepartmentBtn);
            this.Controls.Add(this.searchDepartmentBtn);
            this.Controls.Add(this.departmentsLb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DepartmentsForm";
            this.Text = "DepartmentForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DepartmentsForm_FormClosing);
            this.Load += new System.EventHandler(this.DepartmentsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addDepartmentBtn;
        private System.Windows.Forms.Button searchDepartmentBtn;
        private System.Windows.Forms.ListBox departmentsLb;
        private System.Windows.Forms.Button closeBtn;
    }
}