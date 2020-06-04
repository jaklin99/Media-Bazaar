using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectMB
{
    public partial class MainForm : Form
    {
        [DllImport("user32")]
        static extern bool AnimateWindow(IntPtr hWnd, int time, AnimateWindowFlags flags);

        public MainForm()
        {
            InitializeComponent();
            
            usernameTb.Click += new EventHandler(click_username);
            usernameTb.Leave += new EventHandler(leave_username);
            passwordTb.Click += new EventHandler(click_password);
            passwordTb.Leave += new EventHandler(leave_password);
            try
            {
                if (!DatabaseFunctions.GetAllUsers() && !DatabaseFunctions.GetAllProducts())
                {
                    MessageBox.Show("Loading Data Failure, please restart", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                if (!DatabaseFunctions.GetAllDepartments()) 
                {
                    MessageBox.Show("Loading Data Failure, please restart", "Error", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                }

                if (!File.Exists("idSeeder"))
                {
                    string id = (Users.LastGenUsernameId() + 1).ToString();
                    File.WriteAllLines("idSeeder", new string[] { id });
                }
            }
            catch (NoConnectionException)
            {

                MessageBox.Show("Loading Data Failure, please restart", "Error", MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
            }
            catch (IOException)
            {
                MessageBox.Show("Loading Data Failure, please restart", "Error", MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
            }


        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Normal;
            InitializeDesign();
            this.Focus(); 
            this.Show();
            AnimateWindow(this.Handle, 500, AnimateWindowFlags.AW_BLEND);

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Design

        private void InitializeDesign()
        {
            //
            //Modifications
            //
            this.ClientSize = new Size((int) (System.Windows.SystemParameters.PrimaryScreenWidth),
              (int) (System.Windows.SystemParameters.PrimaryScreenHeight));
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;

            this.loginPnl.SetBounds(0, 0, this.ClientSize.Width, this.ClientSize.Height);
            this.loginPnl.BackColor = Color.FromArgb(193, 162, 254);

            this.loginComponentsPnl.Size = new System.Drawing.Size(loginPnl.Width / 2, loginPnl.Height / 2);
            this.loginComponentsPnl.Location = new Point((loginPnl.Width - loginComponentsPnl.Width) / 2,
                (loginPnl.Height - loginComponentsPnl.Height) / 2);
            this.loginComponentsPnl.Anchor = AnchorStyles.None;
            int lcw = loginComponentsPnl.Width;
            int lch = loginComponentsPnl.Height;

            this.loginBtn.Size = new Size(usernameTb.Width * 2, loginComponentsPnl.Height / 8);
            this.loginBtn.Location = new Point((loginComponentsPnl.Width - loginBtn.Width) / 2,
                (lch / 3) + usernameTb.Height + 5);
            this.loginBtn.BackColor = Color.FromArgb(5, 179, 245);
            this.loginBtn.FlatStyle = FlatStyle.Flat;

            //this.logoPb.Size = new Size(usernameTb.Width * 2, loginComponentsPnl.Height / 8);
            this.logoPb.Location = new Point((Width - logoPb.Width) / 2,
               5);          

            this.usernameTb.AutoSize = false;
            this.usernameTb.Text = "Username";
            this.usernameTb.BorderStyle = BorderStyle.None;
            this.usernameTb.Controls.Add(usernameLbl);
            usernameTb.SetBounds((lcw - (lcw * 8 / 10)) / 2, 25, lcw * 8 / 10, lch * 1 / 10);
            usernameLbl.Height = 1;

            this.passwordTb.AutoSize = false;
            this.passwordTb.Text = "Password";
            this.passwordTb.BorderStyle = BorderStyle.None;
            this.passwordTb.Controls.Add(passwordLbl);
            passwordTb.SetBounds((lcw - (lcw * 8 / 10)) / 2, (lch / 10) + usernameTb.Height + 5, lcw * 8 / 10,
                lch * 1 / 10);
            passwordTb.PasswordChar = '*';
            passwordTb.MaxLength = 12;

            passwordLbl.Height = 1;

            selectionPnl.Visible = false;
            selectionPnl.SetBounds(0, 0, this.ClientSize.Width, this.ClientSize.Height);
            this.selectionPnl.BackColor = Color.FromArgb(193, 162, 254);

            this.employeesBtn.Size = new Size(selectionPnl.Width / 5, selectionPnl.Height / 10);
            this.employeesBtn.Location = new Point(selectionPnl.Width / 2 - employeesBtn.Width - 25,
                (selectionPnl.Height - employeesBtn.Height) / 3);
            this.employeesBtn.BackColor = Color.FromArgb(5, 179, 245);
            this.employeesBtn.FlatStyle = FlatStyle.Flat;

            this.productsBtn.Size = new Size(selectionPnl.Width / 5, selectionPnl.Height / 10);
            this.productsBtn.Location = new Point((selectionPnl.Width / 2 + 25),
                (selectionPnl.Height - productsBtn.Height) / 3);
            this.productsBtn.BackColor = Color.FromArgb(5, 179, 245);
            this.productsBtn.FlatStyle = FlatStyle.Flat;

            this.statisticsBtn.Size = new Size(selectionPnl.Width / 5, selectionPnl.Height / 10);
            this.statisticsBtn.Location = new Point((selectionPnl.Width / 2 + 25),
                (selectionPnl.Height - statisticsBtn.Height) / 2);
            this.statisticsBtn.BackColor = Color.FromArgb(5, 179, 245);
            this.statisticsBtn.FlatStyle = FlatStyle.Flat;

            this.departmentsBtn.Size = new Size(selectionPnl.Width / 5, selectionPnl.Height / 10);
            this.departmentsBtn.Location = new Point((selectionPnl.Width / 2 - departmentsBtn.Width - 25),
                (selectionPnl.Height - employeesBtn.Height) / 2);
            this.departmentsBtn.BackColor = Color.FromArgb(5, 179, 245);
            this.departmentsBtn.FlatStyle = FlatStyle.Flat;


            this.exitBtn.Size = new Size(loginPnl.Width / 15, loginPnl.Height / 20);
            this.exitBtn.Location = new Point(loginPnl.Width - exitBtn.Width - 25, 10);
            this.exitBtn.BackColor = Color.FromArgb(5, 179, 245);
            this.exitBtn.FlatStyle = FlatStyle.Flat;

            this.logOutBtn.Size = new Size(loginPnl.Width / 15, loginPnl.Height / 20);
            this.logOutBtn.Location = new Point(loginPnl.Width - exitBtn.Width - logOutBtn.Width - 10 - 25, 10);
            this.logOutBtn.BackColor = Color.FromArgb(5, 179, 245);
            this.logOutBtn.FlatStyle = FlatStyle.Flat;
        }

        private void click_username(Object sender, EventArgs e)
        {
            if (usernameTb.Text == "Username")
            {
                usernameTb.Text = "";
            }

            usernameLbl.BackColor = Color.FromArgb(218, 112, 214);
        }

        private void leave_username(Object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernameTb.Text))
            {
                usernameTb.Text = "Username";
            }

            usernameLbl.BackColor = Color.FromArgb(125, 249, 255);
        }

        private void click_password(Object sender, EventArgs e)
        {
            if (passwordTb.Text == "Password")
            {
                passwordTb.Text = "";
            }

            passwordLbl.BackColor = Color.FromArgb(218, 112, 214);
        }

        private void leave_password(Object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(passwordTb.Text))
            {
                passwordTb.Text = "Password";
            }

            passwordLbl.BackColor = Color.FromArgb(125, 249, 255);
        }

        private void usernameTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.SelectNextControl(usernameTb, true, true, true, true);
               
            }
        }

        private void passwordTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                loginBtn_Click(sender, e);
            }
        }

        #endregion

        #region Login

        private void loginBtn_Click(object sender, EventArgs e)
        {
            User user = Users.FindUser(usernameTb.Text.Trim());
            if (user != null)
            {
                if (user.Position == PersonPosition.Manager || user.Position == PersonPosition.Admin)
                {
                    if (user.Position == PersonPosition.Admin) Users.admin = true;                   
                    string pass = DatabaseFunctions.PasswordByUsername(user.Username);
                    if (pass == passwordTb.Text)
                    {
                        loginPnl.Visible = false;
                        selectionPnl.Visible = true;
                        logOutBtn.Visible = true;
                        usernameTb.Text = "Username";
                        passwordTb.Text = "Password";
                        Users.Department = user.UserDepartment.Name;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect password, please try again!");
                    }
                }
                else
                {
                    MessageBox.Show("This Platform is only for managers!");
                }
            }
            else
            {
                MessageBox.Show("No such user, please try again!");
            }
        }

        #endregion

        #region Logged in

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            loginPnl.Visible = true;
            selectionPnl.Visible = false;
            logOutBtn.Visible = false;
        }

        private void employeesBtn_Click(object sender, EventArgs e)
        {
            EmployeesForm employeesForm = new EmployeesForm();
            employeesForm.Show();
        }

        private void productsBtn_Click(object sender, EventArgs e)
        {
            ProductsForm productsForm = new ProductsForm();
            productsForm.Show();
        }

        private void statisticsBtn_Click(object sender, EventArgs e)
        {
            StatisticsForm statisticsForm = new StatisticsForm();
            statisticsForm.Show();
        }

        private void departmentsBtn_Click(object sender, EventArgs e)
        {
            DepartmentsForm departmentsForm = new DepartmentsForm();
            departmentsForm.Show();
        }




        #endregion

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnimateWindow(this.Handle, 1000, AnimateWindowFlags.AW_BLEND | AnimateWindowFlags.AW_HIDE);
        }
    }
}