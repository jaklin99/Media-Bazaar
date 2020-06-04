using System.Drawing;
using System.Windows.Forms;

namespace ProjectMB
{
    partial class MainForm
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
            this.loginBtn = new System.Windows.Forms.Button();
            this.usernameTb = new System.Windows.Forms.TextBox();
            this.passwordTb = new System.Windows.Forms.TextBox();
            this.loginPnl = new System.Windows.Forms.Panel();
            this.loginComponentsPnl = new System.Windows.Forms.Panel();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.selectionPnl = new System.Windows.Forms.Panel();
            this.departmentsBtn = new System.Windows.Forms.Button();
            this.statisticsBtn = new System.Windows.Forms.Button();
            this.productsBtn = new System.Windows.Forms.Button();
            this.employeesBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.logoPb = new System.Windows.Forms.PictureBox();
            this.loginPnl.SuspendLayout();
            this.loginComponentsPnl.SuspendLayout();
            this.selectionPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPb)).BeginInit();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(54, 55);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(124, 40);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // usernameTb
            // 
            this.usernameTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTb.Location = new System.Drawing.Point(0, 0);
            this.usernameTb.Name = "usernameTb";
            this.usernameTb.Size = new System.Drawing.Size(100, 34);
            this.usernameTb.TabIndex = 1;
            this.usernameTb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.usernameTb_KeyDown);
            // 
            // passwordTb
            // 
            this.passwordTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTb.Location = new System.Drawing.Point(0, 0);
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.ShortcutsEnabled = false;
            this.passwordTb.Size = new System.Drawing.Size(100, 34);
            this.passwordTb.TabIndex = 2;
            this.passwordTb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTb_KeyDown);
            // 
            // loginPnl
            // 
            this.loginPnl.BackColor = System.Drawing.Color.Transparent;
            this.loginPnl.Controls.Add(this.loginComponentsPnl);
            this.loginPnl.Location = new System.Drawing.Point(510, 105);
            this.loginPnl.Name = "loginPnl";
            this.loginPnl.Size = new System.Drawing.Size(278, 245);
            this.loginPnl.TabIndex = 3;
            // 
            // loginComponentsPnl
            // 
            this.loginComponentsPnl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginComponentsPnl.BackColor = System.Drawing.Color.White;
            this.loginComponentsPnl.Controls.Add(this.passwordLbl);
            this.loginComponentsPnl.Controls.Add(this.usernameLbl);
            this.loginComponentsPnl.Controls.Add(this.passwordTb);
            this.loginComponentsPnl.Controls.Add(this.usernameTb);
            this.loginComponentsPnl.Controls.Add(this.loginBtn);
            this.loginComponentsPnl.Location = new System.Drawing.Point(39, 72);
            this.loginComponentsPnl.Name = "loginComponentsPnl";
            this.loginComponentsPnl.Size = new System.Drawing.Size(224, 151);
            this.loginComponentsPnl.TabIndex = 5;
            // 
            // passwordLbl
            // 
            this.passwordLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.passwordLbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.passwordLbl.Location = new System.Drawing.Point(0, 147);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(224, 2);
            this.passwordLbl.TabIndex = 7;
            // 
            // usernameLbl
            // 
            this.usernameLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.usernameLbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.usernameLbl.Location = new System.Drawing.Point(0, 149);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(224, 2);
            this.usernameLbl.TabIndex = 6;
            // 
            // selectionPnl
            // 
            this.selectionPnl.BackColor = System.Drawing.Color.Transparent;
            this.selectionPnl.Controls.Add(this.departmentsBtn);
            this.selectionPnl.Controls.Add(this.statisticsBtn);
            this.selectionPnl.Controls.Add(this.productsBtn);
            this.selectionPnl.Controls.Add(this.employeesBtn);
            this.selectionPnl.Location = new System.Drawing.Point(0, 0);
            this.selectionPnl.Name = "selectionPnl";
            this.selectionPnl.Size = new System.Drawing.Size(278, 245);
            this.selectionPnl.TabIndex = 4;
            this.selectionPnl.Visible = false;
            // 
            // departmentsBtn
            // 
            this.departmentsBtn.Location = new System.Drawing.Point(93, 105);
            this.departmentsBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.departmentsBtn.Name = "departmentsBtn";
            this.departmentsBtn.Size = new System.Drawing.Size(92, 35);
            this.departmentsBtn.TabIndex = 4;
            this.departmentsBtn.Text = "Departments";
            this.departmentsBtn.UseVisualStyleBackColor = true;
            this.departmentsBtn.Click += new System.EventHandler(this.departmentsBtn_Click);
            // 
            // statisticsBtn
            // 
            this.statisticsBtn.Location = new System.Drawing.Point(63, 163);
            this.statisticsBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.statisticsBtn.Name = "statisticsBtn";
            this.statisticsBtn.Size = new System.Drawing.Size(92, 35);
            this.statisticsBtn.TabIndex = 3;
            this.statisticsBtn.Text = "Statistics";
            this.statisticsBtn.UseVisualStyleBackColor = true;
            this.statisticsBtn.Click += new System.EventHandler(this.statisticsBtn_Click);
            // 
            // productsBtn
            // 
            this.productsBtn.Location = new System.Drawing.Point(63, 83);
            this.productsBtn.Name = "productsBtn";
            this.productsBtn.Size = new System.Drawing.Size(92, 32);
            this.productsBtn.TabIndex = 2;
            this.productsBtn.Text = "Products";
            this.productsBtn.UseVisualStyleBackColor = true;
            this.productsBtn.Click += new System.EventHandler(this.productsBtn_Click);
            // 
            // employeesBtn
            // 
            this.employeesBtn.Location = new System.Drawing.Point(63, 31);
            this.employeesBtn.Name = "employeesBtn";
            this.employeesBtn.Size = new System.Drawing.Size(92, 26);
            this.employeesBtn.TabIndex = 1;
            this.employeesBtn.Text = "Employees";
            this.employeesBtn.UseVisualStyleBackColor = true;
            this.employeesBtn.Click += new System.EventHandler(this.employeesBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(1136, 12);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(132, 55);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // logOutBtn
            // 
            this.logOutBtn.Location = new System.Drawing.Point(0, 0);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(75, 23);
            this.logOutBtn.TabIndex = 6;
            this.logOutBtn.Text = "Log Out";
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Visible = false;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // logoPb
            // 
            this.logoPb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(162)))), ((int)(((byte)(254)))));
            this.logoPb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoPb.Image = global::ProjectMB.Properties.Resources.emp_add;
            this.logoPb.Location = new System.Drawing.Point(817, 12);
            this.logoPb.Name = "logoPb";
            this.logoPb.Size = new System.Drawing.Size(289, 226);
            this.logoPb.TabIndex = 7;
            this.logoPb.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.logoPb);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.selectionPnl);
            this.Controls.Add(this.loginPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Bazaar Management System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.loginPnl.ResumeLayout(false);
            this.loginComponentsPnl.ResumeLayout(false);
            this.loginComponentsPnl.PerformLayout();
            this.selectionPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox usernameTb;
        private System.Windows.Forms.TextBox passwordTb;
        private System.Windows.Forms.Panel loginPnl;
        private System.Windows.Forms.Panel selectionPnl;
        private System.Windows.Forms.Button productsBtn;
        private System.Windows.Forms.Button employeesBtn;
        private System.Windows.Forms.Panel loginComponentsPnl;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Label usernameLbl;
        private Button statisticsBtn;
        private Button departmentsBtn;
        private PictureBox logoPb;
    }
}

