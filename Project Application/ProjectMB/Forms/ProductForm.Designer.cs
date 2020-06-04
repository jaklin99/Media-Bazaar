namespace ProjectMB
{
    partial class ProductForm
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
            this.namePb = new System.Windows.Forms.PictureBox();
            this.stockCbx = new System.Windows.Forms.CheckBox();
            this.removeBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.contentPnl = new System.Windows.Forms.Panel();
            this.categoryCb = new System.Windows.Forms.ComboBox();
            this.quantityPnl = new System.Windows.Forms.Panel();
            this.quantityTb = new System.Windows.Forms.TextBox();
            this.pricePnl = new System.Windows.Forms.Panel();
            this.priceTb = new System.Windows.Forms.TextBox();
            this.titleLbl = new System.Windows.Forms.Label();
            this.namePnl = new System.Windows.Forms.Panel();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.leftPnl = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.namePb)).BeginInit();
            this.contentPnl.SuspendLayout();
            this.leftPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // namePb
            // 
            this.namePb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.namePb.Image = global::ProjectMB.Properties.Resources.emp_add;
            this.namePb.Location = new System.Drawing.Point(81, 12);
            this.namePb.Name = "namePb";
            this.namePb.Size = new System.Drawing.Size(323, 212);
            this.namePb.TabIndex = 0;
            this.namePb.TabStop = false;
            // 
            // stockCbx
            // 
            this.stockCbx.Appearance = System.Windows.Forms.Appearance.Button;
            this.stockCbx.BackColor = System.Drawing.Color.Red;
            this.stockCbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.stockCbx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stockCbx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stockCbx.ForeColor = System.Drawing.Color.Snow;
            this.stockCbx.Location = new System.Drawing.Point(85, 323);
            this.stockCbx.Name = "stockCbx";
            this.stockCbx.Size = new System.Drawing.Size(251, 49);
            this.stockCbx.TabIndex = 19;
            this.stockCbx.Text = "Stock Request";
            this.stockCbx.UseVisualStyleBackColor = false;
            this.stockCbx.CheckedChanged += new System.EventHandler(this.stockCbx_CheckedChanged);
            // 
            // removeBtn
            // 
            this.removeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(245)))));
            this.removeBtn.Enabled = false;
            this.removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeBtn.Location = new System.Drawing.Point(171, 439);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(121, 45);
            this.removeBtn.TabIndex = 14;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(245)))));
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelBtn.Location = new System.Drawing.Point(35, 439);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(121, 45);
            this.cancelBtn.TabIndex = 13;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // contentPnl
            // 
            this.contentPnl.BackColor = System.Drawing.Color.White;
            this.contentPnl.Controls.Add(this.stockCbx);
            this.contentPnl.Controls.Add(this.removeBtn);
            this.contentPnl.Controls.Add(this.cancelBtn);
            this.contentPnl.Controls.Add(this.categoryCb);
            this.contentPnl.Controls.Add(this.quantityPnl);
            this.contentPnl.Controls.Add(this.quantityTb);
            this.contentPnl.Controls.Add(this.pricePnl);
            this.contentPnl.Controls.Add(this.priceTb);
            this.contentPnl.Controls.Add(this.titleLbl);
            this.contentPnl.Controls.Add(this.namePnl);
            this.contentPnl.Controls.Add(this.confirmBtn);
            this.contentPnl.Controls.Add(this.nameTb);
            this.contentPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPnl.Location = new System.Drawing.Point(378, 0);
            this.contentPnl.Name = "contentPnl";
            this.contentPnl.Size = new System.Drawing.Size(466, 518);
            this.contentPnl.TabIndex = 5;
            // 
            // categoryCb
            // 
            this.categoryCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryCb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.categoryCb.FormattingEnabled = true;
            this.categoryCb.Items.AddRange(new object[] {
            "Category"});
            this.categoryCb.Location = new System.Drawing.Point(85, 254);
            this.categoryCb.Name = "categoryCb";
            this.categoryCb.Size = new System.Drawing.Size(251, 28);
            this.categoryCb.TabIndex = 10;
            // 
            // quantityPnl
            // 
            this.quantityPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.quantityPnl.Location = new System.Drawing.Point(85, 217);
            this.quantityPnl.Name = "quantityPnl";
            this.quantityPnl.Size = new System.Drawing.Size(251, 1);
            this.quantityPnl.TabIndex = 9;
            // 
            // quantityTb
            // 
            this.quantityTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quantityTb.Location = new System.Drawing.Point(85, 192);
            this.quantityTb.Name = "quantityTb";
            this.quantityTb.Size = new System.Drawing.Size(251, 19);
            this.quantityTb.TabIndex = 8;
            this.quantityTb.Text = "Quantity";
            // 
            // pricePnl
            // 
            this.pricePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.pricePnl.Location = new System.Drawing.Point(85, 167);
            this.pricePnl.Name = "pricePnl";
            this.pricePnl.Size = new System.Drawing.Size(251, 1);
            this.pricePnl.TabIndex = 7;
            // 
            // priceTb
            // 
            this.priceTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priceTb.Location = new System.Drawing.Point(85, 141);
            this.priceTb.Name = "priceTb";
            this.priceTb.Size = new System.Drawing.Size(251, 19);
            this.priceTb.TabIndex = 6;
            this.priceTb.Text = "Price";
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(126, 24);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(152, 29);
            this.titleLbl.TabIndex = 3;
            this.titleLbl.Text = "New Product";
            // 
            // namePnl
            // 
            this.namePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.namePnl.Location = new System.Drawing.Point(85, 120);
            this.namePnl.Name = "namePnl";
            this.namePnl.Size = new System.Drawing.Size(251, 1);
            this.namePnl.TabIndex = 2;
            // 
            // confirmBtn
            // 
            this.confirmBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(245)))));
            this.confirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.confirmBtn.Location = new System.Drawing.Point(309, 439);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(121, 45);
            this.confirmBtn.TabIndex = 1;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = false;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // nameTb
            // 
            this.nameTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTb.Location = new System.Drawing.Point(85, 95);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(251, 19);
            this.nameTb.TabIndex = 0;
            this.nameTb.Text = "Name";
            // 
            // leftPnl
            // 
            this.leftPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(162)))), ((int)(((byte)(254)))));
            this.leftPnl.Controls.Add(this.namePb);
            this.leftPnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPnl.Location = new System.Drawing.Point(0, 0);
            this.leftPnl.Name = "leftPnl";
            this.leftPnl.Size = new System.Drawing.Size(378, 518);
            this.leftPnl.TabIndex = 4;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 518);
            this.Controls.Add(this.contentPnl);
            this.Controls.Add(this.leftPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductForm";
            this.Text = "NewProductForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductForm_FormClosing);
            this.Load += new System.EventHandler(this.NewProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.namePb)).EndInit();
            this.contentPnl.ResumeLayout(false);
            this.contentPnl.PerformLayout();
            this.leftPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox namePb;
        private System.Windows.Forms.CheckBox stockCbx;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Panel contentPnl;
        private System.Windows.Forms.ComboBox categoryCb;
        private System.Windows.Forms.Panel quantityPnl;
        private System.Windows.Forms.TextBox quantityTb;
        private System.Windows.Forms.Panel pricePnl;
        private System.Windows.Forms.TextBox priceTb;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Panel namePnl;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.Panel leftPnl;
    }
}