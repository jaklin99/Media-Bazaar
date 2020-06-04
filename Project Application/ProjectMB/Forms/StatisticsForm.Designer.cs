namespace ProjectMB
{
    partial class StatisticsForm
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
            this.lbStatistics = new System.Windows.Forms.ListBox();
            this.btnEmployeeStatistics = new System.Windows.Forms.Button();
            this.cbEmployeeDepartment = new System.Windows.Forms.ComboBox();
            this.btnGetProductStatistics = new System.Windows.Forms.Button();
            this.cbProductCategories = new System.Windows.Forms.ComboBox();
            this.lbStatisticsEdepartments = new System.Windows.Forms.Label();
            this.lbStatisticsProductCategory = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.namePb = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.namePb)).BeginInit();
            this.SuspendLayout();
            // 
            // lbStatistics
            // 
            this.lbStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatistics.FormattingEnabled = true;
            this.lbStatistics.ItemHeight = 32;
            this.lbStatistics.Location = new System.Drawing.Point(-2, 2);
            this.lbStatistics.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbStatistics.Name = "lbStatistics";
            this.lbStatistics.Size = new System.Drawing.Size(997, 420);
            this.lbStatistics.TabIndex = 0;
            // 
            // btnEmployeeStatistics
            // 
            this.btnEmployeeStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(245)))));
            this.btnEmployeeStatistics.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnEmployeeStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeStatistics.Location = new System.Drawing.Point(309, 166);
            this.btnEmployeeStatistics.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEmployeeStatistics.Name = "btnEmployeeStatistics";
            this.btnEmployeeStatistics.Size = new System.Drawing.Size(333, 55);
            this.btnEmployeeStatistics.TabIndex = 1;
            this.btnEmployeeStatistics.Text = "Employee Statistics";
            this.btnEmployeeStatistics.UseVisualStyleBackColor = false;
            this.btnEmployeeStatistics.Click += new System.EventHandler(this.btnEmployeeStatistics_Click);
            // 
            // cbEmployeeDepartment
            // 
            this.cbEmployeeDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmployeeDepartment.FormattingEnabled = true;
            this.cbEmployeeDepartment.Items.AddRange(new object[] {
            "Finance",
            "Human Resource",
            "Inventory",
            "Marketing"});
            this.cbEmployeeDepartment.Location = new System.Drawing.Point(309, 75);
            this.cbEmployeeDepartment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbEmployeeDepartment.Name = "cbEmployeeDepartment";
            this.cbEmployeeDepartment.Size = new System.Drawing.Size(333, 37);
            this.cbEmployeeDepartment.TabIndex = 2;
            // 
            // btnGetProductStatistics
            // 
            this.btnGetProductStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(245)))));
            this.btnGetProductStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetProductStatistics.Location = new System.Drawing.Point(666, 166);
            this.btnGetProductStatistics.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGetProductStatistics.Name = "btnGetProductStatistics";
            this.btnGetProductStatistics.Size = new System.Drawing.Size(328, 55);
            this.btnGetProductStatistics.TabIndex = 3;
            this.btnGetProductStatistics.Text = "Product Statistics";
            this.btnGetProductStatistics.UseVisualStyleBackColor = false;
            this.btnGetProductStatistics.Click += new System.EventHandler(this.btnGetProductStatistics_Click);
            // 
            // cbProductCategories
            // 
            this.cbProductCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProductCategories.FormattingEnabled = true;
            this.cbProductCategories.Items.AddRange(new object[] {
            "IMAGE_SOUND",
            "COMPUTER",
            "PHOTO_VIDEO",
            "TELEPHONY_NAVIGATION",
            "HOUSEHOLD",
            "KITCHEN",
            "SPORT_CARE",
            "GAMING_FILM_MUSIC",
            "SMART_HOME"});
            this.cbProductCategories.Location = new System.Drawing.Point(666, 75);
            this.cbProductCategories.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbProductCategories.Name = "cbProductCategories";
            this.cbProductCategories.Size = new System.Drawing.Size(328, 37);
            this.cbProductCategories.TabIndex = 4;
            // 
            // lbStatisticsEdepartments
            // 
            this.lbStatisticsEdepartments.AutoSize = true;
            this.lbStatisticsEdepartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatisticsEdepartments.Location = new System.Drawing.Point(309, 11);
            this.lbStatisticsEdepartments.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStatisticsEdepartments.Name = "lbStatisticsEdepartments";
            this.lbStatisticsEdepartments.Size = new System.Drawing.Size(230, 26);
            this.lbStatisticsEdepartments.TabIndex = 5;
            this.lbStatisticsEdepartments.Text = "Employee Department";
            // 
            // lbStatisticsProductCategory
            // 
            this.lbStatisticsProductCategory.AutoSize = true;
            this.lbStatisticsProductCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatisticsProductCategory.Location = new System.Drawing.Point(660, 11);
            this.lbStatisticsProductCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStatisticsProductCategory.Name = "lbStatisticsProductCategory";
            this.lbStatisticsProductCategory.Size = new System.Drawing.Size(181, 26);
            this.lbStatisticsProductCategory.TabIndex = 6;
            this.lbStatisticsProductCategory.Text = "Product Category";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(162)))), ((int)(((byte)(254)))));
            this.panel1.Controls.Add(this.namePb);
            this.panel1.Controls.Add(this.btnEmployeeStatistics);
            this.panel1.Controls.Add(this.lbStatisticsProductCategory);
            this.panel1.Controls.Add(this.cbEmployeeDepartment);
            this.panel1.Controls.Add(this.cbProductCategories);
            this.panel1.Controls.Add(this.lbStatisticsEdepartments);
            this.panel1.Controls.Add(this.btnGetProductStatistics);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.panel1.Location = new System.Drawing.Point(-2, 420);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(999, 272);
            this.panel1.TabIndex = 7;
            // 
            // namePb
            // 
            this.namePb.BackColor = System.Drawing.Color.Transparent;
            this.namePb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.namePb.Image = global::ProjectMB.Properties.Resources.emp_add;
            this.namePb.Location = new System.Drawing.Point(0, -35);
            this.namePb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.namePb.Name = "namePb";
            this.namePb.Size = new System.Drawing.Size(300, 308);
            this.namePb.TabIndex = 8;
            this.namePb.TabStop = false;
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 692);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbStatistics);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StatisticsForm";
            this.Text = "Statistics";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StatisticsForm_FormClosing);
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.namePb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbStatistics;
        private System.Windows.Forms.Button btnEmployeeStatistics;
        private System.Windows.Forms.ComboBox cbEmployeeDepartment;
        private System.Windows.Forms.Button btnGetProductStatistics;
        private System.Windows.Forms.ComboBox cbProductCategories;
        private System.Windows.Forms.Label lbStatisticsEdepartments;
        private System.Windows.Forms.Label lbStatisticsProductCategory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox namePb;
    }
}