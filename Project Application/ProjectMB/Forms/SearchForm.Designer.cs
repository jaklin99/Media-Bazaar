namespace ProjectMB
{
    partial class SearchForm
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
            this.searchTb = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.resultsLb = new System.Windows.Forms.ListBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchTb
            // 
            this.searchTb.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTb.Location = new System.Drawing.Point(16, 374);
            this.searchTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchTb.Name = "searchTb";
            this.searchTb.Size = new System.Drawing.Size(749, 50);
            this.searchTb.TabIndex = 0;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(245)))));
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Location = new System.Drawing.Point(773, 372);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(598, 70);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // resultsLb
            // 
            this.resultsLb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultsLb.Dock = System.Windows.Forms.DockStyle.Top;
            this.resultsLb.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsLb.FormattingEnabled = true;
            this.resultsLb.HorizontalScrollbar = true;
            this.resultsLb.ItemHeight = 45;
            this.resultsLb.Location = new System.Drawing.Point(0, 0);
            this.resultsLb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.resultsLb.Name = "resultsLb";
            this.resultsLb.Size = new System.Drawing.Size(1405, 270);
            this.resultsLb.TabIndex = 2;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(245)))));
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Location = new System.Drawing.Point(1229, 321);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(142, 43);
            this.closeBtn.TabIndex = 3;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(162)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1405, 474);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.resultsLb);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchTb);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search By Surname";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchForm_FormClosing);
            this.Load += new System.EventHandler(this.SearchProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTb;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ListBox resultsLb;
        private System.Windows.Forms.Button closeBtn;
    }
}